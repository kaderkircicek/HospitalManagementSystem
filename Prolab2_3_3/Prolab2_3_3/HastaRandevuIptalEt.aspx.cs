using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prolab2_3_3
{
    public partial class HastaRandevuIptalEt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnRandevuSil_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği ID değerini al
            int DoktorId = Convert.ToInt32(txtDoktorID.Text);
            int HastaID = (int)Session["HastaID"];

            // Hasta nesnesi oluştur
            Hasta hasta = new Hasta();

            // Hasta nesnesi üzerinden randevu iptal fonksiyonunu çağır
            hasta.HastaRandevuIptali(DoktorId,HastaID);

            // İşlem başarılı mesajını görüntüle
            lblMessage.Text = "Randevu başarıyla iptal edildi.";
            lblMessage.Visible = true;
        }








    }
}