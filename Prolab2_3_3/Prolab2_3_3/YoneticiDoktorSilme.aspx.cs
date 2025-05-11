using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prolab2_3_3
{
    public partial class YoneticiDoktorSilme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDoktorSil_Click(object sender, EventArgs e)
        { 
        // Kullanıcının girdiği değeri bir değişkende saklayalım
            int doktorId = Convert.ToInt32(TextDoktorId.Text);

        // Yönetici sınıfından bir nesne oluşturalım
        Yonetici yonetici = new Yonetici();

        // Doktor silme fonksiyonunu çağırarak parametreyi gönderelim
        yonetici.DoktorSil(doktorId);

            // İşlem başarılıysa bir mesaj gösterelim
            lblMessage.Visible = true;
            lblMessage.Text = "Doktor başarıyla silindi.";
        }


     }
 }

