using Service.Models;
using Service.Repositories;
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
        private IJourneyRepository repo = new JourneyRepository(ApplicationDbContext.Create());

        // GET: api/Journey
        public HttpResponseMessage Get()
        {
            IEnumerable<Journey> journeys = this.repo.GetAllJourneys();
            if (journeys != null)
            {
                return Request.CreateResponse<IEnumerable<Journey>>(HttpStatusCode.OK, journeys);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        // GET: api/Journey/5
        //public Journey Get(int id)
        //{
        //    return this.repo.GetJourney(id);
        //}

        // POST: api/Journey
        public void Post([FromBody]Journey value)
        {
            this.repo.CreateJourney(value);
        }

        // PUT: api/Journey/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Journey/5
        //public void Delete(int id)
        //{
        //    repo.DeleteJourney(id);
        //}
    }
}