using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prolab2_3_3
{
    public partial class YoneticiDoktorGuncelleme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDoktorGuncelle_Click(object sender, EventArgs e)
        {
            int doktorId = Convert.ToInt32(TextDoktorId.Text);
            string ad = txtDoktorAdi.Text;
            string soyad = txtDoktorSoyadi.Text;
            string uzmanlik = txtUzmanlik.Text;
            string hastane = txtHastane.Text;
            string sifre = txtSifre.Text;

            Yonetici yonetici = new Yonetici();
            yonetici.DoktorGuncelle(doktorId,ad, soyad, uzmanlik, hastane, sifre);


            // Başarı mesajı göster
            lblMessage.Text = "Doktor başarıyla güncellendi.";
            lblMessage.Visible = true;


        }
    }
}