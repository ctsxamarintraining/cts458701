using System;
using System.Diagnostics;
using Xamarin.Forms;
using System.Collections.ObjectModel;


namespace FormsApp2
{
	public class FootballPlayerListCell : ViewCell
	{
		
	

		Label nameLabel;
		public FootballPlayerListCell ()
		{
			
			FootballPlayer footballplayercollection = (FootballPlayer)this.BindingContext;
			var deleteAction = new MenuItem { Text = "", IsDestructive = true }; 
			deleteAction.Clicked += DeleteAction_Clicked;
			this.ContextActions.Add (deleteAction);
			deleteAction.Text = "Delete";
			var Favourites = new MenuItem { IsDestructive = false }; 
			Favourites.Clicked += Favourites_Clicked;
			FootballPlayer foot = new FootballPlayer ();
			if (foot.fav) {
				Favourites.Text = "UnFavourite";
			} else {
				Favourites.Text = "Mark Favourite";
			}
			this.ContextActions.Add (Favourites);
		

		
		

			nameLabel = new Label () {
				FontFamily = "HelveticaNeue-Medium",
				FontSize = 18,
				TextColor = Color.Black,

				WidthRequest = 100

			};
		
			var DOB = new Label () {
				FontFamily = "HelveticaNeue-Medium",
				FontSize = 18,
				TextColor = Color.Black,

				WidthRequest = 100
			};


			var ageLabel = new Label () {
				FontFamily = "HelveticaNeue-Medium",
				FontSize = 18,
				TextColor = Color.Black,
				Text = "age",
				WidthRequest = 100

			};


			var countryimg = new Image ();
			countryimg.SetBinding (Image.SourceProperty, "countryImage");
			countryimg.GetSizeRequest (15, 15);

			var Lname = new Label () {
				FontFamily = "HelveticaNeue-Medium",
				FontSize = 18,
				TextColor = Color.Black,

				WidthRequest = 100

			};

			nameLabel.SetBinding(Label.TextProperty,"PFName");
			DOB.SetBinding (Label.TextProperty, "PlayerAge");
			Lname.SetBinding (Label.TextProperty, "PLName");


			var cellLayout = new StackLayout {
				Spacing = 5,
				Padding = new Thickness (5, 5, 5, 5),

				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { nameLabel, Lname ,



				new StackLayout {
					Orientation = StackOrientation.Vertical,
					Spacing = 5,
						Children = { ageLabel, DOB }
				},

					countryimg
				}
			};



	
		
			this.View = cellLayout;


			
		}

		void Favourites_Clicked (object sender, EventArgs e)
		{

			MenuItem button = (MenuItem)sender;

			var x1 = (MenuItem)sender;
			var x2 = x1.BindingContext;
			FootballPlayer x3 = (FootballPlayer)x2;
			x3.fav =	!x3.fav;
			if (x3.fav) {


				button.Text = "Un Favourite";
			} else {
				button.Text = "Mark Favourite";
			}
			x3.updateplayerFavourite (x3);
		}


		void DeleteAction_Clicked (object sender, EventArgs e)
		{

			var x1 = (MenuItem)sender;
			var x2 = x1.BindingContext;
			FootballPlayer x3 = (FootballPlayer)x2;
			x3.deletePlayer (x3.ID);

			MessagingCenter.Send (this, "delete");


		
	

		}
//	
	}
}


