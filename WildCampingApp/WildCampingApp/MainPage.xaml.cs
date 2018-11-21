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
            currentLocation();
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

        //Method for getting current location
        public async void currentLocation() {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);

                if (location != null)
                {
                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }

        }
    }
}
