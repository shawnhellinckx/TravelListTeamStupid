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
            this.context = context;
            journeys = context.Journeys;
        }

        public void CreateJourney(Journey journey)
        {
            journeys.Add(journey);
            context.SaveChanges();
        }

        public bool DeleteJourney(int id)
        {
            Journey journey = journeys.FirstOrDefault(j => j.JourneyId == id);
            if (journey != null)
            {
                journeys.Remove(journey);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Journey> GetAllJourneys()
        {
            return journeys;
        }

        public Journey GetJourney(int id)
        {
            return journeys.FirstOrDefault(j => j.JourneyId == id);
        }

        public void UpdateJourney(int id, Journey journey)
        {
            Journey to_update = journeys.FirstOrDefault(j => j.JourneyId == id);
            to_update = journey;
            context.SaveChanges();
        }
    }
}