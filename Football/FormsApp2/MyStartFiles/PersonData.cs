using System;
using Xamarin.Forms;
using SQLite;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FormsApp2
{





	public class PersonData
	{
		public string Pname {
			get;
			set;
		}

		public PersonData (string name)
		{
			using (var conn = getConnection ())
			{
				Pname = name;

				conn.CreateTable<PersonData>();

			}

		}


		public SQLiteConnection getConnection()
				{

			return new SQLiteConnection("/Users/krishnarohit/projects/FormsApp2/iOS/MySqliteDB.sqlite");
				}


		public void SaveDate(PersonData obj)
		{

			using (var conn = getConnection ()) {

				conn.Insert(obj);
				var myList =	conn.GetTableInfo ("PersonData");

			
			}




		}


	}
}

