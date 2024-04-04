using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;

namespace FirebaseDatabaseViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Firebase projenizden aldığınız config bilgilerini burada kullanın
            string authSecret = "hrRd9DYtze5puhjZLjUuoEOfvTnCq08O7OXG5VC7";
            string basePath = "https://denememvc-6f93d-default-rtdb.firebaseio.com/";

            IFirebaseClient client;
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = authSecret,
                BasePath = basePath
            };

            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                FirebaseResponse response = client.Get("admin");

                if (response != null && response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    dynamic data = response.ResultAs<dynamic>();
                    if (data != null)
                    {
                        string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
                        Console.WriteLine(jsonData);
                    }
                }
                else
                {
                    Console.WriteLine("Firebase veri alımı başarısız!");
                }
            }
            else
            {
                Console.WriteLine("Firebase bağlantısı başarısız!");
            }

            Console.ReadKey();
        }
    }
}
