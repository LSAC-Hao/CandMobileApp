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

        private async void GotoThinkingJD(Object sender, ItemTappedEventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoChoosingJD(Object sender, ItemTappedEventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoApplyingJD(Object sender, ItemTappedEventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoFinancingJD(Object sender, ItemTappedEventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoDiversityJD(Object sender, ItemTappedEventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }

        private async void GotoLLMDegree(Object sender, ItemTappedEventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoChoosingLLM(Object sender, ItemTappedEventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoLLMProcess(Object sender, ItemTappedEventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoOffGuideJD(Object sender, ItemTappedEventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoOffGuideLLM(Object sender, ItemTappedEventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoForums(Object sender, ItemTappedEventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
        private async void GotoRecruitment(Object sender, ItemTappedEventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var myMenuItem = (CandMenuItem)selectedItem;

            await CandRouterPage.NavigateToPage(myMenuItem.Key, Navigation);
        }
    
        private void GotoMore(Object sender, ItemTappedEventArgs e)
        {
            CandCollapsedMenuViewModel _me = (CandCollapsedMenuViewModel)Menu.BindingContext;
            if (_me.Collapsed) _me.Collapsed = false; else _me.Collapsed = true;
        }

    }
}

