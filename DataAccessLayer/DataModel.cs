using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConnectionString);
            cmd = con.CreateCommand();
        }

        #region Metotlar

        public Uyeler UyeGiris(string Kadi, string Sifre, string Mail)
        {
            try
            {
                cmd.CommandText = "SELECT COUNT(*) FROM Uyeler WHERE Kadi = @k AND Sifre = @s AND Mail = @m";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@k", Kadi);
                cmd.Parameters.AddWithValue("@s", Sifre);
                cmd.Parameters.AddWithValue("@m", Mail);
                con.Open();
                int sayi = Convert.ToInt32(cmd.ExecuteScalar());
                if (sayi != 0)
                {
                    cmd.CommandText = "SELECT ID, Isim, Soyisim, Mail, Kadi, Sifre FROM Uyeler WHERE Kadi = @k AND Sifre = @s AND Mail = @m";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@k", Kadi);
                    cmd.Parameters.AddWithValue("@s", Sifre);
                    cmd.Parameters.AddWithValue("@m", Mail);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Uyeler u = new Uyeler();
                    while (reader.Read())
                    {
                        u.ID = reader.GetInt32(0);
                        u.Isim = reader.GetString(1);
                        u.Soyisim = reader.GetString(2);
                        u.Mail = reader.GetString(3);
                        u.Kadi = reader.GetString(4);
                        u.Sifre = reader.GetString(5);
                    }
                    return u;
                }
                return null;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion
    }
}
