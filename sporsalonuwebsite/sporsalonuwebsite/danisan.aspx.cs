using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yazlab10
{
    public partial class kullanici : System.Web.UI.Page
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "hrRd9DYtze5puhjZLjUuoEOfvTnCq08O7OXG5VC7",
            BasePath = "https://denememvc-6f93d-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        protected void Page_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void girisbuton_Click(object sender, EventArgs e)
        {
            string epostam = TextBox1.Text;
            string sifrem = TextBox2.Text;

            // Adı alıp Firebase'den soyadı çek
            FirebaseResponse epostaResponse = client.Get("kullanicilar/kullanici/eposta");
            FirebaseResponse sifreResponse = client.Get("kullanicilar/kullanici/sifre");

            if (epostaResponse.Body != "null" && sifreResponse.Body != "null")
            {
                string eposta = epostaResponse.ResultAs<string>();
                string sifre = sifreResponse.ResultAs<string>();

                // Ad ve soyad karşılaştırması
                if (epostam == eposta && sifrem == sifre)
                {
                    Response.Redirect("WebForm2.aspx");


                }
                else
                {
                    Response.Write("Bilgiler yanlış");
                }
            }
            else
            {
                Response.Write("Kullanıcı bulunamadı");
            }
        }
    }
}