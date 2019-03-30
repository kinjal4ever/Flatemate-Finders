using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FlatmateFinders.Services
{
    //Common Converter for Bool value to other types like image,color,style
    public class BoolToImageConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (parameter.ToString() == "checkbox")
                return (bool)value ? "checked.png" : "unchecked.png";
            else if (parameter.ToString() == "ButtonSelection")
                return (bool)value ? (Style)Application.Current.Resources["SelectedButton"] : (Style)Application.Current.Resources["UnSelectedButton"];
            else if (parameter.ToString() == "SingleButtonSelection")
                return (bool)value ? (Style)Application.Current.Resources["HomePageButtonBlue"] : (Style)Application.Current.Resources["HomePageButton"];
            else if (parameter.ToString() == "SingleFrameSelection")
                return (bool)value ? (Style)Application.Current.Resources["HomePageFrameBlue"] : (Style)Application.Current.Resources["HomePageFrame"];
            else if (parameter.ToString() == "SingleFrameColor")
                return (bool)value ? (Color)Application.Current.Resources["clean"] : (Color)Application.Current.Resources["BlueGrey"];
            else if (parameter.ToString() == "SingleButtonSelectionReverse")
                return (bool)value ? (Style)Application.Current.Resources["HomePageButton"] : (Style)Application.Current.Resources["HomePageButtonBlue"];
            else if (parameter.ToString() == "ButtonSelectionReverse")
                return (bool)value ? (Style)Application.Current.Resources["UnSelectedButton"] : (Style)Application.Current.Resources["SelectedButton"];
            else if (parameter.ToString() == "SelectionLabel")
                return (bool)value ? (Color)Application.Current.Resources["clean"] : (Color)Application.Current.Resources["PrimaryTextColor"];
            else if (parameter.ToString() == "SelectionLabelReverse")
                return (bool)value ? (Color)Application.Current.Resources["PrimaryTextColor"] : (Color)Application.Current.Resources["clean"];
            else
                return (bool)value ? "iconArrowUp.svg" : "iconArrowDown.svg";
            //return (bool)value ? "checked.svg" : "unchecked.svg";
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return false; // not needed
        }
    }
}
