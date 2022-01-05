using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aprozar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principala : ContentPage
    {
        public Principala()
        {
            InitializeComponent();
        }
        private void viewClient(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReadClient());
        }
        private void viewFurnizor(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReadFurnizor());
        }
        private void viewCategorie(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReadCategorie());
        }
        private void viewProdus(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReadProdus());
        }
        private void viewComanda(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReadComanda());
        }
    }
}