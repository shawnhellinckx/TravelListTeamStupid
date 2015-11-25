using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelListTeamStupid.Model;

namespace Service.Repositories
{
    public interface IJourneyRepository
    {
        Journey CreateJourney(Journey journey);
        IEnumerable<Journey> GetAllJourneys();
        Journey GetJourney(int id);
        Journey UpdateJourney(int id, Journey journey);
        Boolean DeleteJourney(int id);
    }
}