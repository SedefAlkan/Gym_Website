using System;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Collections.Generic;

namespace yazlab10
{
    public partial class eslesme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "hrRd9DYtze5puhjZLjUuoEOfvTnCq08O7OXG5VC7",
                BasePath = "https://denememvc-6f93d-default-rtdb.firebaseio.com/"
            };

            IFirebaseClient client = new FireSharp.FirebaseClient(config);

            if (Session["ilgialani"] != null)
            {
                string ilgialani = Session["ilgialani"].ToString();
                FirebaseResponse responseKullanicilar = client.Get("kullanicilar");

                if (responseKullanicilar != null && responseKullanicilar.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    dynamic kullanicilar = responseKullanicilar.ResultAs<Newtonsoft.Json.Linq.JObject>();

                    List<string> eslesenDanisanlar = new List<string>(); // Eşleşen kullanıcıların İsim ve Soyisim bilgilerini tutacak koleksiyon

                    foreach (var kullanici in kullanicilar)
                    {
                        string kullaniciBasvuruSebebi = kullanici.Value["BasvuruSebebi"];
                        string kullaniciIsim = kullanici.Value["İsim"];
                        string kullaniciSoyisim = kullanici.Value["Soyisim"];
                        string kullaniciKullaniciId = kullanici.Value["KullaniciId"];

                        if (!string.IsNullOrEmpty(kullaniciBasvuruSebebi) && kullaniciBasvuruSebebi.Equals(ilgialani, StringComparison.OrdinalIgnoreCase))
                        {
                            // Eşleşen kullanıcıların isim ve soyisimlerini eslesenDanisanlar listesine ekle
                            string danisanIsimSoyisim = kullaniciIsim + " " + kullaniciSoyisim;
                            eslesenDanisanlar.Add(danisanIsimSoyisim);
                            Label2.Text += kullaniciIsim + " " + kullaniciSoyisim + "<br/>";

                            // Kullanıcı ID'sine sahip düğümün altına "Antrenörü" anahtarı ekle ve değeri Session'da kayıtlı olan isim ve soyisim olsun
                            if (kullanici.Value["Antrenörü"] == null)
                            {
                                var antrenorData = new
                                {
                                    Antrenörü = Session["İsim"].ToString() + " " + Session["Soyisim"].ToString()
                                };
                                client.Update("kullanicilar/" + kullaniciKullaniciId, antrenorData);
                            }
                        }
                    }

                    // Firebase veritabanına danışanlar listesini kaydet
                    if (Session["KullaniciId"] != null)
                    {
                        string kullaniciId = Session["KullaniciId"].ToString();
                        FirebaseResponse responseAntrenor = client.Get("antrenor");

                        if (responseAntrenor != null && responseAntrenor.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            dynamic antrenor = responseAntrenor.ResultAs<Newtonsoft.Json.Linq.JObject>();

                            foreach (var antrenorItem in antrenor)
                            {
                                string antrenorKullaniciId = antrenorItem.Value["KullaniciId"]; // Alt düğümün adı, yani KullaniciId

                                if (antrenorKullaniciId == kullaniciId)
                                {
                                    var danisanData = new
                                    {
                                        Danısanları = eslesenDanisanlar
                                    };

                                    client.Update("antrenor/" + antrenorKullaniciId, danisanData);
                                }
                            }
                        }
                    }
                    if (eslesenDanisanlar.Count > 0)
                    {
                       
                        Label1.Text = "Danışanlarınınız:<br />";
                        string secilenProgramlar = ""; // Kullanıcıların Secilenprogram bilgilerini biriktireceğimiz değişken

                       
                        foreach (var kullanici in kullanicilar)
                        {
                            string kullaniciIsim = kullanici.Value["İsim"];
                            string kullaniciSoyisim = kullanici.Value["Soyisim"];
                            string kullaniciSecilenProgram = kullanici.Value["Secilenprogram"];

                            
                            if (Label2.Text.Contains(kullaniciIsim) && Label2.Text.Contains(kullaniciSoyisim))
                            {
                                if (!string.IsNullOrEmpty(kullaniciSecilenProgram))
                                {
                                    
                                    secilenProgramlar += $"{kullaniciIsim} {kullaniciSoyisim} <br /> {kullaniciSecilenProgram}<br /><br />";
                                }
                            }
                        }

                        
                        lblEgzersizProgramlari.Text = secilenProgramlar;
                    }


                }

                    else
                    {
                        
                        Label1.Text = "Kullanicilar düğümüne erişilemedi.";
                    }
                }
                else
                {
                   
                    Label1.Text = "ilgialani değeri bulunamadı.";
                }
            }

        }
    }

