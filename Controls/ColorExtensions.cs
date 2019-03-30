using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace FlatmateFinders.Controls
{
    // Dark Color for Tabbed Page
    public static class ColorExtensions
    {
        public static Color Darken(this Color color)
        {
            return color.WithLuminosity(color.Luminosity * 0.7);
        }
    }
}
