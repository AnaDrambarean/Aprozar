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
    public partial class ListProdus : ContentPage
    {
        public ListProdus()
        {
            InitializeComponent();
        }
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var clist = (Produs)BindingContext;
        await App.Database.SaveProdusAsync(clist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object semder, EventArgs e)
    {
        var clist = (Produs)BindingContext;
        await App.Database.DeleteProdusAsync(clist);
        await Navigation.PopAsync();
    }
}
}