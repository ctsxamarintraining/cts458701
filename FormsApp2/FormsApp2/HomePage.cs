using System;
using Xamarin.Forms;
namespace FormsApp2
{
	public class HomePage : ContentPage
	{
		public HomePage ()
		{

			var Details = new Button {

				Text = "Details" ,

					

			};


			this.BackgroundImage = "Details.jpg";

			Details.HorizontalOptions = LayoutOptions.Center;
			Details.VerticalOptions = LayoutOptions.Center;
			this.Content = new StackLayout(){
				Spacing = 10,
				Children = {
					Details

				}
			};


			Details.Clicked += Details_Clicked;

		}

		void Details_Clicked (object sender, EventArgs e)
		{
			Navigation.PushAsync(new DetailsPage());


		}
	}
}

