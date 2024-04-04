using FireSharp.Config;
using FireSharp.Interfaces;
using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace yazlab10.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string authSecret = "hrRd9DYtze5puhjZLjUuoEOfvTnCq08O7OXG5VC7";
            string basePath = "https://denememvc-6f93d-default-rtdb.firebaseio.com/";
            string senderAppName = "denememvc";
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
                    Name = "test",
                    Mobile = "1234"
                };
                var response = client.Push("antrenor/", data);
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}