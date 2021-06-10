using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka
{
    public class Liber
    {
        // The properties name and type match 'LIBRAT' table columns
        public int ID { get; set; }
        public string Titulli { get; set; }
        public string Autori { get; set; }
        public int Faqe { get; set; }
        public string Zhaneri { get; set; }
        public DateTime Data_dorezimit { get; set; }
        public int Lexuesi_ID { get; set; }
    }
}
