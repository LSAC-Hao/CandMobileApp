using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CandMobileApp
{
	public partial class ProductsCarouselPage : CarouselPage
	{
		public ProductsCarouselPage()
		{
			InitializeComponent ();
			        
			var productsList = SampleData.Products;

			for (var i = 0; i < productsList.Count; i++) {
				var item = new ProductItemViewPage();
				item.BindingContext = productsList [i];
				Children.Add ( item );
			}
		}

		protected override void OnCurrentPageChanged()
		{
			base.OnCurrentPageChanged();
			this.Title = CurrentPage.Title;
		}
	}
}