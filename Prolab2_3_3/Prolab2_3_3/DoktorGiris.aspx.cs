using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prolab2_3_3
{
    public partial class DoktorGiris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {

            int kullaniciId = Convert.ToInt32(txtUsername.Text);
            Session["DoktorID"] = kullaniciId;
            string sifre = txtPassword.Text;

            // Yonetici sınıfından bir nesne oluştur
            Doktor doktor = new Doktor();

            // YoneticiGirisKontrol fonksiyonunu çağır ve sonucu al
            bool girisBasarili = doktor.DoktorGirisKontrol(kullaniciId, sifre);

            // Eğer giriş başarılıysa yeni sayfa aç
            if (girisBasarili)
            {
                // Yeni sayfayı açmak için yönlendirme yapabilirsiniz.
                // Örneğin:
                Response.Redirect("DoktorAnasayfa.aspx");
            }

        }

    }
   }
