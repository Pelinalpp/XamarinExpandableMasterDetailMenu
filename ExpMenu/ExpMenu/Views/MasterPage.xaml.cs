using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ExpMenu.Custom;

namespace ExpMenu.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : ContentPage
	{
		public MasterPage ()
		{
			InitializeComponent ();
		}

        public void Item_Clicked(object sender, EventArgs e)
        {
            CustomTextCell textCell = sender as CustomTextCell;
            
            var mdp = Application.Current.MainPage as MasterDetailPage;
            mdp.Detail = new NavigationPage((Page)Activator.CreateInstance(textCell.TargetType));
            mdp.IsPresented = false;
        }

    }
}