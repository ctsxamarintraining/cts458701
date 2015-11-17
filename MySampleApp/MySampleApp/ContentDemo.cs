using System;
using Xamarin.Forms;
namespace MySampleApp
{
	public class ContentDemo : Xamarin.Forms.ContentPage
	{
		public ContentDemo ()
		{
			Content = new Label {
				Text = "Hello, Forms!",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			
			};
		}
}
}

