using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//Adding Essentials Library
using Xamarin.Essentials;

namespace WildCampingApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChecklistPage : ContentPage
	{
        //Global Variable
        int intHeading;

		public ChecklistPage ()
		{
			InitializeComponent ();
            arrowImage.Source = ImageSource.FromResource("WildCampingApp.Assets.Images.arrow.png");
            Compass.ReadingChanged += Compass_ReadingChanged;
        }

        //Look for direction change & output heading
        void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
        {
            //saving heading as double
            double heading = e.Reading.HeadingMagneticNorth;
            //format heading 
            double formatHeading = Math.Round(heading, 2, MidpointRounding.AwayFromZero);
            intHeading = (int)heading;
            //Output heading
            //lblCompass.Text = formatHeading.ToString() + " Degrees NORTH";
            lblCompass.Text = intHeading.ToString() + " " + headingDirection();
        }

        //Sensor update speed when in use
        protected override void OnAppearing()
        {
            try { 
                base.OnAppearing();
                //Determine the compass heading update speed 
                Compass.Start(SensorSpeed.Normal);
            }
            catch
            {
                lblCompass.Text = "Feature Not Supported";
            }
        }

        //Turn off when not on page
        protected override void OnDisappearing()
        {
            try { 
                base.OnDisappearing();
                //Stop compass reading
                Compass.Stop();
            }
            catch
            {

            }
        }

        //Given a heading find the direction
        public string headingDirection()
        {
            var angle = intHeading;
            var directions = 8;

            var degree = 360 / directions;
            angle = angle + degree / 2;

            if (angle >= 0 * degree && angle < 1 * degree)
                return "N";
            if (angle >= 1 * degree && angle < 2 * degree)
                return "NE";
            if (angle >= 2 * degree && angle < 3 * degree)
                return "E";
            if (angle >= 3 * degree && angle < 4 * degree)
                return "SE";
            if (angle >= 4 * degree && angle < 5 * degree)
                return "S";
            if (angle >= 5 * degree && angle < 6 * degree)
                return "SW";
            if (angle >= 6 * degree && angle < 7 * degree)
                return "W";
            if (angle >= 7 * degree && angle < 8 * degree)
                return "NW";

            return "N";
        }

    }
}