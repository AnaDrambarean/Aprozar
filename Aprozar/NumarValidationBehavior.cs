using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Aprozar
{
    class NumarValidationBehavior : Behavior<Editor>
    {
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
            int result;
            bool isValid = int.TryParse(args.NewTextValue, out result);
            ((Editor)sender).BackgroundColor = isValid ? Color.LightGreen : Color.LightCoral;
        }
    }
}
