using System;

using Xamarin.Forms;

namespace FormsApp2
{
	public class App : Application
	{

		public Entry name {

			get;
			set;

		}
		public Entry pass {

			get;
			set;

		}
		public App ()
		{
			
			// The root page of your application
			//MainPage = new ContentPage {
//				Content = new StackLayout {
//					VerticalOptions = LayoutOptions.Center,
//					Children = {
//						new Label {
//							XAlign = TextAlignment.Center,
//							Text = "Welcome to Xamarin Forms!"

						//}
					//}
				//}
			//};



//			ContentPage LoginPage = new ContentPage ();
//
////			var userName = new Entry {
////				Placeholder = "UserName"
////			};
////			var Password = new Entry {
////
////				Placeholder = "Password"
////
////			};
////			var LoginButton = new Button {
////				Text = "Login",
////
////
////
////
////			};
//
//				Label MyLabel = new Label{ Text = "Login Page",VerticalOptions = LayoutOptions.Start,
//				HorizontalOptions = LayoutOptions.CenterAndExpand };
//
//			Button myButton = new Button {
//				Text = "Login"
//
//
//			};
//
//			myButton.Clicked += MyButton_Clicked;
//
//
//
//			name = new Entry {
//				Placeholder = "UserName", VerticalOptions = LayoutOptions.Center
//
//
//			};
//
//			pass =	new Entry {
//				Placeholder = "Password"
//
//
//			};
//
//
//
//
//
//			LoginPage.Content = new StackLayout {
//
//				VerticalOptions = LayoutOptions.CenterAndExpand,
//
//				Children = {
//					name,
//					pass,
//					myButton
//				
//
//				}
//			};
//
//			MainPage = LoginPage;

			MainPage = new NavigationPage(new MyMainPage());	



		}

//		void MyButton_Clicked (object sender, EventArgs e)
//		{
//			if (name.Text.ToString () == "neeraj") {
//				MainPage = new NavigationPage(new MyMasterDetail());
//
//			}
//
//		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

