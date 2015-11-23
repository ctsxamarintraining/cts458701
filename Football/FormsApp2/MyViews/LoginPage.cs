using System;
using Xamarin.Forms;
namespace FormsApp2
{


	public class LoginPage : ContentPage
	{

		public Entry name {

			get;
			set;

		}
		public Entry pass {

			get;
			set;

		}


		public LoginPage ()
		{

			Label MyLabel = new Label{ Text = "Login Page",VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.CenterAndExpand };

			Button myButton = new Button {
				Text = "Login"


			};

			myButton.Clicked += MyButton_Clicked;



			name = new Entry {
				Placeholder = "UserName", VerticalOptions = LayoutOptions.Center


			};

			pass =	new Entry {
				Placeholder = "Password",
				IsPassword = true


			};





			Content = new StackLayout {

				VerticalOptions = LayoutOptions.CenterAndExpand,

				Children = {
					name,
					pass,
					myButton


				}
			};



		}

		void MyButton_Clicked (object sender, EventArgs e)
		{

			Navigation.PushModalAsync(new NavigationPage(new MyMasterDetail()));

		}
	}
}

