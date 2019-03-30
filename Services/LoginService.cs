using System.Threading.Tasks;
using FlatmateFinders.Models;

namespace FlatmateFinders.Services
{
    //Login Service for Login Page to verify user login through sqlite

    public class LoginService : ILoginService
    {

        //1 for Offering & 2 for Looking for Home
        public async Task<int> AuthorizationAsync(FFUsers obj)
        {
            if (obj != null)
            {
                return await App.Database.Authorization(obj.Email, obj.Password);
            }
            return 0;
        }

        public async Task<FFUsers> GetLoggedInUser()
        {
            return await App.Database.GetLoggedInUser();
        }
    }
}
