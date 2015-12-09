using Service.Models;
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
        private ApplicationDbContext context;
        private DbSet<Journey> journeys;

        public JourneyRepository(ApplicationDbContext context) {
            //for (int i = 0; i < 10; i++) {
            //    Journey journey = new Journey();
            //    journey.JourneyId = i;
            //    journey.Name = "Journey " + i;
            //    journey.PercentageDone = 0;
            //    journeyList.Add(journey);
            //}
            this.context = context;
            journeys = context.Journeys;
        }

        public void CreateJourney(Journey journey)
        {
            //journey.createEmptyCategoryList();
            //journeyList.Add(journey);
            journeys.Add(journey);
            context.SaveChanges();
        }

        //public bool DeleteJourney(int id)
        //{
        //    Journey journey = journeyList.Find(j => j.JourneyId == id);
        //    if (journey != null)
        //    {
        //        journeyList.Remove(journey);
        //        return true;
        //    }
        //    return false;
        //}

        public IEnumerable<Journey> GetAllJourneys()
        {
            return journeys;
        }

        //public Journey GetJourney(int id)
        //{
        //    return journeyList.Find(j => j.JourneyId == id);
        //}

        public void UpdateJourney(int id, Journey journey)
        {
            //Journey to_update = journeyList.Find(j => j.JourneyId == id);
            //to_update = journey;
        }
    }
}