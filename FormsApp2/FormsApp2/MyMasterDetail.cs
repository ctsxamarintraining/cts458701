using System;
using Xamarin.Forms;
namespace FormsApp2
{
	public class MyMasterDetail : MasterDetailPage
	{
		public MyMasterDetail ()
		{

			Label header = new Label
			{
				Text = "MasterDetailPage",
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Center
			};
			string[] myList = new string[10];
			myList[0] = "Content Demo";
			//myList [1] = "Tabbed Demo";
			//myList[2] = "Carousel Demo";
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
			this.Detail = new NavigationPage(new HomePage());


		}
	}
}

