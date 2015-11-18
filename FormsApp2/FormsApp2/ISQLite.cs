using System;
using SQLite;

namespace FormsApp2
{
	public interface ISQLite {
		SQLiteConnection GetConnection();
	}
}

