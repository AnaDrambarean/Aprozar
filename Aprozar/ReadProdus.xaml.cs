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
    public partial class ReadProdus : ContentPage
    {
        public ReadProdus()
        {
            InitializeComponent();
        }
        async void OnProdusAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListProdus
            {
                BindingContext = new Produs()
            });
        }
        async void OnProdusAddedView(object sender, EventArgs e)
        {
            listView.ItemsSource = await App.Database.GetProdusAsync();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetProdusAsync();
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ListProdus
                {
                    BindingContext = e.SelectedItem as Produs
                });
            }
        }
    }
}
