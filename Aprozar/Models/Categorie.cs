using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace Aprozar.Models
{
    public class Categorie
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Denumire { get; set; }

    }
}
