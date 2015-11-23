using System;
using SQLite;
namespace FormsApp2
{
	public interface MySqlConn
	{
		SQLiteConnection getConnection();
	}
}

