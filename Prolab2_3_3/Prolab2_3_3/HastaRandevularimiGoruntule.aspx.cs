using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prolab2_3_3
{
    public partial class HastaRandevularimiGoruntule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int HastaID = (int)Session["HastaID"];
            Hasta hasta = new Hasta();
            RandevulariGoster(hasta, HastaID);

        }



        private void RandevulariGoster(Hasta hasta, int HastaID)
        {
            DataTable dt = hasta.HastaRandevulariniGoruntule(HastaID);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}