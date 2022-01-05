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
    public partial class ListCategorie : ContentPage
    {
        public ListCategorie()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var clist = (Categorie)BindingContext;
            await App.Database.SaveCategorieAsync(clist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object semder, EventArgs e)
        {
            var clist = (Categorie)BindingContext;
            await App.Database.DeleteCategorieAsync(clist);
            await Navigation.PopAsync();
        }
    }
}