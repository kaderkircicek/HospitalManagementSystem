using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Prolab2_3_3
{
    public class Yonetici
    {

        public bool YoneticiGirisKontrol(int kullaniciId, string sifre)
        {
            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Yonetici WHERE YoneticiID = @YoneticiID AND YoneticiSifre = @YoneticiSifre";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@YoneticiID", kullaniciId);
                command.Parameters.AddWithValue("@YoneticiSifre", sifre);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }




        public void DoktorEkle(string ad, string soyad, string uzmanlik, string hastane, string sifre)
        {
            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Doktor (Ad, Soyad, UzmanlikAlani, CalistigiHastane,Sifre) VALUES (@Ad, @Soyad, @UzmanlikAlani, @CalistigiHastane,@Sifre)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Ad", ad);
                command.Parameters.AddWithValue("@Soyad", soyad);
                command.Parameters.AddWithValue("@UzmanlikAlani", uzmanlik);
                command.Parameters.AddWithValue("@CalistigiHastane", hastane);
                command.Parameters.AddWithValue("@Sifre", sifre);


                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public void DoktorSil(int doktorId)
        {
            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";

            // İlgili doktorun randevularını sil
            string randevuSilQuery = "DELETE FROM Randevular WHERE DoktorID = @DoktorID";
            string DoktorlarVeRandevulariSilQuery = "DELETE FROM DoktorlarVeRandevulari WHERE DoktorID = @DoktorID";
            string HastalarVeRandevulariSilQuery = "DELETE FROM HastalarVeRandevulari WHERE DoktorID = @DoktorID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Randevu silme işlemi için komut oluştur
                using (SqlCommand DoktorlarVeRandevulariSilCommand = new SqlCommand(DoktorlarVeRandevulariSilQuery, connection))
                {
                    DoktorlarVeRandevulariSilCommand.Parameters.AddWithValue("@DoktorID", doktorId);
                    DoktorlarVeRandevulariSilCommand.ExecuteNonQuery();
                }

                using (SqlCommand HastalarVeRandevulariSilCommand = new SqlCommand(HastalarVeRandevulariSilQuery, connection))
                {
                    HastalarVeRandevulariSilCommand.Parameters.AddWithValue("@DoktorID", doktorId);
                    HastalarVeRandevulariSilCommand.ExecuteNonQuery();
                }

                using (SqlCommand randevuSilCommand = new SqlCommand(randevuSilQuery, connection))
                {
                    randevuSilCommand.Parameters.AddWithValue("@DoktorID", doktorId);
                    randevuSilCommand.ExecuteNonQuery();
                }


                // Doktoru silme işlemi için komut oluştur
                string doktorSilQuery = "DELETE FROM Doktor WHERE DoktorID = @DoktorID";

                using (SqlCommand doktorSilCommand = new SqlCommand(doktorSilQuery, connection))
                {
                    doktorSilCommand.Parameters.AddWithValue("@DoktorID", doktorId);
                    doktorSilCommand.ExecuteNonQuery();
                }
            }
        }





        public void DoktorGuncelle(int doktorId, string ad, string soyad, string uzmanlik, string hastane, string sifre)
        {
            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";

            string query = "UPDATE Doktor SET Ad=@Ad, Soyad=@Soyad, UzmanlikAlani=@UzmanlikAlani, CalistigiHastane=@CalistigiHastane, Sifre=@Sifre WHERE DoktorId=@DoktorId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Ad", ad);
                    command.Parameters.AddWithValue("@Soyad", soyad);
                    command.Parameters.AddWithValue("@UzmanlikAlani", uzmanlik);
                    command.Parameters.AddWithValue("@CalistigiHastane", hastane);
                    command.Parameters.AddWithValue("@Sifre", sifre);
                    command.Parameters.AddWithValue("@DoktorID", doktorId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }




        public void HastaEkle(string ad, string soyad, DateTime DogumTarihi, string cinsiyet, string telno, string adres, string sifre)
        {
            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Hasta (Ad, Soyad, DogumTarihi, Cinsiyet, TelefonNumarasi, Adres, HastaSifre) VALUES (@Ad, @Soyad, @DogumTarihi, @Cinsiyet, @TelefonNumarasi, @Adres, @HastaSifre)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Ad", ad);
                command.Parameters.AddWithValue("@Soyad", soyad);
                command.Parameters.AddWithValue("@DogumTarihi", DogumTarihi);
                command.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                command.Parameters.AddWithValue("@TelefonNumarasi", telno);
                command.Parameters.AddWithValue("@Adres", adres);
                command.Parameters.AddWithValue("HastaSifre", sifre);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }




        public void HastaSil(int hastaId)
        {
            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";

            // İlgili doktorun randevularını sil
            string randevuSilQuery = "DELETE FROM Randevular WHERE HastaID = @HastaID";
            string DoktorlarVeRandevulariSilQuery = "DELETE FROM DoktorlarVeRandevulari WHERE HastaID = @HastaID";
            string HastalarVeRandevulariSilQuery = "DELETE FROM HastalarVeRandevulari WHERE HastaID = @HastaID";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                using (SqlCommand DoktorlarVeRandevulariSilCommand = new SqlCommand(DoktorlarVeRandevulariSilQuery, connection))
                {
                    DoktorlarVeRandevulariSilCommand.Parameters.AddWithValue("@HastaID", hastaId);
                    DoktorlarVeRandevulariSilCommand.ExecuteNonQuery();
                }

                using (SqlCommand HastalarVeRandevulariSilCommand = new SqlCommand(HastalarVeRandevulariSilQuery, connection))
                {
                    HastalarVeRandevulariSilCommand.Parameters.AddWithValue("@HastaID", hastaId);
                    HastalarVeRandevulariSilCommand.ExecuteNonQuery();
                }


                using (SqlCommand randevuSilCommand = new SqlCommand(randevuSilQuery, connection))
                {
                    randevuSilCommand.Parameters.AddWithValue("@HastaID", hastaId);
                    randevuSilCommand.ExecuteNonQuery();
                }


                string hastaSilQuery = "DELETE FROM Hasta WHERE HastaID = @HastaID";

                using (SqlCommand hastaSilCommand = new SqlCommand(hastaSilQuery, connection))
                {
                    hastaSilCommand.Parameters.AddWithValue("@HastaID", hastaId);
                    hastaSilCommand.ExecuteNonQuery();
                }
            }
        }



        public void HastaGuncelle(int HastaID, string ad, string soyad,  string cinsiyet, string telno, string adres, string sifre)
        {
            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";
            // Güncelleme işlemi için SQL sorgusu
            string query = "UPDATE Hasta SET Ad = @Ad, Soyad = @Soyad, Cinsiyet = @Cinsiyet, TelefonNumarasi = @TelefonNumarasi, Adres = @Adres, HastaSifre = @HastaSifre WHERE HastaID = @HastaID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametreleri ekleyerek SQL Injection saldırılarından korunma
                    command.Parameters.AddWithValue("@Ad", ad);
                    command.Parameters.AddWithValue("@Soyad", soyad);
                    command.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                    command.Parameters.AddWithValue("@TelefonNumarasi", telno);
                    command.Parameters.AddWithValue("@Adres", adres);
                    command.Parameters.AddWithValue("HastaSifre", sifre);
                    command.Parameters.AddWithValue("@HastaID", HastaID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }


        public void YoneticiKendiBilgisiniGuncelleme(int YoneticiID, string sifre)
        {
            // Veritabanı bağlantı dizesi
            string connectionString = "Data Source=LAPTOP-KH2PNG3N\\SQLEXPRESS02;Initial Catalog=Hastane_Yonetim_Sistemi_2_3_3;Integrated Security=True;";

            // SQL sorgusu
            string query = "UPDATE Yonetici SET YoneticiSifre = @YoneticiSifre WHERE YoneticiID = @YoneticiID";

            // Bağlantı oluşturma ve komut hazırlama
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametreleri ekleme
                    command.Parameters.AddWithValue("@YoneticiSifre", sifre);
                    command.Parameters.AddWithValue("@YoneticiID", YoneticiID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }



    }

}
