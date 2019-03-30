using FlatmateFinders.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlatmateFinders.Services
{
    // Register User through Sqlite
	public interface IRegistrationService
    {
		Task<bool> CreateAccount(FFUsers obj);
	}
}
