﻿using FireSharp.Config;
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
    public partial class kiloalma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
                        FirebaseResponse kiloalmaprog1Response = client.Get("antrenor/" + antrenorItem.Name + "/kiloalmaprog1");

                        if (kiloalmaprog1Response != null && kiloalmaprog1Response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            dynamic kiloalmaprog1Data = kiloalmaprog1Response.ResultAs<dynamic>();

                            if (kiloalmaprog1Data != null)
                            {
                                
                                kiloalmaprog1Label.Text = kiloalmaprog1Data;
                                break; 
                            }
                        }
                    }

                    // kiloalmaprog2
                    foreach (var antrenorItem in antrenorData)
                    {
                        FirebaseResponse kiloalmaprog2Response = client.Get("antrenor/" + antrenorItem.Name + "/kiloalmaprog2");

                        if (kiloalmaprog2Response != null && kiloalmaprog2Response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            dynamic kiloalmaprog2Data = kiloalmaprog2Response.ResultAs<dynamic>();

                            if (kiloalmaprog2Data != null)
                            {
                                kiloalmaprog2Label.Text = kiloalmaprog2Data;
                                break;
                            }
                        }
                    }

                    // kiloalmaprog3
                    foreach (var antrenorItem in antrenorData)
                    {
                        FirebaseResponse kiloalmaprog3Response = client.Get("antrenor/" + antrenorItem.Name + "/kiloalmaprog3");

                        if (kiloalmaprog3Response != null && kiloalmaprog3Response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            dynamic kiloalmaprog3Data = kiloalmaprog3Response.ResultAs<dynamic>();

                            if (kiloalmaprog3Data != null)
                            {
                                kiloalmaprog3Label.Text = kiloalmaprog3Data;
                                break;
                            }
                        }
                    }
                }
            }
        }

        protected void kiloalmaprog1Button_Click(object sender, EventArgs e)
        {
            string selectedProgram = kiloalmaprog1Label.Text; // Label'de yazan programı al

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
                    kiloalmaprog1Button.Enabled = false;
                    kiloalmaprog2Button.Enabled = false;
                    kiloalmaprog3Button.Enabled = false;
                }
            }
        }

        protected void kiloalmaprog2Button_Click(object sender, EventArgs e)
        {
            string selectedProgram = kiloalmaprog2Label.Text; // Label'de yazan programı al

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
                    kiloalmaprog1Button.Enabled = false;
                    kiloalmaprog2Button.Enabled = false;
                    kiloalmaprog3Button.Enabled = false;
                }
            }
        }

        protected void kiloalmaprog3Button_Click(object sender, EventArgs e)
        {
            string selectedProgram = kiloalmaprog3Label.Text; // Label'de yazan programı al

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
                    kiloalmaprog1Button.Enabled = false;
                    kiloalmaprog2Button.Enabled = false;
                    kiloalmaprog3Button.Enabled = false;
                }
            }
        }
    }
}