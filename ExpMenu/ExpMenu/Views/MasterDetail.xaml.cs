using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpMenu.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterDetail : MasterDetailPage
	{
		public MasterDetail ()
		{
			InitializeComponent ();
            Master = masterpage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MainPage)));
            MasterBehavior = MasterBehavior.Popover;
        }
	}
}