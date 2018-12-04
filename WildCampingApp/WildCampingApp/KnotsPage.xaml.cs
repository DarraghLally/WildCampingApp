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
	public partial class KnotsPage : ContentPage
	{
		public KnotsPage ()
		{
			InitializeComponent ();
            knotTerms.Source = ImageSource.FromResource("WildCampingApp.Assets.Images.knotTerm.png");
            bowLine.Source = ImageSource.FromResource("WildCampingApp.Assets.Images.bowline.png");
            cloveHitch.Source = ImageSource.FromResource("WildCampingApp.Assets.Images.cloveHitch.png");
            prusik.Source = ImageSource.FromResource("WildCampingApp.Assets.Images.prusik.png");
            tarpSet.Source = ImageSource.FromResource("WildCampingApp.Assets.Images.tarpLayout.png");
        }

    }
}