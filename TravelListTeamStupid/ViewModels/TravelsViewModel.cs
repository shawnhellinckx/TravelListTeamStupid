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
        public ObservableCollection<Travel> TravelsList { get; set; }

        public TravelsViewModel()
        {
            this.TravelsCollection = GetTravelList();

        }
        public ObservableCollection<Travel> TravelsCollection
        {
            get;
            private set;
        }

        public ObservableCollection<Travel> GetTravelList()
        {
            ObservableCollection<Travel> list = new ObservableCollection<Travel>();

            list.Add(new Travel() { Place = "Dardene", Date = new DateTime(2008, 3, 15), Percentage = 0.25M });
            list.Add(new Travel() { Place = "De zee", Date = new DateTime(2016, 4, 1), Percentage = 0.45M });
            list.Add(new Travel() { Place = "Italië aan het comomeer", Date = new DateTime(2016, 8, 23), Percentage = 0.75M });
            list.Add(new Travel() { Place = "Vakantie met de vrienden", Date = new DateTime(2016, 8, 23), Percentage = 0.99M });            
            list.Add(new Travel() { Place = "Ponykamp", Date = new DateTime(2016, 5, 2), Percentage = 0.00M });
            list.Add(new Travel() { Place = "Blankenberge", Date = new DateTime(2016, 7, 3), Percentage = 0.85M });
            list.Add(new Travel() { Place = "De Kempen", Date = new DateTime(2015, 12, 23), Percentage = 0.16M });
            list.Add(new Travel() { Place = "Amerika", Date = new DateTime(2015, 12, 29), Percentage = 0.69M });

            list.Add(new Travel() { Place = "Dardene", Date = new DateTime(2008, 3, 15), Percentage = 0.25M });
            list.Add(new Travel() { Place = "De zee", Date = new DateTime(2016, 4, 1), Percentage = 0.45M });
            list.Add(new Travel() { Place = "Italië aan het comomeer", Date = new DateTime(2016, 8, 23), Percentage = 0.75M });
            list.Add(new Travel() { Place = "Vakantie met de vrienden", Date = new DateTime(2016, 8, 23), Percentage = 0.99M });
            list.Add(new Travel() { Place = "Ponykamp", Date = new DateTime(2016, 5, 2), Percentage = 0.00M });
            list.Add(new Travel() { Place = "Blankenberge", Date = new DateTime(2016, 7, 3), Percentage = 0.85M });
            list.Add(new Travel() { Place = "De Kempen", Date = new DateTime(2015, 12, 23), Percentage = 0.16M });
            list.Add(new Travel() { Place = "Amerika", Date = new DateTime(2015, 12, 29), Percentage = 0.69M });

            list.Add(new Travel() { Place = "Dardene", Date = new DateTime(2008, 3, 15), Percentage = 0.25M });
            list.Add(new Travel() { Place = "De zee", Date = new DateTime(2016, 4, 1), Percentage = 0.45M });
            list.Add(new Travel() { Place = "Italië aan het comomeer", Date = new DateTime(2016, 8, 23), Percentage = 0.75M });
            list.Add(new Travel() { Place = "Vakantie met de vrienden", Date = new DateTime(2016, 8, 23), Percentage = 0.99M });
            list.Add(new Travel() { Place = "Ponykamp", Date = new DateTime(2016, 5, 2), Percentage = 0.00M });
            list.Add(new Travel() { Place = "Blankenberge", Date = new DateTime(2016, 7, 3), Percentage = 0.85M });
            list.Add(new Travel() { Place = "De Kempen", Date = new DateTime(2015, 12, 23), Percentage = 0.16M });
            list.Add(new Travel() { Place = "Amerika", Date = new DateTime(2015, 12, 29), Percentage = 0.69M });

            return list;
        }


    }

    
}
