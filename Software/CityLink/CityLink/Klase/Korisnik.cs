using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLink.Klase
{
    public class Korisnik
    {
        private string username = "korisnik";
        private string password = "test2";

        public string Username
        {
            get { return username; }
            private set { username = value; }
        }

        public string Password
        {
            get { return password; }
            private set { password = value; }
        }
    }
}
