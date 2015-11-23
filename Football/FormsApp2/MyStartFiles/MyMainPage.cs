using System;
using Xamarin.Forms;

namespace FormsApp2
{
	public class MyMainPage : ContentPage
	{

		public Entry name {

			get;
			set;

		}
		public Entry pass {

			get;
			set;

		}
		public MyMainPage ()
		{
			App.Current.MainPage = new NavigationPage();
	

			ContentPage LoginPage = new ContentPage ();
			Label MyLabel = new Label{ Text = "Login Page",VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.CenterAndExpand };

			Button myButton = new Button {
				Text = "Login"


			};
			pass.IsPassword = true;

			myButton.Clicked += MyButton_Clicked;



			name = new Entry {
				Placeholder = "UserName", VerticalOptions = LayoutOptions.Center


			};

			pass =	new Entry {
				Placeholder = "Password"


			};





			LoginPage.Content = new StackLayout {

				VerticalOptions = LayoutOptions.CenterAndExpand,

				Children = {
					name,
					pass,
					myButton


				}
			};

			 
			this.Content = LoginPage.Content;


		}
		void MyButton_Clicked (object sender, EventArgs e)
		{
			if (name.Text.ToString () == "neeraj") {

				if (pass.Text.ToString () == "password") {
					Navigation.PushAsync (new MyMasterDetail ());
				}
			} else {

				this.DisplayAlert ("Error", "Incorrect Credentials", "close");
			}
		}
	}
}

