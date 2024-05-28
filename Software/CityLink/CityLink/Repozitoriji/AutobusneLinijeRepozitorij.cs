using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CityLink.Klase;
using DBLayer;

namespace CityLink.Repozitoriji
{
    public class AutobusneLinijeRepozitorij
    {
        public static List<AutobusnaLinija> GetAutobusneLinije()
        {
            List<AutobusnaLinija> linije = new List<AutobusnaLinija>();
            string sql = "SELECT * FROM AutobusneLinije";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                AutobusnaLinija linija = CreateObject(reader);
                linije.Add(linija);
            }
            reader.Close();
            DB.CloseConnection();
            return linije;
        }
        
        public static void DodajAutobusnuLiniju(AutobusnaLinija linija)
        {
            string sql = $"INSERT INTO AutobusneLinije (LinijaId, MjestoPolaska, MjestoDolaska, VrijemePolaska, VrijemeDolaska, BrojStanica) VALUES ({linija.LinijaId},'{linija.MjestoPolaska}','{linija.MjestoDolaska}','{linija.VrijemePolaska}','{linija.VrijemeDolaska}',{linija.BrojStanica})";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }


        private static AutobusnaLinija CreateObject(SqlDataReader reader)
        {
            int linijaId = int.Parse(reader["LinijaId"].ToString());
            string mjestoPolaska = reader["MjestoPolaska"].ToString();
            string mjestoDolaska = reader["MjestoDolaska"].ToString();
            string vrijemePolaska = reader["VrijemePolaska"].ToString();
            string vrijemeDolaska = reader["VrijemeDolaska"].ToString();
            int.TryParse(reader["BrojStanica"].ToString(), out int brojStanica);

            var linija = new AutobusnaLinija(linijaId, mjestoPolaska, mjestoDolaska, vrijemePolaska, vrijemeDolaska, brojStanica)
            {
                LinijaId = linijaId,
                MjestoPolaska = mjestoPolaska,
                MjestoDolaska = mjestoDolaska,
                VrijemePolaska = vrijemePolaska,
                VrijemeDolaska = vrijemeDolaska,
                BrojStanica = brojStanica
            };

            return linija;
        }
    }
}
