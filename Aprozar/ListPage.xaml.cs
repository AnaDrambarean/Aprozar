using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Aprozar.Models;

namespace Aprozar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var clist = (CosCumparaturi)BindingContext;
            clist.Data = DateTime.UtcNow;
            await App.Database.SaveCosCumparaturiAsync(clist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var clist = (CosCumparaturi)BindingContext;
            await App.Database.DeleteCosCumparaturiAsync(clist);
            await Navigation.PopAsync();
        }
    }
}