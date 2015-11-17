using System;
using Xamarin.Forms;
using System.Diagnostics;
using System.Collections.Generic;
namespace MySampleApp
{
	public class MyContentPage : Xamarin.Forms.MasterDetailPage
	{
		public MyContentPage ()
		{

			List<ContentPage> pages = new List<ContentPage> (0);
			Color[] colors = { Color.Red, Color.Green, Color.Blue };
			foreach (Color c in colors) {
				pages.Add (new ContentPage { Content = new StackLayout {
						Children = {
							//new Label { Text = c.ToString () },
							new BoxView {
								Color = c,
								VerticalOptions = LayoutOptions.FillAndExpand
							}
						}
					}
				});
			}






			Label header = new Label
			{
				Text = "MasterDetailPage",
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Center
			};


//			NamedColor[] namedColors = 
//			{
//				new NamedColor("ContentPage", Color.Aqua),
//				new NamedColor("Black", Color.Black),
//				new NamedColor("Blue", Color.Blue),
//				new NamedColor("Fuschia", Color.Fuschia),
//			
//			};
			string[] myList = new string[10];
			myList[0] = "Content Demo";
			myList [1] = "Tabbed Demo";
			myList[2] = "Carousel Demo";
			ListView listView = new ListView
			{
				ItemsSource = myList
			};
			this.Master = new ContentPage
			{
				Title = header.Text,
				Content = new StackLayout
				{
					Children = 
					{
						header, 
						listView

					}
					}
			};
			this.Detail = new NavigationPage(new ContentDemo());
			listView.ItemSelected += (sender, args) =>
			{
				
				// Set the BindingContext of the detail page.
				if(listView.SelectedItem.ToString() == "Content Demo")
				{
					this.Detail =  new NavigationPage(new ContentDemo());
				}
				if(listView.SelectedItem.ToString() == "Tabbed Demo")
				{
					this.Detail =  new NavigationPage(new TabbedDemo());
				}
				if(listView.SelectedItem.ToString() == "Carousel Demo")
				{
					this.Detail =  new NavigationPage(new CarouselDemo {
						Children = { pages [0],
							pages [1],
							pages [2] }
					});
//				
					//this.Detail = new NavigationPage(new CarouselDemo());



				}


				this.Detail.BindingContext = args.SelectedItem;

				// Show the detail page.
				this.IsPresented = false;
			
			};
			var x1 = listView.SelectedItem;
		

			listView.SelectedItem = myList[0];

		}
	}
}

