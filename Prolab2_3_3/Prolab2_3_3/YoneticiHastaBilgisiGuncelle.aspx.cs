using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prolab2_3_3
{
    public partial class YoneticiHastaBilgisiGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHastaGuncelle_Click(object sender, EventArgs e)
        {
            int hastaID = Convert.ToInt32(txHastaId.Value);
            string ad = txtHastaAdi.Value;
            string soyad = txtHastaSoyadi.Value;
            string cinsiyet = txtHastaCinsiyet.Value;
            string telNo = txtHastaTelNo.Value;
            string adres = txtHastaAdres.Value;
            string sifre = txtSifre.Value;

         
            Yonetici yonetici = new Yonetici();

         
            yonetici.HastaGuncelle(hastaID, ad, soyad, cinsiyet, telNo, adres, sifre);

            
            lblMessage.Visible = true;
            lblMessage.Text = "Hasta bilgileri güncellendi.";
        }

    }
}