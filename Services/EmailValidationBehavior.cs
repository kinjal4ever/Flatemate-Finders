using FlatmateFinders.Common;
using SuaveControls.MaterialForms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace FlatmateFinders.Services
{
    //Validation Behavior for Email
    public class EmailValidationBehavior : Behavior<MaterialEntry>
    {
        #region Properties
        public int MaxLength { get; set; }
        public int MinLength { get; set; } = 0;

        #endregion

        #region Events
        /// <summary>
        /// Attach events on attachment to view
        /// </summary>
        /// <param name="bindable">Bindable.</param>
        protected override void OnAttachedTo(MaterialEntry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += OnEntryTextChanged;
            bindable.EntryUnfocused += Bindable_EntryUnfocused;
        }

        /// <summary>
        /// Detach events on detaching from view
        /// </summary>
        /// <param name="bindable">Bindable.</param>
        protected override void OnDetachingFrom(MaterialEntry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= OnEntryTextChanged;
            bindable.EntryUnfocused -= Bindable_EntryUnfocused;
        }

        /// <summary>
        /// Stop text input once max is hit
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = (Entry)sender;

            if (entry.Text == null)
                return;

            // if Entry text is longer than valid length
            if (entry.Text.Length > this.MaxLength)
            {
                string entryText = entry.Text;

                entryText = entryText.Remove(entryText.Length - 1); // remove last char

                entry.Text = entryText;
            }


        }

        /// <summary>
        /// Set invalid on unfocus if the min is not met
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        /// Display Validation Message and Line Color Change on lost focus event
        void Bindable_EntryUnfocused(object sender, FocusEventArgs e)
        {
           Label errorLabel = ((MaterialEntry)sender).FindByName<Label>("EmailValidationMessage");

            var entry = (MaterialEntry)sender;
            if (MinLength > 0)
            {
                if (entry.Text == null || entry.Text.Length < this.MinLength || !Regex.IsMatch(entry.Text,ErrorList.EmailRegex))
                {
                    entry.IsValid = false;
                    errorLabel.Text =  ErrorList.EmailError;
                }
                else
                {
                    entry.IsValid = true;
                    errorLabel.Text = "";
                }
            }
        }

        #endregion
    }
}
