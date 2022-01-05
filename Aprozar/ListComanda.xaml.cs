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
    public partial class ListComanda : ContentPage
    {
        public ListComanda()
        {
            InitializeComponent();
        }
        
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var clist = (Comanda)BindingContext;
            await App.Database.SaveComandaAsync(clist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var clist = (Comanda)BindingContext;
            await App.Database.DeleteComandaAsync(clist);
            await Navigation.PopAsync();
        }
    }
}