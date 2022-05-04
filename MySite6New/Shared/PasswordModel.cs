using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite6New.Shared
{
    public class PasswordModel
    {
        public int Lunghezza { get; set; }
        public int Quantita { get; set; }
        public bool UsaMinuscole { get; set; }
        public bool UsaMaiuscole { get; set; }
        public bool UsaNumeri { get; set; }
        public bool UsaSpeciali { get; set; }
    }
}
