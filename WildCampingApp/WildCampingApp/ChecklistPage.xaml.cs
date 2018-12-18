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
		public ChecklistPage ()
		{
			InitializeComponent ();
            Compass.ReadingChanged += Compass_ReadingChanged;
        }

        void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
        {
            //LabelInfo.Text = $"Heading: {e.Reading.HeadingMagneticNorth}";
            //ImageArrow.Rotation = e.Reading.HeadingMagneticNorth;
            lblCompass.Text = $"Heading: {e.Reading.HeadingMagneticNorth}";
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Compass.Start(SensorSpeed.UI);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Compass.Stop();
        }

    }
}