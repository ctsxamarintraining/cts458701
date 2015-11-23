using System;
using System.ComponentModel;
using SQLite;
using System.Linq;
using Xamarin.Forms;
using System.Collections.Generic;
//using System.Windows.Input;
//using System.Collections.ObjectModel;


namespace FormsApp2
{
	
	public class FootballPlayer : MyBaseViewModel
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string PFName { get; set; }
		public string PLName { get; set; }
		public string Pcountry { get; set; }
		public DateTime PDOB { get; set; }
		public string PDesc { get; set; }
		public int PlayerAge { get; set; }
		public bool fav{ get; set ; }


	

		public string countryImage
		{
			get{  


				return  String.Concat (Pcountry, ".png") ;}

		}

//		public void sort()
//		{
//			database.Table<FootballPlayer>().OrderByDescending((x =>
//
//		}
//
		SQLiteConnection database;

		public FootballPlayer()
		{
			database = DependencyService.Get<MySqlConn> ().getConnection ();
			var count = database.ExecuteScalar<int> ("SELECT Count(*) FROM FootballPlayer");
			if (count == 0) {
				database.CreateTable<FootballPlayer> ();
			}

		}
//		"India";
//		countryStrings [1] = "USA";
//		countryStrings [2] = "JAPAN";
//		countryStrings [3] = "UK";
//		countryStrings [4] = "Australia";
		public FootballPlayer(string fname,string lname,DateTime dob,string descr,string country)
		{
			PFName = fname;
			PLName = lname;
			PDOB = dob;
			PDesc = descr;
			Pcountry = country;

			int year1 = PDOB.Year;

			int year2 = DateTime.Now.Year;
			PlayerAge = year2 - year1;
//			if (country == "India") {
//
//				CountryImage.Source = ImageSource.FromFile ("India.png");
//
//			} else if (country == "USA") {
//				CountryImage.Source = ImageSource.FromFile ("usa.png");
//			} else if (country == "UK") {
//				CountryImage.Source = ImageSource.FromFile ("UK.png");
//			} else if (country == "Australia") {
//				CountryImage.Source = ImageSource.FromFile ("aus.png");
//			} else if (country == "JAPAN") {
//				CountryImage.Source = ImageSource.FromFile ("japan.png");
//			} else {
//
//			}
			database = DependencyService.Get<MySqlConn> ().getConnection ();

		



		}


		public void updateplayerFavourite(FootballPlayer obj)
		{
			database.Update (obj);

		}

		public void saveFootBallPlayerData(FootballPlayer obj)
		{
 
			database.Insert (obj);


		}
		public void deletePlayer(int myId)
		{

			database.Delete<FootballPlayer> (myId);

		}

		public IEnumerable<FootballPlayer> GetItems () {



			return (from i in database.Table<FootballPlayer> ()
			        select i);

		}



		}


		


	



}

