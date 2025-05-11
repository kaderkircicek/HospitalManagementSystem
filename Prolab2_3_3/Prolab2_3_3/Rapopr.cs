using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Prolab2_3_3
{
    public class Rapopr
    {

        public void RaporEkle(int doktorId, int hastaId, int YoneticiId, string RaporIcerigi, string RaporTarihi, string Url)
        {
            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Rapor (HastaID,DoktorID ,YoneticiID ,RaporTarihi,RaporIcerigi ,DosyaURL) VALUES (@HastaID, @DoktorID, @YoneticiID, @RaporTarihi,@RaporIcerigi,@DosyaUrl)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@HastaID", hastaId);
                command.Parameters.AddWithValue("@DoktorID", doktorId);
                command.Parameters.AddWithValue("@YoneticiID", YoneticiId);
                command.Parameters.AddWithValue("@RaporTarihi", Convert.ToDateTime(RaporTarihi).Date.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@RaporIcerigi", RaporIcerigi);
                command.Parameters.AddWithValue("@DosyaUrl", Url);



                connection.Open();
                command.ExecuteNonQuery();
            }
        }



        public int RaporSil(int RaporId)
        {
            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";
            // İlgili doktorun randevularını sil
            string Query = "DELETE FROM Rapor WHERE RaporID = @RaporID";
            int row = 0;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();




                using (SqlCommand Command = new SqlCommand(Query, connection))
                {
                    Command.Parameters.AddWithValue("@RaporID", RaporId);
                    row = Command.ExecuteNonQuery();

                }

            }
            return row;
        }


    }
}