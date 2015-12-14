namespace Service.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TravelListTeamStupid.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<Service.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Service.Models.ApplicationDbContext";
        }

        protected override void Seed(Service.Models.ApplicationDbContext context)
        {
            IList<Journey> journeyList = new List<Journey>();

            for (int i = 0; i < 10; i++)
            {
                Journey journey = new Journey();
                journey.JourneyId = i;
                journey.Name = "Journey " + i;
                journeyList.Add(journey);
            }

            foreach (Journey journey in journeyList)
                context.Journeys.Add(journey);

            context.SaveChanges();

            base.Seed(context);
        }
  
    }
}
