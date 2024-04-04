using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;

namespace yazlab10
{
    public partial class kayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ltAd.Text = "<input class='form-control' id='name' name='name' placeholder='Name' type='text' required><br>";
            ltEmail.Text = "<input class='form-control' id='email' name='email' placeholder='Email' type='email' required><br>";
            ltComments.Text = "<textarea class='form-control' id='comments' name='comments' placeholder='Comment' rows='5'></textarea><br>";
            ltEmailkayıt.Text = "<input type='text' placeholder='Epostanızı Giriniz Giriniz' name='email' id='emailkayıt' required><br>";
            ltPassword.Text = "<input type='password' placeholder='Şifrenizi Giriniz' name='psw' id='psw' required><br>";
            ltRepeatPassword.Text = "<input type='password' placeholder='Şifrenizi Tekrar Giriniz' name='psw-repeat' id='psw-repeat' required><br>";
            ltAdkayıt.Text = "<input type='text' placeholder='İsminizi Giriniz' name='isim' id='isim' required><br>";
            ltsoyadkayıt.Text = "<input type='text' placeholder='Soyisminizi Giriniz' name='soyisim' id='soyisim' required><br>";
            ltdogumkayıt.Text = "<input type='text' placeholder='Doğum Tarihinizi Giriniz' name='dogumtarihi' id='dogumtarihi' required><br>";
            lttelefonkayıt.Text = "<input type='text' placeholder='Telefon Numaranızı Giriniz' name='telefonno' id='telefonno' required><br>";
            ltkilokayıt.Text= "<input type='text' placeholder='Kilonuzu Giriniz' name='kilo' id='kilo' required><br>";


        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string authSecret = "hrRd9DYtze5puhjZLjUuoEOfvTnCq08O7OXG5VC7";
            string basePath = "https://denememvc-6f93d-default-rtdb.firebaseio.com/";
            IFirebaseClient client;
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = authSecret,
                BasePath = basePath
            };
            client = new FireSharp.FirebaseClient(config);

            if (client != null && !string.IsNullOrEmpty(basePath) && !string.IsNullOrEmpty(authSecret))
            {
                var data = new
                {
                    Name = Request.Form["name"],
                    Comments = Request.Form["comments"],
                    İsim = Request["isim"],
                    Soyisim = Request["soyisim"],
                    Eposta = Request.Form["email"],
                    Şifre = Request.Form["psw"],
                    Dogumtarihi = Request["dogumtarihi"],
                    TelefonNo = Request["telefonno"],
                    Kilo = Request["kilo"],
                  
                    BasvuruSebebi = Request.Form["basvurmaSebebi"] 
                };

                string basvurmaSebebi = Request.Form["basvurmaSebebi"]; 

                var response = client.Push("kullanicilar/", data);
               
                if (response.Result != null && !string.IsNullOrEmpty(response.Result.name))
                {
                    
                    string yeniKullaniciUid = response.Result.name;

                    
                    var yeniUidResponse = client.Set("kullanicilar/" + yeniKullaniciUid + "/KullaniciId", yeniKullaniciUid);
                    
                }
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            // Diğer işlemler
        }
    }
}
