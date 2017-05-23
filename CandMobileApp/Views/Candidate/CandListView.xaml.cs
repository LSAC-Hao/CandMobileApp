using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CandMobileApp
{
	public partial class CandListView : ContentPage
	{
		private bool _processingSelection = false;

		public CandListView (List<Sample> Category)
		{
			InitializeComponent ();

            BindingContext = Category;
			//Title = sampleCategory.Name;
		}

		private async void OnItemTapped(Object sender, ItemTappedEventArgs e)
		{
			if (_processingSelection) 
			{
				return;
			}

			_processingSelection = true;

			try{
				var listView = (ListView)sender;
				var selectedItem = listView.SelectedItem;
				var sample = (Sample) selectedItem;

				if (selectedItem != null) {
					SampleCoordinator.SelectedSample = sample;

					await sample.NavigateToSample (Navigation);
					listView.SelectedItem = null;
				}
			}finally{
				_processingSelection = false;
			}
		}

		public static async Task NavigateToCategory(SampleCategory sampleCategory, INavigation navigation){
			await navigation.PushAsync( new SamplesListFromCategoryPage( sampleCategory ) );
		}

	}
}