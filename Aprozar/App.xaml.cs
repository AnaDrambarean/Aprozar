using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using Aprozar.Data;

namespace Aprozar
{
    public partial class App : Application
    {
        static AprozarDatabase database;
        public static AprozarDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new AprozarDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CosCumparaturi.db3"));
                }
                return database;
            }
        }

        
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Principala());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
