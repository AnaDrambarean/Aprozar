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
    public partial class ListClient : ContentPage
    {
        public ListClient()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var clist = (Client)BindingContext;
            await App.Database.SaveClientAsync(clist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object semder, EventArgs e)
        {
            var clist = (Client)BindingContext;
            await App.Database.DeleteClientAsync(clist);
            await Navigation.PopAsync();
        }
    }
}
