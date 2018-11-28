using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace WildCampingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SetBackgroundImage();
        }

        private void SetBackgroundImage()
        {
            var assembly = typeof(MainPage);
            string strFileName = "WildCampingApp.Assets.Images.mainPage.png";
            background_Img.Source = ImageSource.FromResource(strFileName, assembly);
        }

        //On Click methods
        async void btnHealth_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HealthPage());
        }

        async void btntools_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ToolsPage());
        }

        async void btnKnots_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KnotsPage());
        }

        async void btnChecklist_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChecklistPage());
        }

        async void btnLocation_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LocationPage());
        }

        
    }
}
