﻿using Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelListTeamStupid.Model;

namespace Rest4API.Controllers
{
    public class JourneyController : ApiController
    {
        private IJourneyRepository repo = new JourneyRepository();

        // GET: api/Travels
        public HttpResponseMessage Get()
        {
            IEnumerable<Journey> journeys = this.repo.GetAllJourneys();
            if (journeys != null)
            {
                return Request.CreateResponse<IEnumerable<Journey>>(HttpStatusCode.OK, journeys);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        // GET: api/Travels/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Travels
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Travels/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Travels/5
        public void Delete(int id)
        {
            repo.DeleteJourney(id);
        }
    }
}