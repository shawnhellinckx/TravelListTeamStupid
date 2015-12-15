//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Text;
//using System.Threading.Tasks;
//using TravelListTeamStupid.Model;

//namespace TravelListTeamStupid.ServiceConnector
//{
//    public class TravelConnector
//    {
//        private string serviceUrl = "http://localhost:51037/api/journey/";
//        private HttpClient client;

//        public TravelConnector()
//        {
//            client = new HttpClient();
//            client.BaseAddress = new Uri(serviceUrl);
//            client.DefaultRequestHeaders.Accept.Clear();
//            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//        }



//        public void Delete(Travel obj)
//        {

//        }

//        public async Task Get(string id)
//        {
//            HttpResponseMessage response = await client.GetAsync(id);
//            if (response.IsSuccessStatusCode)
//            {
//                Travel Travel = await response.Content.ReadAsStreamAsync();
//                Console.WriteLine("{0}", Travel.Name);
//            }
//        }

//        public ICollection<Travel> GetAll()
//        {


//        }

//        public void Post(Travel obj)
//        {
//            throw new NotImplementedException();
//        }

//        public Travel Update(string id)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
