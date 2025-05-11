using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prolab2_3_3
{
    public partial class DoktorAnasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void btnRandevuGoruntule_Click(object sender, EventArgs e)
        {
            Response.Redirect("DoktorRandevuGoruntuleme.aspx");
        }

        public void btnRaporSil_Click(object sender, EventArgs e)
        {
            Response.Redirect("DoktorRaporSil.aspx");
        }

        public void btnRaporEkle_Click(object sender, EventArgs e)
        {
            Response.Redirect("DoktorRaporEkle.aspx");
        }


        public void btnRaporGuncelle_Click(object sender, EventArgs e)
        {
            Response.Redirect("DoktorRaporGuncelle.aspx");
        }

        public void btnDoktorBilgilerimiGuncelle_Click(object sender, EventArgs e) {

            Response.Redirect("DoktorKendiBilgisiniGuncelleme.aspx");

        }






    }
}