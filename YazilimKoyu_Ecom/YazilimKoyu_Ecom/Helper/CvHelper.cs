using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimKoyu_Ecom.Entity;


namespace YazilimKoyu_Ecom.Helper
{
    internal class CvHelper
    {
        public static GetirBasvuru2 Getir(int id)
        {
            GetirBasvuru2 getirBasvuru2 = new GetirBasvuru2();

            string query = "SELECT * FROM GetirBasvuru2 WHERE Id=@Id AND Okundu=0";

            try
            {
                using (var conn = new SqlConnection("server=DESKTOP-TV26ANG; Initial Catalog=dbIsTakip; User=sa; Password=388094ali"))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("Id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                getirBasvuru2.Id = Convert.ToInt32(reader["Id"]);
                                getirBasvuru2.your_name = Convert.ToString(reader["your-name"]);
                                getirBasvuru2.your_email = Convert.ToString(reader["your-email"]);
                                getirBasvuru2.telefon_no = Convert.ToDouble(reader["telefon-no"]);
                                getirBasvuru2.ulke = Convert.ToString(reader["ulke"]);
                                getirBasvuru2.ikamet_sehri = Convert.ToString(reader["ikamet-sehri"]);
                                getirBasvuru2.okul = Convert.ToString(reader["okul"]);
                                getirBasvuru2.bolum = Convert.ToString(reader["bolum"]);
                                getirBasvuru2.lisans_onlisans = Convert.ToString(reader["lisans-onlisans"]);
                                getirBasvuru2.mezun_sinif = Convert.ToString(reader["mezun-sinif"]);
                                getirBasvuru2.ngilizcesev = Convert.ToString(reader["ngilizcesev"]);
                                getirBasvuru2.yazilimdilleri = Convert.ToString(reader["yazilimdilleri"]);
                                getirBasvuru2.linkedinurl = Convert.ToString(reader["linkedinurl"]);
                                getirBasvuru2.basvuru_detaylari = Convert.ToString(reader["basvuru-detaylari"]);
                                getirBasvuru2.F15 = Convert.ToString(reader["F15"]);
                                getirBasvuru2.OlumluMu = Convert.ToBoolean(reader["OlumluMu"]);
                                getirBasvuru2.Note = Convert.ToInt32(reader["Note"]);

                            }
                        }


                    }
                }
            }
            catch (Exception e)
            {

                throw;
            }
            return getirBasvuru2;
        }

        public static int GetTotalCount()
        {
            string query = "SELECT COUNT(*) FROM GetirBasvuru2 WHERE Okundu=0";
            int count = 0;

            try
            {
                using (var conn = new SqlConnection("server=DESKTOP-TV26ANG; Initial Catalog=dbIsTakip; User=sa; Password=388094ali"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandText = query;

                        count = Convert.ToInt32(cmd.ExecuteScalar());

                    }
                }
            }
            catch (Exception e)
            {

                throw;
            }

            return count;
        }

        public static int Isaretle(int id , int islem)
        {
            string query = "UPDATE GetirBasvuru2 SET Okundu=@Okundu , OlumluMu=@OlumluMu WHERE Id=@Id";
            int count = 0;

            try
            {
                using (var conn = new SqlConnection("server=DESKTOP-TV26ANG; Initial Catalog=dbIsTakip; User=sa; Password=388094ali"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Okundu", 1);
                        cmd.Parameters.AddWithValue("@OlumluMu", islem);
                        count = cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception e)
            {

                throw;
            }

            return count;
        }


    }
}
