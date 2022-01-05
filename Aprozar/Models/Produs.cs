using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Aprozar.Models
{
    public class Produs
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Denumire { get; set; }
        public string TaraOrigine { get; set; }
        public double Pret { get; set; }
        [ForeignKey(typeof(Categorie))]
        public int ID_Categorie { get; set; }

    }
}
