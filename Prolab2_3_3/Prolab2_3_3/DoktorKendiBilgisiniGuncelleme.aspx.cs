using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prolab2_3_3
{
    public partial class DoktorKendiBilgisiniGuncelleme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }




        public void btnDoktorGuncelle_Click(object sender, EventArgs e)
        {

            int DoktorID = (int)Session["DoktorID"];
            string ad = txtDoktorAdi.Text;
            string soyad = txtDoktorSoyadi.Text;
            string uzmanlik = txtUzmanlik.Text;
            string hastane = txtHastane.Text;
            string sifre = txtSifre.Text;

            Doktor doktor = new Doktor();
            doktor.DoktorKendiBilgisiniGuncelleme(DoktorID,ad,soyad,uzmanlik,hastane,sifre);

            lblMessage.Text = "Bilgileriniz başarıyla güncellendi.";
            lblMessage.Visible = true;

        }



    }
}