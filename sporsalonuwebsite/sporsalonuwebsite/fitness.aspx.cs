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
    public partial class fitness : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (!IsPostBack)
                {
                   
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
                            FirebaseResponse fitnessprog1Response = client.Get("antrenor/" + antrenorItem.Name + "/fitnessprog1");

                            if (fitnessprog1Response != null && fitnessprog1Response.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                dynamic fitnessprog1Data = fitnessprog1Response.ResultAs<dynamic>();

                                if (fitnessprog1Data != null)
                                {
                                    
                                    fitnessprog1Label.Text = fitnessprog1Data;
                                    break; // İlk uygun veriyi bulduktan sonra döngüden çık
                                }
                            }
                        }

                        // kiloalmaprog2
                        foreach (var antrenorItem in antrenorData)
                        {
                            FirebaseResponse fitnessprog2Response = client.Get("antrenor/" + antrenorItem.Name + "/fitnessprog2");

                            if (fitnessprog2Response != null && fitnessprog2Response.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                dynamic fitnessprog2Data = fitnessprog2Response.ResultAs<dynamic>();

                                if (fitnessprog2Data != null)
                                {
                                    fitnessprog2Label.Text = fitnessprog2Data;
                                    break;
                                }
                            }
                        }

                        // kiloalmaprog3
                        foreach (var antrenorItem in antrenorData)
                        {
                            FirebaseResponse fitnessprog3Response = client.Get("antrenor/" + antrenorItem.Name + "/fitnessprog3");

                            if (fitnessprog3Response != null && fitnessprog3Response.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                dynamic fitnessprog3Data = fitnessprog3Response.ResultAs<dynamic>();

                                if (fitnessprog3Data != null)
                                {
                                    fitnessprog3Label.Text = fitnessprog3Data;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
      }
        protected void fitnessprog1Button_Click(object sender, EventArgs e)
        {
            string selectedProgram = fitnessprog1Label.Text; // Label'de yazan programı al

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

              
                if (kullaniciData != null)
                {
                    var data = new
                    {
                        Secilenprogram = selectedProgram
                    };

                     client.Update("kullanicilar/" + kullaniciId, data);
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Seçiminiz başarıyla gerçekleştirildi.');", true);

                    // Butonu tekrar tıklayamaz hale getir
                    fitnessprog1Button.Enabled = false;
                    fitnessprog2Button.Enabled = false;
                    fitnessprog3Button.Enabled = false;
                }
            }
        }


       
        protected void fitnessprog2Button_Click(object sender, EventArgs e)
{
            string selectedProgram = fitnessprog2Label.Text; // Label'de yazan programı al

            
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
                    fitnessprog1Button.Enabled = false;
                    fitnessprog2Button.Enabled = false;
                    fitnessprog3Button.Enabled = false;
                }
            }
        }

          protected void fitnessprog3Button_Click(object sender, EventArgs e)
         {
            string selectedProgram = fitnessprog3Label.Text; // Label'de yazan programı al

            
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "hrRd9DYtze5puhjZLjUuoEOfvTnCq08O7OXG5VC7",
                BasePath = "https://denememvc-6f93d-default-rtdb.firebaseio.com/"
            };

            IFirebaseClient client = new FireSharp.FirebaseClient(config);

            
            string kullaniciId = Session["KullaniciId"].ToString();

           
            FirebaseResponse responseKullanici = client.Get("kullanicilar/" + kullaniciId);

            if (responseKullanici.StatusCode == System.Net.HttpStatusCode.OK)
            {
                dynamic kullaniciData = responseKullanici.ResultAs<dynamic>();

               
                if (kullaniciData != null)
                {
                    var data = new
                    {
                        Secilenprogram = selectedProgram
                    };

                    client.Update("kullanicilar/" + kullaniciId, data);
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Seçiminiz başarıyla gerçekleştirildi.');", true);

                    // Butonu tekrar tıklayamaz hale getir
                    fitnessprog1Button.Enabled = false;
                    fitnessprog2Button.Enabled = false;
                    fitnessprog3Button.Enabled = false;
                }
            }
        }

    }
}