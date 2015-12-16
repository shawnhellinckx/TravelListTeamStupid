using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using TravelListTeamStupid.Model;

namespace TravelListTeamStupid.ViewModels
{


    public class TravelsViewModel
    {

        const string apiUrl = @"http://localhost:51037/api/journey";

        public TravelsViewModel()
        {
            if(TravelsCollection == null)
            TravelsCollection = new ObservableCollection<Travel>();
           
        }
        public static ObservableCollection<Travel> TravelsCollection { set; get; }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        public void LoadData() {
            if (!this.IsDataLoaded)
            {
                TravelsCollection.Clear();
                TravelsCollection.Add(new Travel() {Name = "Wacht even"});
                WebClient client = new WebClient();
                client.Headers["Accept"] = "application/json";
                client.DownloadStringCompleted += Client_DownloadStringCompleted;
                client.DownloadStringAsync(new Uri(apiUrl));
            }
        }

        private void Client_DownloadStringCompleted(Object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                TravelsCollection.Clear();
                if (e.Result != null)
                {
                    var travels = JsonConvert.DeserializeObject<Travel[]>(e.Result);
                    foreach (Travel travel in travels)
                    {
                        TravelsCollection.Add(new Travel()
                        {
                            Id = travel.Id,
                            Name = travel.Name,
                            Date = travel.Date,
                            categories = travel.categories
                        });
                    }
                    this.IsDataLoaded = true;
                }
            }
            catch (Exception ex)
            {
                TravelsCollection.Add(new Travel()
                {
                    Name = "An error has occured"
                });
            }
        }

        //public static ObservableCollection<Travel> GetTravelList()
        //{

        //    //list.Add(new Travel() { Name = "Dardene", Date = new DateTime(2008, 3, 15), PercentageDone = 0.25M });
        //    //list.Add(new Travel() { Name = "De zee", Date = new DateTime(2016, 4, 1), PercentageDone = 0.45M });
        //    //list.Add(new Travel() { Name = "Italië aan het comomeer", Date = new DateTime(2016, 8, 23), PercentageDone = 0.75M });
        //    //list.Add(new Travel() { Name = "Vakantie met de vrienden", Date = new DateTime(2016, 8, 23), PercentageDone = 0.99M });            
        //    //list.Add(new Travel() { Name = "Ponykamp", Date = new DateTime(2016, 5, 2), PercentageDone = 0.00M });
        //    //list.Add(new Travel() { Name = "Blankenberge", Date = new DateTime(2016, 7, 3), PercentageDone = 0.85M });
        //    //list.Add(new Travel() { Name = "De Kempen", Date = new DateTime(2015, 12, 23), PercentageDone = 0.16M });
        //    //list.Add(new Travel() { Name = "Amerika", Date = new DateTime(2015, 12, 29), PercentageDone = 0.69M });

        //    //list.Add(new Travel() { Name = "Dardene", Date = new DateTime(2008, 3, 15), PercentageDone = 0.25M });
        //    //list.Add(new Travel() { Name = "De zee", Date = new DateTime(2016, 4, 1), PercentageDone = 0.45M });
        //    //list.Add(new Travel() { Name = "Italië aan het comomeer", Date = new DateTime(2016, 8, 23), PercentageDone = 0.75M });
        //    //list.Add(new Travel() { Name = "Vakantie met de vrienden", Date = new DateTime(2016, 8, 23), PercentageDone = 0.99M });
        //    //list.Add(new Travel() { Name = "Ponykamp", Date = new DateTime(2016, 5, 2), PercentageDone = 0.00M });
        //    //list.Add(new Travel() { Name = "Blankenberge", Date = new DateTime(2016, 7, 3), PercentageDone = 0.85M });
        //    //list.Add(new Travel() { Name = "De Kempen", Date = new DateTime(2015, 12, 23), PercentageDone = 0.16M });
        //    //list.Add(new Travel() { Name = "Amerika", Date = new DateTime(2015, 12, 29), PercentageDone = 0.69M });

        //    //list.Add(new Travel() { Name = "Dardene", Date = new DateTime(2008, 3, 15), PercentageDone = 0.25M });
        //    //list.Add(new Travel() { Name = "De zee", Date = new DateTime(2016, 4, 1), PercentageDone = 0.45M });
        //    //list.Add(new Travel() { Name = "Italië aan het comomeer", Date = new DateTime(2016, 8, 23), PercentageDone = 0.75M });
        //    //list.Add(new Travel() { Name = "Vakantie met de vrienden", Date = new DateTime(2016, 8, 23), PercentageDone = 0.99M });
        //    //list.Add(new Travel() { Name = "Ponykamp", Date = new DateTime(2016, 5, 2), PercentageDone = 0.00M });


        //    return TravelsCollection;
        //}

        public ObservableCollection<Travel> GetTravels()
        {
            //LoadData();
            //return TravelsCollection;

            TravelsCollection.Add(new Travel() { Name = "Blankenberge", Date = new DateTime(2016, 7, 3), PercentageDone = 0.85M });
            TravelsCollection.Add(new Travel() { Name = "De Kempen", Date = new DateTime(2015, 12, 23), PercentageDone = 0.16M });
            TravelsCollection.Add(new Travel() { Name = "Amerika", Date = new DateTime(2015, 12, 29), PercentageDone = 0.69M });
            return TravelsCollection;
        }

        public void AddTravel(Travel travel)
        {
            TravelsCollection.Add(travel);
            //AddData(travel);
        }

        public void AddData(Travel travel) {
            WebClient webclient = new WebClient();
            //Please replace your webservice url here                                                  
            Uri uristring = new Uri("http://localhost:51037/api/journey"); 
            webclient.Headers["ContentType"] = "application/json";

            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Travel));
            ser.WriteObject(stream1, travel);
            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);

            string JsonStringParams = sr.ReadToEnd();
            webclient.UploadStringCompleted += wc_UploadStringCompleted;
            //Post data like this                                                                           
            webclient.UploadStringAsync(uristring, "POST", JsonStringParams); 
        }

        private void wc_UploadStringCompleted(object sender, UploadStringCompletedEventArgs e)
        {
            try
            {

                if (e.Result != null)
                {
                    string responce = e.Result.ToString();
                }
            }
            catch
            {
            }
        }

    }


}
