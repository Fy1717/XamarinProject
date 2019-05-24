using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using SQLite.Net;
using Xamarin.Forms.Xaml;
using SQLiteProjem.Helper;
using SQLiteProjem.Models;

namespace SQLiteProjem
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InsertPage : ContentPage
	{
		public InsertPage ()
		{
			InitializeComponent ();
		}

        private void onInsert (object sender , EventArgs e)
        {
            SQLiteManager manager = new SQLiteManager();
            Kayitlar _kayitlar = new Kayitlar();
            _kayitlar.Tür = txtName.Text;
            _kayitlar.Fiyat = txtSurname.Text;


            int isInserted = manager.Insert(_kayitlar);
            if (isInserted>0) {
                DisplayAlert("BAŞARILI ", _kayitlar.Tür + " EKLENDİ", "OK");
            }
            else
            {
                DisplayAlert("BAŞARISIZ ", _kayitlar.Fiyat + " EKLENEMEDİ", "OK");

            }

        }
	}
}