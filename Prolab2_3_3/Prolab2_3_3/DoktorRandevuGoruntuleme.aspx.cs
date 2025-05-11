using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prolab2_3_3
{
    public partial class DoktorRandevuGoruntuleme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int DoktorID = (int)Session["DoktorID"];
            Doktor doktor = new Doktor();
            RandevulariGoster(doktor, DoktorID);

        }



        private void RandevulariGoster(Doktor doktor, int doktorId)
        {
            DataTable dt = doktor.DoktorRandevulariniGoster(doktorId);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }








    }
}