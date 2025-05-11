using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prolab2_3_3
{
    public partial class YoneticiHastaSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }




        protected void btnHastaSil_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği hasta ID'sini al
            int hastaId = Convert.ToInt32(txtHastaId.Value);
          
            Yonetici yonetici = new Yonetici();

            // Hasta silme işlemini gerçekleştir
            yonetici.HastaSil(hastaId);

          
            lblMessage.Visible = true;
            lblMessage.Text = "Hasta silme işlemi başarıyla gerçekleştirildi.";
        }




    }
}