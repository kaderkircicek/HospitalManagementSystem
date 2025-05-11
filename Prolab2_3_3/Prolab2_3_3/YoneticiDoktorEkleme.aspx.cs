using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prolab2_3_3
{
    public partial class YoneticiDoktorEkleme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            // Formdaki değerleri al
            string ad = txtDoktorAdi.Text;
            string soyad = txtDoktorSoyadi.Text;
            string uzmanlik = txtUzmanlik.Text;
            string hastane = txtHastane.Text;
            string sifre = txtSifre.Text;

            // Veritabanına doktor ekle
            Yonetici yonetici = new Yonetici();
            yonetici.DoktorEkle(ad, soyad, uzmanlik, hastane, sifre);

            // Başarı mesajı göster
            lblMessage.Text = "Doktor başarıyla eklendi.";
            lblMessage.Visible = true;
        }
    }
}