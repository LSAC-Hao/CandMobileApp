using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CandMobileApp
{
    public partial class CandLawSchoolPage : ContentPage
    {
        private bool _processingSelection = false;

        public CandLawSchoolPage()
        {
            InitializeComponent();

            BindingContext = new CandLawSchoolMenuViewModel(Navigation);
        }

        private async void OnItemTapped(Object sender, ItemTappedEventArgs e)
        {
            if (_processingSelection)
            {
                return;
            }

            _processingSelection = true;

            try
            {
                var listView = (ListView)sender;
                var selectedItem = listView.SelectedItem;
                var sample = (Sample)selectedItem;

                if (selectedItem != null)
                {
                    SampleCoordinator.SelectedSample = sample;

                    await sample.NavigateToSample(Navigation);
                    listView.SelectedItem = null;
                }
            }
            finally
            {
                _processingSelection = false;
            }
        }

        public static async Task NavigateToCategory(SampleCategory sampleCategory, INavigation navigation)
        {
            await navigation.PushAsync(new SamplesListFromCategoryPage(sampleCategory));
        }

    }
}
