using System;
using Xamarin.Forms;

namespace CandMobileApp
{
	public static class NavigationPageHelper
	{
		public static NavigationPage Create(Page page)
		{
			return new NavigationPage(page) { BarTextColor = Color.White };
		}
	}
}
