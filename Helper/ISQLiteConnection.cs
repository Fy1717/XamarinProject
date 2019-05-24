using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteProjem.Helper
{
    public interface ISQLiteConnection
    {

        SQLiteConnection  GetConnection();

    }
}
