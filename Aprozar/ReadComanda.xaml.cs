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
    public partial class ReadComanda : ContentPage
    {
        public ReadComanda()
        {
            InitializeComponent();
        }
        async void OnCreateButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListComanda
            {
                BindingContext = new Comanda()
            });
        }
        async void OnViewButtonClicked(object sender, EventArgs e)
        {
            listView.ItemsSource = await App.Database.GetComandaAsync();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetComandaAsync();
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ListComanda
                {
                    BindingContext = e.SelectedItem as Comanda
                });
            }
        }

    }
}