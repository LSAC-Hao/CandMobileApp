using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CandMobileApp
{
	public partial class CandLawSchoolPage : ContentPage
	{
        private ObservableCollection<GroupedCandMenu> grouped { get; set; }

        public CandLawSchoolPage()
		{
			InitializeComponent ();
		}

        private async void GotoThinkingJD(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoChoosingJD(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoApplyingJD(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoFinancingJD(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoDiversityJD(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }

        private async void GotoLLMDegree(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoChoosingLLM(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoLLMProcess(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoOffGuideJD(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoOffGuideLLM(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoForums(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoRecruitment(Object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
    
        private void GotoMore(Object sender, EventArgs e)
        {
            CandCollapsedMenuViewModel _me = (CandCollapsedMenuViewModel)Menu.BindingContext;
            if (_me.Collapsed) _me.Collapsed = false; else _me.Collapsed = true;
        }

    }
}

