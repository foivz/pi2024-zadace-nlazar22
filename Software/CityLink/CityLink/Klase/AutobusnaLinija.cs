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

        public AutobusnaLinija(int id, string mPolaska, string mDolaska, string vPolaska, string vDolaska, int brStanica)
        {
            LinijaId = id;
            MjestoPolaska = mPolaska;
            MjestoDolaska = mDolaska;
            VrijemePolaska = vPolaska;
            VrijemeDolaska = vDolaska;
            BrojStanica = brStanica;
        }
    }
}