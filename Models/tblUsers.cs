using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlatmateFinders.Models
{
    //Users Model for Sqlite Storage 
    public class FFUsers
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ContactPerson { get; set; }
        public bool isOffering { get; set; }
        public bool IsLoggedIn { get; set; }
    }
}
