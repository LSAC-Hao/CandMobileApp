using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CandMobileApp
{
	public partial class CandLSATPage : ContentPage
	{
        private ObservableCollection<GroupedCandMenu> grouped { get; set; }

        public CandLSATPage()
		{
			InitializeComponent ();
		}

        private async void GotoAboutLSAT(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoLSATDates(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoFees(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoPreparingLSAT(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoDayOfTheTest(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }

        private async void GotoLSATScore(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoTestCenters(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoDisablities(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoSabbath(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private void GotoMore(Object sender, EventArgs e)
        {
            CandCollapsedMenuViewModel _me = (CandCollapsedMenuViewModel) Menu.BindingContext;
            if (_me.Collapsed) _me.Collapsed = false; else _me.Collapsed = true;
        }
        private async void GotoRegisterLSAT(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoLSATPrepTools(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }

    }
}

