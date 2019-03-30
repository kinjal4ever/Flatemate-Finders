using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using FlatmateFinders.Models;
using FlatmateFinders;

namespace FlatmateFinders.Services
{
    // Register User through Sqlite

    public class RegistrationService : IRegistrationService
	{
		public async Task<bool> CreateAccount(FFUsers obj)
		{
			bool boolResult = false;
			var save = await App.Database.SaveItemAsync(obj);
			if (save == 1)
			{
				boolResult = true;
			}
			return boolResult;
		}
	}
}
