using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prolab2_3_3
{
    public partial class HastaRandevuGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnRandevuGuncelle_Click(object sender, EventArgs e) {

            int hastaID = (int)Session["HastaID"];
            int doktorID;
            DateTime randevuTarihi;
            TimeSpan randevuSaati;


            int.TryParse(txtDoktorID.Value, out doktorID);
            DateTime.TryParse(txtRandevuTarihi.Value, out randevuTarihi);
            TimeSpan.TryParse(txtRandevuSaati.Value, out randevuSaati);

            Hasta hasta = new Hasta();







            if (hasta.RandevuVarMi(hastaID,doktorID)== true && hasta.HastaIcinRandevuVarMi(hastaID, randevuTarihi, randevuSaati) == false && hasta.DoktorIcinRandevuVarMi(doktorID, randevuTarihi, randevuSaati) == false)
            {


                hasta.HastaRandevuGuncelle(doktorID, hastaID, randevuTarihi, randevuSaati);
                lblMessage.Visible = true;
                lblMessage.Text = "İstenen değişikliklere uygun randevu bulundu ve güncellendi.";


            }

            else
            {

                lblMessage.Text = "Randevu oluşturulamadı.";

            }


        }
    }
}