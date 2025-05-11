using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prolab2_3_3
{
    public partial class YoneticiRaporSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnRaporSil_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği hasta ID'sini al
            int RaporId = Convert.ToInt32(txtRaporID.Value);

            Rapopr rapor = new Rapopr();

            // Hasta silme işlemini gerçekleştir
            int row = rapor.RaporSil(RaporId);


            lblMessage.Visible = true;
            lblMessage.Text = row == 0 ? "böyle bir rapor bulunamadı" : "rapor silme işlemi başariyla gerçekleşti";
        }


    }
}