using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
// API - Geolocation
using Xamarin.Essentials;

namespace WildCampingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnHealth_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new HealthPage());
        }

        private void btntools_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ToolsPage());
        }

        private void btnKnots_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new KnotsPage());
        }

        private void btnChecklist_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ChecklistPage());
        }

        private void btnLocation_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new LocationPage());
        }
    }
}
