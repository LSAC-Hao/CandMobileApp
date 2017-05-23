using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CandMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CandRouterPage : ContentPage
    {
        public CandRouterPage()
        {
            InitializeComponent();
        }
        public static async Task NavigateToPage(CandPage myPage, INavigation navigation)
        {
            switch (myPage)
            {
                case CandPage.ThinkingJD:
                    await navigation.PushAsync(new CandLawSchoolPage());
                    break;
            }

        }
    }


}
