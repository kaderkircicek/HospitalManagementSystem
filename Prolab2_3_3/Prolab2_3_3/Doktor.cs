using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Prolab2_3_3
{
    public class Doktor
    {

        public bool DoktorGirisKontrol(int DoktorID, string Sifre)
        {
            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Doktor WHERE DoktorID = @DoktorID AND Sifre = @Sifre";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DoktorID", DoktorID);
                command.Parameters.AddWithValue("@Sifre", Sifre);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }




        public void DoktorKendiBilgisiniGuncelleme(int doktorId, string Ad, string Soyad, string UzmanlikAlani, string hastane, string sifre)
        {
            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";

            string query = "UPDATE Doktor SET Ad=@Ad, Soyad=@Soyad, UzmanlikAlani=@UzmanlikAlani, CalistigiHastane=@CalistigiHastane, Sifre=@Sifre WHERE DoktorId=@DoktorId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Ad", Ad);
                    command.Parameters.AddWithValue("@Soyad", Soyad);
                    command.Parameters.AddWithValue("@UzmanlikAlani", UzmanlikAlani);
                    command.Parameters.AddWithValue("@CalistigiHastane", hastane);
                    command.Parameters.AddWithValue("@Sifre", sifre);
                    command.Parameters.AddWithValue("@DoktorID", doktorId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }






        public DataTable DoktorRandevulariniGoster(int doktorId)
        {
            string connStr = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = @"
                    SELECT 
                        h.Ad AS HastaAd, h.Soyad AS HastaSoyad, 
                        d.Ad AS DoktorAd, d.Soyad AS DoktorSoyad, d.UzmanlikAlani, d.CalistigiHastane, 
                        r.RandevuTarihi, r.RandevuSaati
                    FROM 
                        Randevular r
                    INNER JOIN 
                        Hasta h ON r.HastaID = h.HastaID
                    INNER JOIN 
                        Doktor d ON r.DoktorID = d.DoktorID
                    WHERE 
                        r.DoktorID = @DoktorID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DoktorID", doktorId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }

         }






        }

    }