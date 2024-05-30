using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static bool PostojiAutobusnaLinijaSaId(int linijaId)
        {
            List<AutobusnaLinija> linije = GetAutobusneLinije();
            return linije.Any(linija => linija.LinijaId == linijaId);
        }

        public static void ObrisiAutobusnuLiniju(int linijaId)
        {
                string sql = $"DELETE FROM AutobusneLinije WHERE LinijaId = {linijaId}";
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();

                MessageBox.Show("Autobusna linija je uspješno obrisana.", "Brisanje linije", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void AzurirajAutobusnuLiniju(AutobusnaLinija linija)
        {

            string sql = $"UPDATE AutobusneLinije SET MjestoPolaska = '{linija.MjestoPolaska}', MjestoDolaska = '{linija.MjestoDolaska}', VrijemePolaska = '{linija.VrijemePolaska}', VrijemeDolaska = '{linija.VrijemeDolaska}', BrojStanica = {linija.BrojStanica} WHERE LinijaId = {linija.LinijaId}";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

            MessageBox.Show("Autobusna linija je uspješno ažurirana.", "Ažuriranje linije", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static List<AutobusnaLinija> PretraziAutobusneLinije(string pretrazivanje)
        {
            List<AutobusnaLinija> linije = new List<AutobusnaLinija>();
            pretrazivanje = pretrazivanje.ToLower();
            string sql = $"SELECT * FROM AutobusneLinije WHERE MjestoPolaska LIKE '%{pretrazivanje}%' OR MjestoDolaska LIKE '%{pretrazivanje}%'";

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

        public static bool ProvjeriFormatVremena(string vrijeme)
        {
            if (!Regex.IsMatch(vrijeme, @"^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$"))
            {
                return false; 
            }
            return true; 
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
