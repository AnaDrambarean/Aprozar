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
    public partial class ReadCategorie : ContentPage
    {
        public ReadCategorie()
        {
            InitializeComponent();
        }
        async void OnCategorieAddClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListCategorie
            {
                BindingContext = new Categorie()
            });
        }
        async void OnCategorieViewClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListCategorie
            {
                BindingContext = new Categorie()
            });
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetCategorieAsync();
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ListCategorie
                {
                    BindingContext = e.SelectedItem as Categorie
                });
            }
        }
    }
}