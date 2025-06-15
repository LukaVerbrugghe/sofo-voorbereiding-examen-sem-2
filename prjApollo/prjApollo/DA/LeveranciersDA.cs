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
    public class LeveranciersDA
    {
        public static List<Leverancier> OphalenLeveranciers()
        {
            List<Leverancier> leveranciers = new List<Leverancier>();

            string sql = "SELECT * FROM tblleveranciers";

            MySqlConnection conn = Database.MaakVerbinding();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;

            MySqlDataReader r = cmd.ExecuteReader();

            while (r.Read()) {
                leveranciers.Add(Create(r));
            }
            r.Close();
            conn.Close();
            return leveranciers;
        }

        public static Leverancier Create(IDataRecord record)
        {
            return new Leverancier()
            {
                leveranciernummer = Convert.ToInt32(record["leveranciernummer"]),
                firmanaam = record["firmanaam"].ToString(),
                adres = record["adres"].ToString(),
                postnr = record["postnr"].ToString(),
                gemeente = record["gemeente"].ToString()
            };
        }

        public static void Edit(Leverancier leverancierUpdate)
        {
            MySqlConnection conn = Database.MaakVerbinding();

            string sql = "UPDATE tblleveranciers SET firmanaam=@firmanaam, adres=@adres, postnr=@postnr, gemeente=@gemeente WHERE leveranciernummer = @leveranciernummer";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.AddWithValue("@firmanaam", leverancierUpdate.firmanaam);
            cmd.Parameters.AddWithValue("@adres", leverancierUpdate.adres);
            cmd.Parameters.AddWithValue("@postnr", leverancierUpdate.postnr);
            cmd.Parameters.AddWithValue("@gemeente", leverancierUpdate.gemeente);
            cmd.Parameters.AddWithValue("@leveranciernummer", leverancierUpdate.leveranciernummer);

            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Succes");
        }
    }
}
