﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TraveLLisTService.DataObjects;

namespace TraveLLisTService.Repositories
{
    public interface IJourneyRepository
    {
        void CreateJourney(Journey journey);
        IEnumerable<Journey> GetAllJourneys();
        Journey GetJourney(int id);
        void UpdateJourney(int id, Journey journey);
        Boolean DeleteJourney(int id);
    }
}