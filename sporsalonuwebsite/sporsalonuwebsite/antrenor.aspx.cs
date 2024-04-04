using FireSharp.Response;
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
    public partial class antrenor : System.Web.UI.Page
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
            if (!IsPostBack)
            {
                if (Session["Eposta"] != null)
                {
                    string eposta = Session["Eposta"].ToString();
                    string İsim = Session["İsim"].ToString();
                    string telefon = Session["TelefonNo"].ToString();
                    string dogumTarihi = Session["dogumtarihi"].ToString();
                    String ilgialani = Session["ilgialani"].ToString();

                   

                    lblAdSoyad.Text = İsim;
                    lblEposta.Text = eposta;
                    lblTelefon.Text = telefon;
                    lblDogumTarihi.Text = dogumTarihi;
                    lblilgialani.Text = ilgialani;
                }
            }

        }
        protected void IconCommand(object sender, CommandEventArgs e)
        {
            string command = e.CommandArgument.ToString();

            switch (command)
            {
                case "user":
                    
                    Response.Redirect("antrenor.aspx");
                    break;
                case "book":
                  

                    break;
                case "envelope":

                    break;
                case "arrow-up":
                    Response.Redirect("eslesme.aspx");

                    break;
                case "cog":
                    Response.Redirect("giris.aspx");


                    break;
                
                default:
                    break;
            }
        }
        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["KullaniciId"] != null)
                {
                    string kullaniciId = Session["KullaniciId"].ToString();

                    
                    var data = new
                    {
                        İsim = txtAd.Text,
                        Soyisim = txtSoyad.Text,
                        Eposta = txtEposta.Text,
                        TelefonNo = txtTelefon.Text,
                        Dogumtarihi = txtDogumTarihi.Text,
                       
                        
                    };

                   
                    var updateData = new Dictionary<string, object>();
                    foreach (var property in data.GetType().GetProperties())
                    {
                        updateData[property.Name] = property.GetValue(data);
                    }

                    // Belirtilen yoldaki veriyi sadece belirli alanlarla güncelleyin
                    FirebaseResponse setResponse = client.Update("antrenor/" + kullaniciId, updateData);

                    if (setResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        
                       // Response.Redirect("kayit.aspx");
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
    
