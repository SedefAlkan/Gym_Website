using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FireSharp.Response;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.IO;

namespace yazlab10
{

    public partial class WebForm2 : System.Web.UI.Page
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
            {
                if (!IsPostBack)
                {
                    if (Session["Eposta"] != null)
                    {
                        string eposta = Session["Eposta"].ToString();
                        string İsim = Session["İsim"].ToString();
                        string telefon = Session["TelefonNo"].ToString();
                        string dogumTarihi = Session["Dogumtarihi"].ToString();
                        string kilo = Session["Kilo"].ToString();
                        string BasvuruSebebi = Session["BasvuruSebebi"].ToString();


                        // Profil kartını doldurma

                        lblAdSoyad.Text = İsim;
                        lblEposta.Text = eposta;
                        lblTelefon.Text = telefon;
                        lblDogumTarihi.Text = dogumTarihi;
                        lblkilo.Text = kilo;
                        lblbasvuru.Text = BasvuruSebebi;
                    }
                }
            }
        }
        protected void IconCommand(object sender, CommandEventArgs e)
        {
            string command = e.CommandArgument.ToString();
            string BasvuruSebebi = Session["BasvuruSebebi"].ToString();

            switch (command)
            {
                case "user":
                    // Ev simgesine tıklandığında yapılacak işlemler
                    Response.Redirect("WebForm2.aspx");
                    break;
                case "heartbeat":
                    // Heartbeat simgesine tıklandığında yapılacak işlemler
                    if (BasvuruSebebi == "Kilo Alma")
                    {
                        Response.Redirect("kiloalma.aspx");
                    }
                    else if (BasvuruSebebi == "Kilo Verme")
                    {
                        Response.Redirect("egzersizprog.aspx");
                    }
                    else if (BasvuruSebebi == "Fitness")
                    {
                        Response.Redirect("fitness.aspx");
                    }

                    break;
                case "envelope":

                    break;
                case "cutlery":

                    break;
                case "cog":

                    Response.Redirect("giris.aspx");

                    break;
                // Diğer durumlar için gereken işlemler burada eklenebilir
                default:
                    break;
            }
        }

        // ... (Önceki kodunuz)
        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["KullaniciId"] != null)
                {
                    string kullaniciId = Session["KullaniciId"].ToString();

                    // Güncellenecek verinin yalnızca belirli alanlarını içeren yeni bir obje oluşturun
                    var data = new
                    {
                        İsim = txtAd.Text,
                        Soyisim = txtSoyad.Text,
                        Eposta = txtEposta.Text,
                        TelefonNo = txtTelefon.Text,
                        Dogumtarihi = txtDogumTarihi.Text,
                        Kilo=txtkilo.Text
                        
                    };

                    var updateData = new Dictionary<string, object>();
                    foreach (var property in data.GetType().GetProperties())
                    {
                        updateData[property.Name] = property.GetValue(data);
                    }

                    
                    FirebaseResponse setResponse = client.Update("kullanicilar/" + kullaniciId, updateData);

                    if (setResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                       
                        //Response.Redirect("kayit.aspx");
                    }
                    else
                    {
                        
                      

                    }
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                
            }
        }


    }
}




