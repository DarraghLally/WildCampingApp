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
        bool isActive = false;

        public ToolsPage()
        {
            InitializeComponent();
        }

        //onClick handler for torch button
        async void btnTorch_Clicked(object sender, EventArgs e)
        {
            //Check Bool
            if (isActive == false) { 

                //Turn On, change btn.Text, change bool - OR - Display Error Message
                try
                {
                    // Turn On
                    await Flashlight.TurnOnAsync();
                }
                catch (FeatureNotSupportedException fnsEx)
                {
                    // Handle not supported on device exception
                    lblError.Text = "Flashlight Not Supported";
                }
                catch (PermissionException pEx)
                {
                    // Handle permission exception
                    lblError.Text = "Please Enable Camera Permissions for use of flash, we are not spying on you!";
                }
                catch (Exception ex)
                {
                    // Unable to turn on/off flashlight
                    lblError.Text = "An Error Has Occurred.\nPlease Restart The App";
                }
                isActive = true;
                btnTorch.Text = "ON";
            }//if - ON

            //turn Off, change bool, change btn.Text
            else
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
                isActive = false;
                btnTorch.Text = "OFF";
            }//else - OFF

        }//button clicked       

    }//Tools Page
}//WCApp