using FlatmateFinders.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FlatmateFinders.Common
{
    public class Global
    {
        //Display Popup Message
        public static void ShowToastMessage(string Message)
        {
            DependencyService.Get<IMessage>().ShortAlert(Message);
        }
    }
}
