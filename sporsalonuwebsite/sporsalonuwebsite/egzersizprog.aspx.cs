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
    public partial class egzersizprog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (!IsPostBack)
                {
                    // Firebase konfigürasyonu
                    IFirebaseConfig config = new FirebaseConfig
                    {
                        AuthSecret = "hrRd9DYtze5puhjZLjUuoEOfvTnCq08O7OXG5VC7",
                        BasePath = "https://denememvc-6f93d-default-rtdb.firebaseio.com/"
                    };

                    IFirebaseClient client = new FireSharp.FirebaseClient(config);

                    FirebaseResponse responseAntrenor = client.Get("antrenor");

                    if (responseAntrenor != null && responseAntrenor.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        dynamic antrenorData = responseAntrenor.ResultAs<dynamic>();

                        // kiloalmaprog1
                        foreach (var antrenorItem in antrenorData)
                        {
                            FirebaseResponse kilovermeprog1Response = client.Get("antrenor/" + antrenorItem.Name + "/kilovermeprog1");

                            if (kilovermeprog1Response != null && kilovermeprog1Response.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                dynamic kilovermeprog1Data = kilovermeprog1Response.ResultAs<dynamic>();

                                if (kilovermeprog1Data != null)
                                {
                                    // kiloalmaprog1Data içeriğini kiloalmaprog1Label.Text'e ata
                                    kilovermeprog1Label.Text = kilovermeprog1Data;
                                    break; // İlk uygun veriyi bulduktan sonra döngüden çık
                                }
                            }
                        }

                        // kiloalmaprog2
                        foreach (var antrenorItem in antrenorData)
                        {
                            FirebaseResponse kilovermeprog2Response = client.Get("antrenor/" + antrenorItem.Name + "/kilovermeprog2");

                            if (kilovermeprog2Response != null && kilovermeprog2Response.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                dynamic kilovermeprog2Data = kilovermeprog2Response.ResultAs<dynamic>();

                                if (kilovermeprog2Data != null)
                                {
                                    kilovermeprog2Label.Text = kilovermeprog2Data;
                                    break;
                                }
                            }
                        }

                        // kiloalmaprog3
                        foreach (var antrenorItem in antrenorData)
                        {
                            FirebaseResponse kiloalmaprog3Response = client.Get("antrenor/" + antrenorItem.Name + "/kilovermeprog3");

                            if (kiloalmaprog3Response != null && kiloalmaprog3Response.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                dynamic kiloalmaprog3Data = kiloalmaprog3Response.ResultAs<dynamic>();

                                if (kiloalmaprog3Data != null)
                                {
                                    kilovermeprog3Label.Text = kiloalmaprog3Data;
                                    break;
                                }
                            }
                        }
                    }
                }   // Egzersiz programı metinlerini Label'lere atama
            }
        }
        protected void kilovermeprog1Button_Click(object sender, EventArgs e)
        {
            string selectedProgram = kilovermeprog1Label.Text; // Label'de yazan programı al

            // Firebase konfigürasyonu
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "hrRd9DYtze5puhjZLjUuoEOfvTnCq08O7OXG5VC7",
                BasePath = "https://denememvc-6f93d-default-rtdb.firebaseio.com/"
            };

            IFirebaseClient client = new FireSharp.FirebaseClient(config);

            // Session'dan KullaniciId'yi al
            string kullaniciId = Session["KullaniciId"].ToString();

            // Kullanıcının düğümünü al
            FirebaseResponse responseKullanici = client.Get("kullanicilar/" + kullaniciId);

            if (responseKullanici.StatusCode == System.Net.HttpStatusCode.OK)
            {
                dynamic kullaniciData = responseKullanici.ResultAs<dynamic>();

                // Eğer düğüm varsa, içine yeni bir key ekle
                if (kullaniciData != null)
                {
                    var data = new
                    {
                        Secilenprogram = selectedProgram
                    };

                    client.Update("kullanicilar/" + kullaniciId, data);
                    // Seçiminiz başarıyla gerçekleştirildi mesajı göster
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Seçiminiz başarıyla gerçekleştirildi.');", true);

                    // Butonu tekrar tıklayamaz hale getir
                    kilovermeprog1Button.Enabled = false;
                    kilovermeprog2Button.Enabled = false;
                    kilovermeprog3Button.Enabled = false;
                }
            }
        }

        protected void kilovermeprog2Button_Click(object sender, EventArgs e)
        {
            string selectedProgram = kilovermeprog2Label.Text; // Label'de yazan programı al

            // Firebase konfigürasyonu
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "hrRd9DYtze5puhjZLjUuoEOfvTnCq08O7OXG5VC7",
                BasePath = "https://denememvc-6f93d-default-rtdb.firebaseio.com/"
            };

            IFirebaseClient client = new FireSharp.FirebaseClient(config);

            // Session'dan KullaniciId'yi al
            string kullaniciId = Session["KullaniciId"].ToString();

            // Kullanıcının düğümünü al
            FirebaseResponse responseKullanici = client.Get("kullanicilar/" + kullaniciId);

            if (responseKullanici.StatusCode == System.Net.HttpStatusCode.OK)
            {
                dynamic kullaniciData = responseKullanici.ResultAs<dynamic>();

                // Eğer düğüm varsa, içine yeni bir key ekle
                if (kullaniciData != null)
                {
                    var data = new
                    {
                        Secilenprogram = selectedProgram
                    };

                    client.Update("kullanicilar/" + kullaniciId, data);
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Seçiminiz başarıyla gerçekleştirildi.');", true);

                    // Butonu tekrar tıklayamaz hale getir
                    kilovermeprog1Button.Enabled = false;
                    kilovermeprog2Button.Enabled = false;
                    kilovermeprog3Button.Enabled = false;
                }
            }
        }

        protected void kilovermeprog3Button_Click(object sender, EventArgs e)
        {
            string selectedProgram = kilovermeprog3Label.Text; // Label'de yazan programı al

            // Firebase konfigürasyonu
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "hrRd9DYtze5puhjZLjUuoEOfvTnCq08O7OXG5VC7",
                BasePath = "https://denememvc-6f93d-default-rtdb.firebaseio.com/"
            };

            IFirebaseClient client = new FireSharp.FirebaseClient(config);

            // Session'dan KullaniciId'yi al
            string kullaniciId = Session["KullaniciId"].ToString();

            // Kullanıcının düğümünü al
            FirebaseResponse responseKullanici = client.Get("kullanicilar/" + kullaniciId);

            if (responseKullanici.StatusCode == System.Net.HttpStatusCode.OK)
            {
                dynamic kullaniciData = responseKullanici.ResultAs<dynamic>();

                // Eğer düğüm varsa, içine yeni bir key ekle
                if (kullaniciData != null)
                {
                    var data = new
                    {
                        Secilenprogram = selectedProgram
                    };

                    client.Update("kullanicilar/" + kullaniciId, data);
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Seçiminiz başarıyla gerçekleştirildi.');", true);

                    // Butonu tekrar tıklayamaz hale getir
                    kilovermeprog1Button.Enabled = false;
                    kilovermeprog2Button.Enabled = false;
                    kilovermeprog3Button.Enabled = false;
                }
            }
        }
    }
}