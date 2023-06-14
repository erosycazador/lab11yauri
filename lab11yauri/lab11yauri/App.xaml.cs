using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab11yauri
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new View.Operaciones();
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
