using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Aprozar.Models
{
        public class Comanda
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public float Cantitate { get; set; }
        [ForeignKey(typeof(Client))]
        public int ID_Client {get; set;}
        [ForeignKey(typeof(Produs))]
        public int ID_Produs { get; set; }
    }
}
