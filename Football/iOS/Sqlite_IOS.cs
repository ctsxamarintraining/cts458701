using System;
using SQLite;
using System.IO;
using Xamarin.Forms;
using FormsApp2.iOS;

[assembly: Xamarin.Forms.Dependency (typeof(Sqlite_IOS))]
namespace FormsApp2.iOS
{
	public class Sqlite_IOS : MySqlConn
	{
		#region MySqlConn implementation

		public SQLiteConnection getConnection ()
		{
			var sqliteFilename = "FootballPlayerData2.db3";
			string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			Console.WriteLine (documentsPath);
			var mypath = Path.Combine (documentsPath,sqliteFilename);
			var conn = new SQLite.SQLiteConnection(mypath);
			return conn;
		}

		#endregion

		public Sqlite_IOS () 
		{
			
		}



	}
}

