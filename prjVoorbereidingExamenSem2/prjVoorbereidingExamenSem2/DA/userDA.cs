﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using prjVoorbereidingExamenSem2.Helper;
using prjVoorbereidingExamenSem2.Model;

namespace prjVoorbereidingExamenSem2.DA
{
    public class userDA
    {
        public static bool LoginValidate(User user)
        {
            bool blnLogin = false;

            MySqlConnection conn = Database.MaakVerbinding();

            string sql = "SELECT COUNT(1) FROM user WHERE Username = @Username AND Password = @Password";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Password", user.Password);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 1)
            {
                blnLogin = true;
            }
            conn.Close();
            return blnLogin;
        }
    public static void Register(User user)
        {
            MySqlConnection conn = Database.MaakVerbinding();

            string sql = "SELECT COUNT(1) FROM user WHERE Username = @Username";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@Username", user.Username);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 1)
            {
                MessageBox.Show("Deze gebruikersnaam bestaat al.");
            }
            else
            {
                string sql1 = "INSERT INTO `user`(`Username`, `Password`) VALUES (@Username,@Password)";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                cmd1.CommandType = System.Data.CommandType.Text;
                cmd1.Parameters.AddWithValue("@Username", user.Username);
                cmd1.Parameters.AddWithValue("@Password", user.Password);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Suucces");
            }
            conn.Close();
        }
    }
}
