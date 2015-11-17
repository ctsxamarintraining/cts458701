using System;
using Xamarin.Forms;
namespace MySampleApp
{
	public class TabbedDemo : Xamarin.Forms.TabbedPage
	{
		public TabbedDemo ()
		{
			this.Title = "Tab Demo";
			this.Children.Add (new ContentPage {
				Title = "Blue ",
				Content = new StackLayout {
					Children = {
						new BoxView { Color = Color.Blue },
						new BoxView { Color = Color.Blue}
					}
				}
			});
		
			this.Children.Add (new ContentPage {
				Title = "Red",
				Content = new StackLayout {
					Children = {
						new BoxView { Color = Color.Red },
						new BoxView { Color = Color.Red}
					}
				}
			});
			this.Children.Add (new ContentPage {
				Title = "Lime",
				Content = new StackLayout {
					Children = {
						new BoxView { Color = Color.Lime },
						new BoxView { Color = Color.Lime}
					}
				}
			});


			this.Children.Add (new ContentPage {
				Title = "Green",
				Content = new StackLayout {
					Children = {
						new BoxView { Color = Color.Green },
						new BoxView { Color = Color.Green}
					}
				}
			});


		}
	}
}

