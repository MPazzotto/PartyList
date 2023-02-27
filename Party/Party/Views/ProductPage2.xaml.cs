using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Party.ViewModels;


namespace Party.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductPage2 : ContentPage
	{
		public ProductPage2()
		{
			InitializeComponent();
			//BindingContext = new ProductViewModel();

			SetValue(NavigationPage.HasNavigationBarProperty, false);
		}

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductPage());
        }

        private async void ImageButton_Clicked_1Async(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductPageGabiParty());
        }

        private async void ImageButton_Clicked_2Async(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductPageEndYearParty());
        }

        private async void ImageButton_Clicked_3Async(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductPageNoReasonParty());
        }

        private async void ImageButton_Clicked_4Async(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductPageAddParty());
        }
    }
}