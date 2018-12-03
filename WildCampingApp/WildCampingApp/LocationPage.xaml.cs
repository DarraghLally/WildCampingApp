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

                    //**Converting GPS Lat to DMS Lat              
                    // Getting Degrees and Converting minutes
                    int latDegrees = (int)location.Latitude;
                    double latDecOne = location.Latitude - latDegrees;
                    double latMinutesDec = latDecOne * 60;
                    //Converting seconds and rounding seconds to 2 places
                    int latMinutes = (int)latMinutesDec;
                    double latDecTwo = latMinutesDec - latMinutes;
                    double latSeconds = latDecTwo * 60;
                    double latSecondsRound = Math.Round(latSeconds, 2, MidpointRounding.AwayFromZero);
                    //Display compass direction
                    String compassHeadingLat;
                    if (location.Latitude > 0)
                    {
                        compassHeadingLat = "North";
                    }
                    else {
                        compassHeadingLat = "South";
                    }
                    //Display to label
                    String outputLat ="Latitude: " + Math.Abs(latDegrees) +  " degree's | " + Math.Abs((int)latMinutes) + " minute's | " + Math.Abs(latSecondsRound) + " second's " + compassHeadingLat;
                    lblLocationDisplay_Lat.Text = outputLat;

                    //**Converting GPS Long to DMS Long              
                    // Getting Degrees and Converting minutes
                    int lonDegrees = (int)location.Longitude;
                    double lonDecOne = location.Longitude - lonDegrees;
                    double lonMinutesDec = lonDecOne * 60;
                    //Converting seconds and rounding seconds to 2 places
                    int lonMinutes = (int)lonMinutesDec;
                    double lonDecTwo = lonMinutesDec - lonMinutes;
                    double lonSeconds = lonDecTwo * 60;
                    double lonSecondsRound = Math.Round(lonSeconds, 2, MidpointRounding.AwayFromZero);
                    //Display compass direction
                    String compassHeadingLon;
                    if (location.Longitude > 0)
                    {
                        compassHeadingLon = "East";
                    }
                    else
                    {
                        compassHeadingLon = "West";
                    }
                    //Display to label
                    String outputLon = "Longitude: " + Math.Abs(lonDegrees) + " degree's | " + Math.Abs((int)lonMinutes) + " minute's | " + Math.Abs(lonSecondsRound) + " second's " + compassHeadingLon;
                    lblLocationDisplay_Long.Text = outputLon;


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