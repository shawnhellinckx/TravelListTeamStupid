using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TravelListTeamStupid.Model;

namespace Service.Repositories
{
    public class JourneyRepository : IJourneyRepository
    {
        private List<Journey> journeyList = new List<Journey>();

        public JourneyRepository() {
            for (int i = 0; i < 10; i++) {
                Journey journey = new Journey();
                journey.JourneyId = i;
                journey.Name = "Journey " + i;
                journey.PercentageDone = 0;
                journeyList.Add(journey);
            }
        }

        public Journey CreateJourney(Journey journey)
        {
            throw new NotImplementedException();
        }

        public bool DeleteJourney(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Journey> GetAllJourneys()
        {
            return journeyList;
        }

        public Journey GetJourney(int id)
        {
            return journeyList.Find(j => j.JourneyId == id);
        }

        public Journey UpdateJourney(int id, Journey journey)
        {
            throw new NotImplementedException();
        }
    }
}