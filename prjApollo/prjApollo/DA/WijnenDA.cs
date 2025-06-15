using MySql.Data.MySqlClient;
using prjApollo.Helper;
using prjApollo.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjApollo.DA
{
    public class WijnenDA
    {
        public static List<Wijn> OphalenWijenen(int leveranciersnummer)
        {
            List<Wijn> wijnen = new List<Wijn>();

            string sql = "SELECT * FROM tblwijnen WHERE Leveranciersnummer = @Leveranciersnummer";

            MySqlConnection conn = Database.MaakVerbinding();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.AddWithValue("@Leveranciersnummer", leveranciersnummer.ToString());

            MySqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                wijnen.Add(Create(r));
            }
            r.Close();
            conn.Close();
            return wijnen;
        }

        public static Wijn Create(IDataRecord record) {
            return new Wijn()
            {
                Code = record["Code"].ToString(),
                Jaar = record["Jaar"].ToString(),
                Omschrijving = record["Omschrijving"].ToString(),
                Inhoud = record["Inhoud"].ToString(),
                PrijsPerFles = Convert.ToDouble(record["PrijsPerFles"]),
                HoeveelheidPerVerpakking = Convert.ToInt32(record[
                    "HoeveelheidPerVerpakking"]),
                Voorraad = Convert.ToInt32(record["Voorraad"])
            };
        }

        public static void Edit(Wijn wijnUpdate)
        {
            MySqlConnection conn = Database.MaakVerbinding();

            string sql = "UPDATE tblwijnen SET Code=@Code, Jaar=@Jaar, Omschrijving=@Omschrijving, Inhoud=@Inhoud, PrijsPerFles=@ppf, HoeveelheidPerVerpakking=@Hoeveelheid, Voorraad=@Voorraad";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@Code",wijnUpdate.Code);
            cmd.Parameters.AddWithValue("@Jaar",wijnUpdate.Jaar);
            cmd.Parameters.AddWithValue("@Omschrijving", wijnUpdate.Omschrijving);
            cmd.Parameters.AddWithValue("@Inhoud",wijnUpdate.Inhoud);
            cmd.Parameters.AddWithValue("@ppf",wijnUpdate.PrijsPerFles);
            cmd.Parameters.AddWithValue("@Hoeveelheid", wijnUpdate.HoeveelheidPerVerpakking);
            cmd.Parameters.AddWithValue("@Voorraad",wijnUpdate.Voorraad);

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Succes");
        }
    }
}
