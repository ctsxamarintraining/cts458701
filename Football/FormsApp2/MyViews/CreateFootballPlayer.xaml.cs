using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FormsApp2
{
	public partial class CreateFootballPlayer : ContentPage
	{
		public CreateFootballPlayer ()
		{
			InitializeComponent ();
		

			this.BindingContext = new FootballPlayerViewModel ();
			NavigationPage.SetHasBackButton (this, true);
			this.FirstName.SetBinding (Entry.TextProperty, "FirstName");
			this.LastName.SetBinding (Entry.TextProperty, "LastName");
			this.DOB.SetBinding (DatePicker.DateProperty, "DOB");
			this.Desc.SetBinding (Editor.TextProperty, "DESC");
			this.Country.SetBinding (Picker.SelectedIndexProperty,"Country");
			this.Save.SetBinding (Button.CommandProperty, "SaveCommand");
			//this.imagePicker.SetBinding (Button.CommandProperty, "PickImage");
			this.imagePicker.Clicked += ImagePicker_Clicked;	
			string[] countryStrings = new string[5];
					countryStrings [0] = "India";
					countryStrings [1] = "USA";
					countryStrings [2] = "JAPAN";
					countryStrings [3] = "UK";
					countryStrings [4] = "Australia";
					foreach (string country in countryStrings)
					{
				this.Country.Items.Add(country);
					}
		}

		void ImagePicker_Clicked (object sender, EventArgs e)
		{
			Navigation.PushModalAsync (new PickPhotoRenderer ());
		}



	}
}

