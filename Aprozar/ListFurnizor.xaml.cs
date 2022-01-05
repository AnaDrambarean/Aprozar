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
    public partial class ListFurnizor : ContentPage
    {
        public ListFurnizor()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var clist = (Furnizor)BindingContext;
            await App.Database.SaveFurnizorAsync(clist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var clist = (Furnizor)BindingContext;
            await App.Database.DeleteFurnizorAsync(clist);
            await Navigation.PopAsync();
        }
    }
}