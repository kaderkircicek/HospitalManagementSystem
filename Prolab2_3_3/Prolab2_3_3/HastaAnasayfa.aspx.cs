using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prolab2_3_3
{
    public partial class HastaAnasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRandevuOlustur_Click(object sender, EventArgs e)

        {
            Response.Redirect("HastaRandevuOlustur.aspx");
        }

        protected void btnRandevuIptalEt_Click(object sender, EventArgs e)
        {
            Response.Redirect("HastaRandevuIptalEt.aspx");
        }

        protected void btnRandevularimiGoruntule_Click(object sender, EventArgs e)
        {
            Response.Redirect("HastaRandevularimiGoruntule.aspx");
        }

        protected void btnRaporlarimiGoruntule_Click(object sender, EventArgs e)
        {
            Response.Redirect("HastaRaporGoruntuleme.aspx");
        }

        protected void btnRandevularimiGuncelle_Click(object sender, EventArgs e)
        {
            Response.Redirect("HastaRandevuGuncelle.aspx");
        }

        public void btnRaporEkle_Click(object sender, EventArgs e)
        {
            Response.Redirect("HastaRaporEkle.aspx");
        }

        public void btnRaporSil_Click(object sender, EventArgs e)
        {
            Response.Redirect("HastaRaporSil.aspx");
        }


       public void btnHastaBilgilerimiGuncelle_Click(object sender, EventArgs e)
        {
            Response.Redirect("HastaKendiBilgisiniGuncelle.aspx");
        }







    }
}
