using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urho;
using Urho.Forms;
using Xamarin.Forms;

namespace HelloUrho
{
    public partial class MainPage : ContentPage
    {
        private UrhoSurface urhoSurface;

        public MainPage()
        {
            InitializeComponent();

            urhoSurface = new UrhoSurface();

            // UrhoViewはMainPage.xamlで定義済
            this.FindByName<ContentView>("UrhoView").Content = urhoSurface;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await urhoSurface.Show<HelloUrhoApp>(new ApplicationOptions(assetsFolder: null));
        }
    }
}
