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

        public static bool PostojiAutobusnaLinijaSaId(int linijaId)
        {
            string connectionString = "Server=31.147.206.65;Database=PI2324_nlazar22_DB; User Id=PI2324_nlazar22_User;Password=p0:]s{jL";
            string sql = "SELECT COUNT(*) FROM AutobusneLinije WHERE LinijaId = @LinijaId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@LinijaId", linijaId);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public static void ObrisiAutobusnuLiniju(int linijaId)
        {
            if (!PostojiAutobusnaLinijaSaId(linijaId))
            {
                MessageBox.Show("Autobusna linija s navedenim ID-om ne postoji.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $"DELETE FROM AutobusneLinije WHERE LinijaId = {linijaId}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

            MessageBox.Show("Autobusna linija je uspješno obrisana.", "Brisanje linije", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
