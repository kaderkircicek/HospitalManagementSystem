using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prolab2_3_3
{
    public partial class HastaKendiBilgisiniGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnHastaGuncelle_Click(object sender, EventArgs e)
        {
            int hastaID = (int)Session["HastaID"];
            string ad = txtHastaAdi.Value;
            string soyad = txtHastaSoyadi.Value;
            DateTime dogumTarihi = Convert.ToDateTime(txtHastaDogumTarihi.Value);
            string cinsiyet = txtHastaCinsiyet.Value;
            string telNo = txtHastaTelNo.Value;
            string adres = txtHastaAdres.Value;
            string sifre = txtSifre.Value;


             Hasta hasta= new Hasta();
            hasta.HastaKendiBilgisiGuncelleme(hastaID, ad, soyad, dogumTarihi, cinsiyet, telNo, adres, sifre);
            lblMessage.Visible = true;
            lblMessage.Text = "Hasta bilgisi güncellendi.";

        }

    }
}