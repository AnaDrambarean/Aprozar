using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace Aprozar.Models
{
    public class CosCumparaturi
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Denumire { get; set; }
        public DateTime Data { get; set; }
    }
}
