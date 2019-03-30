using FlatmateFinders.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlatmateFinders.Services
{
    //Login Service for Login Page to verify user login through sqlite
	public interface ILoginService
    {
		Task<int> AuthorizationAsync(FFUsers obj);
        Task<FFUsers> GetLoggedInUser();

    }
}
