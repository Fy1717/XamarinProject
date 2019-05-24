using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net;
using SQLiteProjem.Models;
using Xamarin.Forms;

namespace SQLiteProjem.Helper
{
    public class SQLiteManager
    {
        SQLiteConnection _sqlconnection;

        public SQLiteManager()
        {
            _sqlconnection = DependencyService.Get<ISQLiteConnection>().GetConnection();
            _sqlconnection.CreateTable<Kayitlar>();
        }

        #region CRUD 

        public int Insert(Kayitlar k)
        {
            return _sqlconnection.Insert(k);
        }

        public int Update(Kayitlar k)
        {
            return _sqlconnection.Update(k);
        }
         
        public int Delete(int Id)
        {
            return _sqlconnection.Delete<Kayitlar>(Id);
        }
        

        public IEnumerable<Kayitlar> GetAll()
        {
            return _sqlconnection.Table<Kayitlar>();
        }
        

        public Kayitlar Get (int Id)
        {
            return _sqlconnection.Table<Kayitlar>().Where(x => x.Id == Id).FirstOrDefault();
        }

        public void Dispose()
        {
            _sqlconnection.Dispose();
        }

        #endregion
    }
}
