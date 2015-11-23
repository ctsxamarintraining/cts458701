using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;
using SQLite;


namespace FormsApp2
{
	public class FootballPlayerListPage : ContentPage
	{

	

		ListView MyFootballList;
		public bool yesNo = true;


		public FootballPlayerListPage()
		{

			this.BindingContext = new FootballPlayerViewModel ();


			Title = "Football Legends";
			var create = new ToolbarItem ();
			create.Name = "create";

			this.ToolbarItems.Add (create);
			create.Clicked += Create_Clicked;
		//	create.SetBinding (ToolbarItem.CommandProperty, "CreatePlayer");
			MyFootballList = new ListView ();
			MyFootballList.IsPullToRefreshEnabled = true;
			MyFootballList.Refreshing += MyFootballList_Refreshing;
			MyFootballList.SetBinding (ListView.ItemsSourceProperty, "Footballplayercollection");
			var cell = new DataTemplate (typeof(FootballPlayerListCell));
			MyFootballList.ItemTemplate = cell;
			MyFootballList.RowHeight = 70;

			MessagingCenter.Subscribe<FootballPlayerListCell>(this,"delete",(sender) => {
				this.BindingContext = new FootballPlayerViewModel();
				FootballPlayer dat= new FootballPlayer ();
				MyFootballList.ItemsSource = dat.GetItems ();
			


			},null);






			MyFootballList.ItemSelected += (object sender, SelectedItemChangedEventArgs e) => 
			{



				Navigation.PushAsync(new FootballPlayerDetailPage(e.SelectedItem));
			
			};

			this.Content = MyFootballList;


		}

		void Create_Clicked (object sender, EventArgs e)
		{
			Navigation.PushAsync (new CreateFootballPlayer ());
		}

		void MyFootballList_Refreshing (object sender, EventArgs e)
		{
			FootballPlayer dat= new FootballPlayer ();
			MyFootballList.ItemsSource =  dat.GetItems ();
			MyFootballList.EndRefresh();
		}

	

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			FootballPlayer dat= new FootballPlayer ();
			MyFootballList.ItemsSource = dat.GetItems ();

		}
	
	}

}


