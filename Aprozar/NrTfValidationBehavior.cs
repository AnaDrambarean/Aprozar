using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace Aprozar
{
    class NrTfValidationBehavior:Behavior<Editor>
    {
        const string tfRegex = "^(07)[0-9]{8}$";
        protected override void OnAttachedTo(Editor entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Editor entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }
        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            bool IsValid = false;
            IsValid = (Regex.IsMatch(args.NewTextValue, tfRegex, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)));
            ((Editor)sender).BackgroundColor = IsValid ? Color.LightGreen : Color.LightCoral;
        }
    }
}
