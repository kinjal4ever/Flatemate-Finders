using FlatmateFinders.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FlatmateFinders.ViewModels
{
    //View Model for FAQ Page

    public class FAQViewModel
    {
        private FAQ _oldProduct;
        public ObservableCollection<FAQ> FAQs { get; set; }

        public FAQViewModel() {
            FAQs = new ObservableCollection<FAQ>
            {
                new FAQ
                {
                    Title = "Didn't receive Password email",
                    Description="If you don't receive our email within a few minutes, check your junk or spam folder. To ensure that you receive our emails, add our email address to your contacts before using 'Forgot Password' again. Our email address is listed on our Contact Us page.",
                    Isvisible =false
                },
                new FAQ
                {
                    Title = "Forgot your login email address",
                    Description="If you've forgotten your email address, use the \"Forgot Password\" link above to submit each of your email addresses until one of them is recognised.",
                    Isvisible = false
                },
                new FAQ
                {
                    Title = "Can't access your email address",
                    Description="If you don't have access to your email inbox, but you can remember your password, then log in and change your email address. However, if you've forgotten your password, ask our service team to change your login email address so you can reset your password. Please send us the following information: Your full name and mobile number. Your current login email address. The email address that you want to use for your login. Click here to contact us",
                    Isvisible = false
                },
                new FAQ
                {
                    Title = "How to log in with Facebook",
                    Description="If your login email for this service is the same as your login email for Facebook, then you can use the \"Log in with Facebook\" button. If your login email for this service is different to your login email for Facebook, you'll need to change your login email on this service so it's the same as Facebook before you can use the \"Log in with Facebook\" button.",
                    Isvisible =  false
                },
                new FAQ
                {
                    Title = "How to create a new profile",
                    Description="If you're an existing user of this service you can create a new profile after you log in by selecting the \"Create New Profile\" option on the menu that opens from the page header after you log in.",
                    Isvisible = false
                }
            };
        }

        public void ShoworHiddenProducts(FAQ product)
        {
            if (_oldProduct == product)
            {
                product.Isvisible = !product.Isvisible;
                UpDateProducts(product);
            }
            else
            {
                if (_oldProduct != null)
                {
                    _oldProduct.Isvisible = false;
                    UpDateProducts(_oldProduct);

                }
                product.Isvisible = true;
                UpDateProducts(product);
            }
            _oldProduct = product;
        }

        private void UpDateProducts(FAQ faq)
        {

            var Index = FAQs.IndexOf(faq);
            FAQs.Remove(faq);
            FAQs.Insert(Index, faq);
        }
    }
}
