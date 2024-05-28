using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLink.Klase
{
    public class AutobusnaLinija
    {
        public int LinijaId { get; set;}
        public string MjestoPolaska { get; set; }
        public string MjestoDolaska { get; set; }
        public string VrijemePolaska { get; set; }
        public string VrijemeDolaska { get; set; }
        public int BrojStanica { get; set; }
    }
}