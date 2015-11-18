using System;
using Xamarin.Forms;
namespace FormsApp2
{



	public class DetailsPage : ContentPage
	{
		public Entry CustomerName {
			get;
			set;
		}
		public DatePicker DOB {
			get;
			set;
		}
		public Switch Gender {
			get;
			set;
		}
		public Entry Desc {
			get;
			set;
		}
		public Picker CountryList {
			get;
			set;
		}
		public DetailsPage ()
		{
			var saveButton = new Button () {
				Text = "Save it!"

			};
			CustomerName = new Entry {
				Placeholder = "Please enter your name"

			};
			DOB = new DatePicker {

				Format = "D"
			};
			Gender = new Switch {
				//HorizontalOptions =LayoutOptions

			};

			Desc = new Entry {
				
				Text = ""
					,
				Placeholder = "Description"


			};

			CountryList = new Picker {


			};
			string[] countryStrings = new string[5];
			countryStrings [0] = "India";
			countryStrings [1] = "USA";
			countryStrings [2] = "JAPAN";
			countryStrings [3] = "UK";
			countryStrings [4] = "Australia";
			foreach (string country in countryStrings)
			{
				CountryList.Items.Add(country);
			}

			var maleFemale = new Label ();
			maleFemale.Text = "M";


			CountryList.Title = "Select Country";
			saveButton.Clicked += SaveButton_Clicked;
			AbsoluteLayout.SetLayoutBounds (maleFemale,
				new Rectangle (400F,
					200F, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
//			this.Content = new StackLayout {
//				//Spacing = 15,
//				//HorizontalOptions = LayoutOptions.CenterAndExpand,
//				Children = {
//					CustomerName
//					,
//					DOB,
//
//					new Label{
//
//						Text ="Gender"
//					},
//					Gender,
//					Desc,
//					maleFemale,
//					CountryList,
//					saveButton
//
//				}
//
//			};


			var gen = new Label
			{
				Text = "Gender"
			};


			RelativeLayout layout = new RelativeLayout {Padding=10};
		

			layout.Children.Add (CustomerName,Constraint.Constant(80),Constraint.Constant(10));


			layout.Children.Add(DOB,Constraint.Constant(80),Constraint.Constant(50));


			layout.Children.Add(gen,Constraint.Constant(80),Constraint.Constant(90));
			layout.Children.Add(Gender,Constraint.Constant(80),Constraint.Constant(130));

			layout.Children.Add(Desc,Constraint.Constant(80),Constraint.Constant(210));
			layout.Children.Add(maleFemale,Constraint.Constant(160),Constraint.Constant(90));
			layout.Children.Add(CountryList,Constraint.Constant(80),Constraint.Constant(250));
			layout.Children.Add(saveButton,Constraint.Constant(80),Constraint.Constant(290));
			this.Content = layout;
			Gender.Toggled += (sender, e) => {
				if(Gender.IsToggled)
				{
					maleFemale.Text = "F";
				}
				else
				{
					maleFemale.Text = "M";
				}
			};
		}

		void SaveButton_Clicked (object sender, EventArgs e)
		{
			
		}
	}
}

