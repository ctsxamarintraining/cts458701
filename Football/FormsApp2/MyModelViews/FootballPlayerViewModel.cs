using System;
using Xamarin.Forms;
using System.Windows.Input;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace FormsApp2
{
	public class FootballPlayerViewModel  : MyBaseViewModel
	{
		FootballPlayer player;

		private ObservableCollection<FootballPlayer> _footballplayercollection;

		public ObservableCollection<FootballPlayer> Footballplayercollection
		{
			get{ 
				return  _footballplayercollection;
			}
			set{
				_footballplayercollection = value;
				RaisePropertyChanged ("Footballplayercollection");
			
			}

		}


	
		public FootballPlayerViewModel ()
		{


			SaveCommand = new Command (OnSaveCommand);
			//CreatePlayer = new Command (OnCreatePlayerCommand);
			DeleteData = new Command (OnDeletePlayerCommand);
			//PickImage = new Command (onPick);

			player = new FootballPlayer ();

		
			Footballplayercollection =new ObservableCollection<FootballPlayer>(player.GetItems());
		


		}
		public ICommand SaveCommand { get; private set;}
		//public ICommand CreatePlayer { get; 	private set;}
		public ICommand DeleteData { get; 	 set;}
//		public ICommand PickImage { get; 	 set;}

		private string _test;

		public string test
		{
			get{  return _test;}
			set{   

				_test = value;
				RaisePropertyChanged ("test");
			}
		}

//		public string _countryImage
	





		void OnSaveCommand()
		{
			string c;
		
			if (Country == 0) {

				c	= "India";
			} else if (Country == 1) {

				c = "USA";
			}
			else if (Country == 2) {
				c = "Japan";

			}
			else if (Country == 3) {
				c = "UK";

			}
			else if (Country == 4) {

				c = "Australia";
			}
			else {

				c = "Unavailable";
			}

			player= new FootballPlayer (_FirstName,_LastName,_DOB,_DESC,c);

			player.saveFootBallPlayerData (player);
		}

		void OnDeletePlayerCommand()
		{



		}
//		void onPick()
//		{
//
//
//		}
//		void OnCreatePlayerCommand()
//		{
//			
//			App.Current.MainPage.Navigation.PushAsync (new CreateFootballPlayer ());
//		}

		private DateTime _DOB;

		public DateTime DOB
		{

			get{  return _DOB;}
			set{   
				
				_DOB = value;
				RaisePropertyChanged ("DOB");
			}
		}

		private string _DESC;

		public string DESC
		{
			get{  return _DESC;}
			set{   

				_DESC = value;
				RaisePropertyChanged ("DESC");
			}
		}
		private string _DetailFirstName;

		public string DetailFirstName
		{
			get{  return _DetailFirstName;}
			set{   

				//if (SelectedItem != null) {
					FootballPlayer i = (FootballPlayer)SelectedItem;

					_DetailFirstName = i.PFName;
		
				RaisePropertyChanged ("DetailFirstName");
				//doSomething ();

			}
		}
	

	

		private string _FirstName;

		public string FirstName
		{
			get{  return _FirstName;}
			set{   

				_FirstName = value;
				RaisePropertyChanged ("FirstName");

			}
		}

		public void fillIntheDetails(int index)
		{


		}

		private string _LastName;

		public string LastName
		{
			get{  return _LastName;}
			set{   

				_LastName = value;
				RaisePropertyChanged ("LastName");
			}
		}



		private int _Country;

		public int Country
		{
			get{  return _Country;}
			set{   

				_Country = value;
				RaisePropertyChanged ("Country");
			}
		}


		private object _SelectedItem;
	//	private object index;
		public object SelectedItem
		{
			get{  return _SelectedItem;}
			set{   



				_SelectedItem = value;
				RaisePropertyChanged ("SelectedItem");
				//index = _SelectedItem;


			}
		}



	}
}
		

	

//
//
//
//
//	}
//}
//
