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
    public partial class ReadFurnizor : ContentPage
    {
        public ReadFurnizor()
        {
            InitializeComponent();
        }
        async void OnFurnizorAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListFurnizor
            {
                BindingContext = new Furnizor()
            });
        }
        async void OnFurnizorAddedView(object sender, EventArgs e)
        {
            listView.ItemsSource = await App.Database.GetFunizorAsync();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetFunizorAsync();
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ListFurnizor
                {
                    BindingContext = e.SelectedItem as Furnizor
                });
            }
        }
    }
}