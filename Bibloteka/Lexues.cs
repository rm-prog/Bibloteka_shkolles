using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka
{
    public class Lexues
    {
        // The properties names and data types match "LEXUESIT" table columns
        public int ID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Uname { get; set; }
        public string Pword { get; set; }
    }
}
