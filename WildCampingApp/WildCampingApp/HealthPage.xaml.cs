using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WildCampingApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HealthPage : ContentPage
	{
		public HealthPage ()
		{
			InitializeComponent ();
            displayText();
            //Adding images
            stopImage.Source = ImageSource.FromResource("WildCampingApp.Assets.Images.STOP.png");
            sosImage.Source = ImageSource.FromResource("WildCampingApp.Assets.Images.sos.png");
            emNumImage.Source = ImageSource.FromResource("WildCampingApp.Assets.Images.112.png");
        }

        //Method so I can add line break to label text.
        private void displayText()
        {
            String stopInfo = "The STOP abbreviation is used if we find ourselves in a stressfull situation and are unable to make good decisions.\n\n'S' stands for STOP - Take a some time to relax, settle down and clear your head. Sitting down can help.\n\n'T' stands for THINK - Think about your problem and your goals.\n\n'O' stands for OBSERVE or OPTIONS - Observe the surroundings, consider your options.\n\n'P' stands for PLAN - Plan your next move by considering all your options. Choose the best plan.";
            lblSTOP.Text = stopInfo;

            String sosInfo = "SOS - 'Save Our Souls' is an internationally recognised distress call. It can be either visually displayed by writing into the terrain in large letters using rocks or other debris or flashed with a light and Audibly by banging (on the hull of a capsised vessle for instance)\n\nS  ( . . . )  Three short blasts, approx 0.5 seconds each with a similar gap between blasts\n\nO ( - - - ) Three longer blasts, approx 1.5 seconds each with a similar gap between blasts\n\nS  ( . . . )  Three short blasts, approx 0.5 seconds each with a similar gap between blasts ";
            lblSOS.Text = sosInfo;
        }


    }
}