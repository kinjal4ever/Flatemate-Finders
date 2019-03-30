using System;
using System.Collections.Generic;
using System.Text;

namespace FlatmateFinders.Services
{
    //Message Interface 
	public interface IMessage
	{
		void LongAlert(string message);
		void ShortAlert(string message);
	}
}
