using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Web.UI;

namespace yazlab10
{
    public partial class giris : Page
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

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            string eposta = txtEposta.Text;
            string sifre = txtSifre.Text;

            FirebaseResponse responseKullanicilar = client.Get("kullanicilar");
            FirebaseResponse responseAntrenorler = client.Get("antrenor");

            if (responseKullanicilar.Body != "null" && responseAntrenorler.Body != "null")
            {
                var usersKullanicilar = responseKullanicilar.ResultAs<Newtonsoft.Json.Linq.JObject>();
                var usersAntrenorler = responseAntrenorler.ResultAs<Newtonsoft.Json.Linq.JObject>();

                foreach (var user in usersKullanicilar)
                {
                    var userData = user.Value as Newtonsoft.Json.Linq.JObject;

                    if (userData != null)
                    {
                        string userEmail = userData["Eposta"]?.ToString();
                        string userPassword = userData["Şifre"]?.ToString();

                        if (!string.IsNullOrEmpty(userEmail) && !string.IsNullOrEmpty(userPassword))
                        {
                            if (eposta == userEmail && sifre == userPassword)
                            {
                                // Kullanıcı, "kullanicilar" düğümünde bulunuyor
                                Session["Eposta"] = userEmail;
                                Session["İsim"] = userData["İsim"]?.ToString();
                                Session["Soyisim"] = userData["Soyisim"]?.ToString();
                                Session["Dogumtarihi"] = userData["Dogumtarihi"]?.ToString();
                                Session["TelefonNo"] = userData["TelefonNo"]?.ToString();
                                Session["KullaniciId"] = userData["KullaniciId"]?.ToString();
                                Session["BasvuruSebebi"] = userData["BasvuruSebebi"]?.ToString();
                                Session["Kilo"] = userData["Kilo"]?.ToString();



                                Response.Redirect("WebForm2.aspx");
                                return;
                            }
                        }
                    }
                }

                foreach (var user in usersAntrenorler)
                {
                    var userData = user.Value as Newtonsoft.Json.Linq.JObject;

                    if (userData != null)
                    {
                        string userEmail = userData["Eposta"]?.ToString();
                        string userPassword = userData["Şifre"]?.ToString();

                        if (!string.IsNullOrEmpty(userEmail) && !string.IsNullOrEmpty(userPassword))
                        {
                            if (eposta == userEmail && sifre == userPassword)
                            {
                                Session["Eposta"] = userEmail;
                                Session["İsim"] = userData["İsim"]?.ToString();
                                Session["Soyisim"] = userData["Soyisim"]?.ToString();
                                Session["dogumtarihi"] = userData["dogumtarihi"]?.ToString();
                                Session["ilgialani"] = userData["ilgialani"]?.ToString();
                                Session["TelefonNo"] = userData["TelefonNo"]?.ToString();
                                Session["KullaniciId"] = userData["KullaniciId"]?.ToString();
                                Response.Redirect("antrenor.aspx");
                                return;
                            }
                        }
                    }
                }

                Response.Write("Kullanıcı verisi bulunamadı.");
            }
        }


    }
}
