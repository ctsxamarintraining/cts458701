using System;
using Xamarin.Forms;
using SQLite;

namespace FormsApp2.iOS
{
	public interface MySqlConnection 
	{

		SQLiteConnection GetConnection();

	}
}

