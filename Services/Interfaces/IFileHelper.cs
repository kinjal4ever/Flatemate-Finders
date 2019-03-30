using System;
using System.Collections.Generic;
using System.Text;

namespace FlatmateFinders.Services
{
    // File Helper Interface for Different Platforms
	public interface IFileHelper
	{
		string GetLocalFilePath(string filename);
	}
}
