using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prolab2_3_3
{
    public partial class YoneticiHastaEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnHastaEkle_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği değerleri değişkenlere atama
            string ad = txtHastaAdi.Value;
            string soyad = txtHastaSoyadi.Value;
            DateTime dogumTarihi = Convert.ToDateTime(txtHastaDogumTarihi.Value);
            string cinsiyet = txtHastaCinsiyet.Value;
            string telNo = txtHastaTelNo.Value;
            string adres = txtHastaAdres.Value;
            string sifre = txtSifre.Value;

            // Yönetici sınıfından bir nesne oluştur
            Yonetici yonetici = new Yonetici();

            // Hasta ekleme işlemini çağır ve değişkenleri parametre olarak gönder
            yonetici.HastaEkle(ad, soyad, dogumTarihi, cinsiyet, telNo, adres, sifre);

            // İşlem tamamlandıktan sonra kullanıcıya mesaj göster
            lblMessage.Text = "Hasta başarıyla eklendi.";
            lblMessage.Visible = true;
        }


    }
}