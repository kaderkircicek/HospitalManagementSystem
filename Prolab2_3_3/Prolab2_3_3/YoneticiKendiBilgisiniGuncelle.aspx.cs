using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prolab2_3_3
{
    public partial class YoneticiKendiBilgisiniGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }





        protected void btnYoneticiGuncelle_Click(object sender, EventArgs e)
        {

            int YoneticiID = (int)Session["YoneticiID"];
            string sifre = txtSifre.Value;


            Yonetici yonetici = new Yonetici();
            yonetici.YoneticiKendiBilgisiniGuncelleme(YoneticiID, sifre);

            lblMessage.Visible = true;
            lblMessage.Text = "Yönetici bilgisi güncellendi.";

        }
    }
}