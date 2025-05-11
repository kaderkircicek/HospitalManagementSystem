using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prolab2_3_3
{
    public partial class YoneticiRaporEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public void btnRaporEkle_Click(object sender, EventArgs e)
        {
            // Formdaki değerleri al
            int doktorId;
            int hastaId;
            string randevuTarihi = txtRandevuTarih.Text;
            string RaporIcerigi = txtRaporIcerigi.Text;
            int YoneticiId;
            string Url = RaporUrl.Text;
            int.TryParse(txtDoktorId.Text, out doktorId);
            int.TryParse(txtHastaId.Text, out hastaId);
            int.TryParse(txtYoneticiId.Text, out YoneticiId);

            Rapopr rapor = new Rapopr();
            rapor.RaporEkle(doktorId, hastaId, YoneticiId, RaporIcerigi, randevuTarihi, Url);

            // Başarı mesajı göster
            lblMessage.Text = "Rapor başarıyla eklendi.";
            lblMessage.Visible = true;
        }








    }
}