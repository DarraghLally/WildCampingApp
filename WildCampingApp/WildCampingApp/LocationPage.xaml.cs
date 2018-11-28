using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//Geo location API
using Xamarin.Essentials;

namespace WildCampingApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LocationPage : ContentPage
	{
		public LocationPage ()
		{
			InitializeComponent ();
            currentLocation();
		}

        //Method for getting current location - code from zamarin forms blog
        public async void currentLocation()
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);

                if (location != null)
                {
                    var lat = location.Latitude;
                    var lon = location.Longitude;
                    String latOutput = "Latitude: " + lat;
                    String lonOutput = "Longitude: " + lon;
                    //Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                    lblLocationDisplay_Lat.Text = latOutput;
                    lblLocationDisplay_Long.Text = lonOutput;
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                lblLocationDisplay_Lat.Text = "Unable to get Latitude";
                lblLocationDisplay_Long.Text = "Unable to get Longitude";
            }
            catch (PermissionException pEx)
            {
                lblLocationDisplay_Lat.Text = "Unable to get Latitude";
                lblLocationDisplay_Long.Text = "Unable to get Longitude";
            }
            catch (Exception ex)
            {
                lblLocationDisplay_Lat.Text = "Unable to get Latitude";
                lblLocationDisplay_Long.Text = "Unable to get Longitude";
            }

        }
    }
}