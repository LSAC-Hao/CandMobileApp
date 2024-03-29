using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CandMobileApp
{
	//[XamlCompilation (XamlCompilationOptions.Skip)]
	public partial class App : Application
	{
		public static MasterDetailPage MasterDetailPage;

		public App()
		{
			InitializeComponent();

			MainPage = GetMainPage();

			MainPage.SetValue(NavigationPage.BarTextColorProperty, Color.White);
		}

		public static Page GetMainPage()
        {
            return new CandTabbedRootPage();
        }
	}
}
