using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prolab2_3_3
{
    public partial class HastaRandevuOlustur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            // Değişkenleri tanımla
           
            int hastaID = (int)Session["HastaID"];
            int doktorID;
            DateTime randevuTarihi;
            TimeSpan randevuSaati;

            
            int.TryParse(txtDoktorID.Value, out doktorID);
            DateTime.TryParse(txtRandevuTarihi.Value, out randevuTarihi);
            TimeSpan.TryParse(txtRandevuSaati.Value, out randevuSaati);

            Hasta hasta = new Hasta();

            if (hasta.HastaVarMi(hastaID) == true && hasta.DoktorVarMi(doktorID) == true && hasta.HastaIcinRandevuVarMi(hastaID, randevuTarihi, randevuSaati) == false && hasta.DoktorIcinRandevuVarMi(doktorID, randevuTarihi, randevuSaati) == false && hasta.HastaninAyniDoktorIcinRandevusuVarMi(hastaID, doktorID) == false)
            {

                hasta.HastaRandevuOlustur(doktorID, hastaID, randevuTarihi, randevuSaati);
                lblMessage.Visible = true;
                lblMessage.Text = "Yeni Randevu Oluşturuldu.";



            }

            else 
            {

                lblMessage.Text = "Randevu oluşturulamadı.";

            }


        }
    }
}
