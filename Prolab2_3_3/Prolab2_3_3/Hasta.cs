using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Prolab2_3_3
{
    public class Hasta
    {

        public bool HastaGirisKontrol(int hastaId, string sifre)
        {
            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Hasta WHERE HastaId = @HastaId AND HastaSifre = @HastaSifre";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@HastaId", hastaId);
                command.Parameters.AddWithValue("@HastaSifre", sifre);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }




        public bool HastaVarMi(int HastaID)
        {

            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";


            string query = "SELECT COUNT(*) FROM Hasta WHERE HastaID = @HastaID";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Sorgu hazırla ve parametreleri ekle
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HastaID", HastaID);

                    // Bağlantıyı aç
                    connection.Open();

                    // Sorguyu çalıştır ve sonucu al
                    int count = (int)command.ExecuteScalar();


                    return count > 0;
                }
            }
        }






        public bool DoktorVarMi(int DoktorID)
        {

            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";

            string query = "SELECT COUNT(*) FROM Doktor WHERE DoktorID = @DoktorID";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DoktorID", DoktorID);


                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    // Doktor var mı yok mu sonucunu döndür
                    return count > 0;
                }
            }
        }



        public bool HastaninAyniDoktorIcinRandevusuVarMi(int HastaID, int DoktorID)
        {

            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";

            // SQL sorgusu
            string query = "SELECT COUNT(*) FROM Randevular WHERE HastaID = @HastaID AND DoktorID = @DoktorID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HastaID", HastaID);
                    command.Parameters.AddWithValue("@DoktorID", DoktorID);

                    // Bağlantıyı aç
                    connection.Open();


                    int count = (int)command.ExecuteScalar();


                    return count > 0;
                }
            }
        }


        public bool HastaIcinRandevuVarMi(int HastaID, DateTime RandevuTarihi, TimeSpan RandevuSaati)
        {
            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";


            string query = "SELECT COUNT(*) FROM Randevular WHERE HastaID = @HastaID AND RandevuTarihi = @RandevuTarihi AND RandevuSaati = @RandevuSaati";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HastaID", HastaID);
                    command.Parameters.AddWithValue("@RandevuTarihi", RandevuTarihi);
                    command.Parameters.AddWithValue("@RandevuSaati", RandevuSaati);

                    connection.Open();

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }





        public bool DoktorIcinRandevuVarMi(int DoktorID, DateTime RandevuTarihi, TimeSpan RandevuSaati)
        {

            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";


            string query = "SELECT COUNT(*) FROM Randevular WHERE DoktorID = @DoktorID AND RandevuTarihi = @RandevuTarihi AND RandevuSaati = @RandevuSaati";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DoktorID", DoktorID);
                    command.Parameters.AddWithValue("@RandevuTarihi", RandevuTarihi);
                    command.Parameters.AddWithValue("@RandevuSaati", RandevuSaati);


                    connection.Open();


                    int count = (int)command.ExecuteScalar();


                    return count > 0;
                }
            }
        }


        public bool RandevuVarMi(int HastaId, int DoktorId)
        {
            // Veritabanı bağlantı dizesi
            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";

            // SQL sorgusu
            string checkQuery = @"SELECT COUNT(*) 
                          FROM Randevular 
                          WHERE HastaID = @HastaID 
                            AND DoktorID = @DoktorID";

            // Değişken tanımla
            int count = 0;

            // SQL bağlantısı ve komut nesnelerini oluştur
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(checkQuery, connection))
            {
                // Parametreleri ekleyerek SQL sorgusunu hazırla
                command.Parameters.AddWithValue("@HastaID", HastaId);
                command.Parameters.AddWithValue("@DoktorID", DoktorId);

                // Bağlantıyı aç ve sorguyu çalıştır
                try
                {
                    connection.Open();
                    count = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }

            // Randevu var mı yok mu kontrol et
            return count > 0;
        }



        public void HastaRandevuOlustur(int DoktorID, int HastaID, DateTime RandevuTarihi, TimeSpan RandevuSaati)
        {
            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Randevu tablosuna ekleme
                string randevuQuery = "INSERT INTO Randevular (DoktorID, HastaID, RandevuTarihi, RandevuSaati) VALUES (@DoktorID, @HastaID, @RandevuTarihi, @RandevuSaati)";
                SqlCommand randevuCommand = new SqlCommand(randevuQuery, connection);
                randevuCommand.Parameters.AddWithValue("@DoktorID", DoktorID);
                randevuCommand.Parameters.AddWithValue("@HastaID", HastaID);
                randevuCommand.Parameters.AddWithValue("@RandevuTarihi", RandevuTarihi);
                randevuCommand.Parameters.AddWithValue("@RandevuSaati", RandevuSaati);
                randevuCommand.ExecuteNonQuery();

                // HastalarVeRandevular tablosuna ekleme
                string hastalarQuery = "INSERT INTO HastalarVeRandevulari (HastaID, DoktorID, RandevuTarihi, RandevuSaati) VALUES (@HastaID, @DoktorID, @RandevuTarihi, @RandevuSaati)";
                SqlCommand hastalarCommand = new SqlCommand(hastalarQuery, connection);
                hastalarCommand.Parameters.AddWithValue("@HastaID", HastaID);
                hastalarCommand.Parameters.AddWithValue("@DoktorID", DoktorID);
                hastalarCommand.Parameters.AddWithValue("@RandevuTarihi", RandevuTarihi);
                hastalarCommand.Parameters.AddWithValue("@RandevuSaati", RandevuSaati);
                hastalarCommand.ExecuteNonQuery();

                // DoktorlarVeRandevular tablosuna ekleme
                string doktorlarQuery = "INSERT INTO DoktorlarVeRandevulari (DoktorID, HastaID, RandevuTarihi, RandevuSaati) VALUES (@DoktorID, @HastaID, @RandevuTarihi, @RandevuSaati)";
                SqlCommand doktorlarCommand = new SqlCommand(doktorlarQuery, connection);
                doktorlarCommand.Parameters.AddWithValue("@DoktorID", DoktorID);
                doktorlarCommand.Parameters.AddWithValue("@HastaID", HastaID);
                doktorlarCommand.Parameters.AddWithValue("@RandevuTarihi", RandevuTarihi);
                doktorlarCommand.Parameters.AddWithValue("@RandevuSaati", RandevuSaati);
                doktorlarCommand.ExecuteNonQuery();
            }
        }







        public void HastaRandevuIptali(int DoktorID, int HastaID)
        {
            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Randevular tablosundan silme işlemi
                string deleteRandevuQuery = "DELETE FROM Randevular WHERE DoktorID = @DoktorID AND HastaID = @HastaID";
                SqlCommand deleteRandevuCommand = new SqlCommand(deleteRandevuQuery, connection);
                deleteRandevuCommand.Parameters.AddWithValue("@DoktorID", DoktorID);
                deleteRandevuCommand.Parameters.AddWithValue("@HastaID", HastaID);
                deleteRandevuCommand.ExecuteNonQuery();

                // DoktorlarVeRandevulari tablosundan silme işlemi
                string deleteDoktorlarVeRandevulariQuery = "DELETE FROM DoktorlarVeRandevulari WHERE DoktorID = @DoktorID AND HastaID = @HastaID";
                SqlCommand deleteDoktorlarVeRandevulariCommand = new SqlCommand(deleteDoktorlarVeRandevulariQuery, connection);
                deleteDoktorlarVeRandevulariCommand.Parameters.AddWithValue("@DoktorID", DoktorID);
                deleteDoktorlarVeRandevulariCommand.Parameters.AddWithValue("@HastaID", HastaID);
                deleteDoktorlarVeRandevulariCommand.ExecuteNonQuery();

                // HastalarVeRandevulari tablosundan silme işlemi
                string deleteHastalarVeRandevulariQuery = "DELETE FROM HastalarVeRandevulari WHERE DoktorID = @DoktorID AND HastaID = @HastaID";
                SqlCommand deleteHastalarVeRandevulariCommand = new SqlCommand(deleteHastalarVeRandevulariQuery, connection);
                deleteHastalarVeRandevulariCommand.Parameters.AddWithValue("@DoktorID", DoktorID);
                deleteHastalarVeRandevulariCommand.Parameters.AddWithValue("@HastaID", HastaID);
                deleteHastalarVeRandevulariCommand.ExecuteNonQuery();

                connection.Close();
            }
        }





        public void HastaRandevuGuncelle(int DoktorID, int HastaID, DateTime RandevuTarihi, TimeSpan RandevuSaati)
        {
            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Randevu tablosunda güncelleme
                string randevuQuery = "UPDATE Randevular SET RandevuTarihi = @RandevuTarihi, RandevuSaati = @RandevuSaati WHERE DoktorID = @DoktorID AND HastaID = @HastaID";
                SqlCommand randevuCommand = new SqlCommand(randevuQuery, connection);
                randevuCommand.Parameters.AddWithValue("@RandevuTarihi", RandevuTarihi);
                randevuCommand.Parameters.AddWithValue("@RandevuSaati", RandevuSaati);
                randevuCommand.Parameters.AddWithValue("@DoktorID", DoktorID);
                randevuCommand.Parameters.AddWithValue("@HastaID", HastaID);
                randevuCommand.ExecuteNonQuery();

                // HastalarVeRandevular tablosunda güncelleme
                string hastalarQuery = "UPDATE HastalarVeRandevulari SET RandevuTarihi = @RandevuTarihi, RandevuSaati = @RandevuSaati WHERE HastaID = @HastaID AND DoktorID = @DoktorID";
                SqlCommand hastalarCommand = new SqlCommand(hastalarQuery, connection);
                hastalarCommand.Parameters.AddWithValue("@RandevuTarihi", RandevuTarihi);
                hastalarCommand.Parameters.AddWithValue("@RandevuSaati", RandevuSaati);
                hastalarCommand.Parameters.AddWithValue("@HastaID", HastaID);
                hastalarCommand.Parameters.AddWithValue("@DoktorID", DoktorID);
                hastalarCommand.ExecuteNonQuery();

                // DoktorlarVeRandevular tablosunda güncelleme
                string doktorlarQuery = "UPDATE DoktorlarVeRandevulari SET RandevuTarihi = @RandevuTarihi, RandevuSaati = @RandevuSaati WHERE DoktorID = @DoktorID AND HastaID = @HastaID";
                SqlCommand doktorlarCommand = new SqlCommand(doktorlarQuery, connection);
                doktorlarCommand.Parameters.AddWithValue("@RandevuTarihi", RandevuTarihi);
                doktorlarCommand.Parameters.AddWithValue("@RandevuSaati", RandevuSaati);
                doktorlarCommand.Parameters.AddWithValue("@DoktorID", DoktorID);
                doktorlarCommand.Parameters.AddWithValue("@HastaID", HastaID);
                doktorlarCommand.ExecuteNonQuery();
            }
        }




        public void HastaKendiBilgisiGuncelleme(int HastaID, string Ad, string Soyad, DateTime DogumTarihi, string Cinsiyet, string TelefonNumarasi, string Adres, string HastaSifre)
        {

            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";
            // Güncelleme işlemi için SQL sorgusu
            string query = "UPDATE Hasta SET Ad = @Ad, Soyad = @Soyad, DogumTarihi = @DogumTarihi, Cinsiyet = @Cinsiyet, TelefonNumarasi = @TelefonNumarasi, Adres = @Adres, HastaSifre = @HastaSifre WHERE HastaID = @HastaID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Ad", Ad);
                    command.Parameters.AddWithValue("@Soyad", Soyad);
                    command.Parameters.AddWithValue("@DogumTarihi", DogumTarihi);
                    command.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);
                    command.Parameters.AddWithValue("@TelefonNumarasi", TelefonNumarasi);
                    command.Parameters.AddWithValue("@Adres", Adres);
                    command.Parameters.AddWithValue("HastaSifre", HastaSifre);
                    command.Parameters.AddWithValue("@HastaID", HastaID);



                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }




        public DataTable HastaRandevulariniGoruntule(int hastaId)
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
                        r.HastaID = @HastaID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HastaID", hastaId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }



    }

}