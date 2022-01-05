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
    public partial class AddClient : ContentPage
    {
        public AddClient()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetClientAsync();
        }
        async void OnClientAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListClient
            {
                BindingContext = new Client()
            });
        }
    }
}