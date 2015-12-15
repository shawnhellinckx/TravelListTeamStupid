using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelListTeamStupid.Model;

namespace TravelListTeamStupid.ViewModels
{


    public class TravelsViewModel
    {

        public TravelsViewModel()
        {
            if(TravelsCollection == null)
            TravelsCollection = new ObservableCollection<Travel>();
           
        }
        public static ObservableCollection<Travel> TravelsCollection { set; get; }


        public static ObservableCollection<Travel> GetTravelList()
        {

            //list.Add(new Travel() { Name = "Dardene", Date = new DateTime(2008, 3, 15), PercentageDone = 0.25M });
            //list.Add(new Travel() { Name = "De zee", Date = new DateTime(2016, 4, 1), PercentageDone = 0.45M });
            //list.Add(new Travel() { Name = "Italië aan het comomeer", Date = new DateTime(2016, 8, 23), PercentageDone = 0.75M });
            //list.Add(new Travel() { Name = "Vakantie met de vrienden", Date = new DateTime(2016, 8, 23), PercentageDone = 0.99M });            
            //list.Add(new Travel() { Name = "Ponykamp", Date = new DateTime(2016, 5, 2), PercentageDone = 0.00M });
            //list.Add(new Travel() { Name = "Blankenberge", Date = new DateTime(2016, 7, 3), PercentageDone = 0.85M });
            //list.Add(new Travel() { Name = "De Kempen", Date = new DateTime(2015, 12, 23), PercentageDone = 0.16M });
            //list.Add(new Travel() { Name = "Amerika", Date = new DateTime(2015, 12, 29), PercentageDone = 0.69M });

            //list.Add(new Travel() { Name = "Dardene", Date = new DateTime(2008, 3, 15), PercentageDone = 0.25M });
            //list.Add(new Travel() { Name = "De zee", Date = new DateTime(2016, 4, 1), PercentageDone = 0.45M });
            //list.Add(new Travel() { Name = "Italië aan het comomeer", Date = new DateTime(2016, 8, 23), PercentageDone = 0.75M });
            //list.Add(new Travel() { Name = "Vakantie met de vrienden", Date = new DateTime(2016, 8, 23), PercentageDone = 0.99M });
            //list.Add(new Travel() { Name = "Ponykamp", Date = new DateTime(2016, 5, 2), PercentageDone = 0.00M });
            //list.Add(new Travel() { Name = "Blankenberge", Date = new DateTime(2016, 7, 3), PercentageDone = 0.85M });
            //list.Add(new Travel() { Name = "De Kempen", Date = new DateTime(2015, 12, 23), PercentageDone = 0.16M });
            //list.Add(new Travel() { Name = "Amerika", Date = new DateTime(2015, 12, 29), PercentageDone = 0.69M });

            //list.Add(new Travel() { Name = "Dardene", Date = new DateTime(2008, 3, 15), PercentageDone = 0.25M });
            //list.Add(new Travel() { Name = "De zee", Date = new DateTime(2016, 4, 1), PercentageDone = 0.45M });
            //list.Add(new Travel() { Name = "Italië aan het comomeer", Date = new DateTime(2016, 8, 23), PercentageDone = 0.75M });
            //list.Add(new Travel() { Name = "Vakantie met de vrienden", Date = new DateTime(2016, 8, 23), PercentageDone = 0.99M });
            //list.Add(new Travel() { Name = "Ponykamp", Date = new DateTime(2016, 5, 2), PercentageDone = 0.00M });


            return TravelsCollection;
        }

        public static void AddAll()
        {
            TravelsCollection.Add(new Travel() { Name = "Blankenberge", Date = new DateTime(2016, 7, 3), PercentageDone = 0.85M });
            TravelsCollection.Add(new Travel() { Name = "De Kempen", Date = new DateTime(2015, 12, 23), PercentageDone = 0.16M });
            TravelsCollection.Add(new Travel() { Name = "Amerika", Date = new DateTime(2015, 12, 29), PercentageDone = 0.69M });
        }

        public void AddTravel(Travel travel)
        {
            TravelsCollection.Add(travel);
        }

    }


}
