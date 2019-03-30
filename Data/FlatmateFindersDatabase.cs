using FlatmateFinders.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlatmateFinders.Data
{
    // SQLite Database Connection Pool
    public class FlatmateFindersDatabase
    {
        readonly SQLiteAsyncConnection database;


        //Constructor
        public FlatmateFindersDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<FFUsers>().Wait();
        }

        public Task<List<FFUsers>> GetItemsAsync()
        {
            return database.Table<FFUsers>().ToListAsync();
        }

        public Task<List<FFUsers>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<FFUsers>("SELECT * FROM [FFUsers] WHERE [Done] = 0");
        }


        //Get Perticular User with ID
        public Task<FFUsers> GetItemAsync(int id)
        {
            return database.Table<FFUsers>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }


        //Save User
        public Task<int> SaveItemAsync(FFUsers item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }


        // Delete Users
        public Task<int> DeleteItemAsync(FFUsers item)
        {
            return database.DeleteAsync(item);
        }


        //For Login Authorization from Sqlite Database
        public async Task<int> Authorization(string email, string password)
        {

            var tbls = await database.QueryAsync<FFUsers>("SELECT * FROM [FFUsers]");
            foreach (var property in tbls)
            {
                property.IsLoggedIn = false;
                await database.UpdateAsync(property);
            }

            bool exist = false;
            var data = await database.Table<FFUsers>().Where(i => i.Email == email && i.Password == password).FirstOrDefaultAsync();
            if (data != null)
            {
                data.IsLoggedIn = true;
                await this.SaveItemAsync(data);
                exist = true;

                return (data.isOffering == true) ? 1 : 2;
            }

            return 0;
        }


        // Get List of Users
        public async Task<FFUsers> GetLoggedInUser()
        {
            var tbls = await database.QueryAsync<FFUsers>("SELECT * FROM [FFUsers]");
            var data = await database.Table<FFUsers>().Where(i => i.IsLoggedIn == true).FirstOrDefaultAsync();
            return data;
        }
    }
}
