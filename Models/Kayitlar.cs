using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteProjem.Models
{
    public class Kayitlar
    {
        [PrimaryKey , AutoIncrement]
        public int Id { get; set; }
        public string Tür { get; set; }
        public string Fiyat  { get; set; }
        public string Notu { get; set; }
    }
}
