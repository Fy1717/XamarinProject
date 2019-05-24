using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite.Net;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLiteProjem.Helper;
using SQLiteProjem.Models;

namespace SQLiteProjem
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListPage : ContentPage
	{

        SQLiteManager manager;

        public ListPage ()
		{
			InitializeComponent ();

            List<Kayitlar> kayitlarList = new List<Kayitlar>();
            manager = new SQLiteManager();
            kayitlarList = manager.GetAll().ToList();

            lstKayitlar.BindingContext = kayitlarList;
		}

        private void onMenuInsert(object sender , EventArgs e)
        {
            Navigation.PushAsync(new InsertPage());
        }

        private void onMenuRefresh(object sender, EventArgs e)
        {
            List<Kayitlar> kayitlarList = new List<Kayitlar>();
            kayitlarList = manager.GetAll().ToList();
            lstKayitlar.BindingContext = kayitlarList;
        }

        private void onMenuDelete(object sender , EventArgs e)
        {
            var selectedMenuItem = (MenuItem)sender;
            manager.Delete(Convert.ToInt32(selectedMenuItem.CommandParameter.ToString()));
        }
	}
}