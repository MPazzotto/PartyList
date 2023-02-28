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
			BindingContext = new ProductViewModel();

			SetValue(NavigationPage.HasNavigationBarProperty, false);
		}

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductPage());
        }
    }
}