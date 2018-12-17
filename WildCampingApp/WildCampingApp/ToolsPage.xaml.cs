using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//For flaslight
using Xamarin.Essentials;

namespace WildCampingApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ToolsPage : ContentPage
	{
		public ToolsPage ()
		{
			InitializeComponent ();
		}

        async void btnTorch_Clicked(object sender, EventArgs e)
        {
            //Torch code here
            try
            {
                // Turn On
                await Flashlight.TurnOnAsync();
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
                // Unable to turn on/off flashlight
            }
        }

        async void btnTorch1_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Turn Off
                await Flashlight.TurnOffAsync();
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
                // Unable to turn on/off flashlight
            }
        }
    }
}