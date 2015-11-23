using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FormsApp2
{
	public partial class FootballPlayerDetailPage : ContentPage
	{
		

		public FootballPlayerDetailPage (object obj)
		{
			
			InitializeComponent ();
		
			//this.BindingContext = obj;
			FootballPlayer myObj = (FootballPlayer)obj;
			this.FirstNameDetail.Text = myObj.PFName;
			this.LastNameDetail.Text = myObj.PLName;
			this.DOBDetail.Text = myObj.PDOB.ToString();
			this.DescriptionDetail.Text = myObj.PDesc;
			this.CountryDetail.Text = myObj.Pcountry;



		}
	
	}
}

