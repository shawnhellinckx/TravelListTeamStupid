using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using TraveLLisTService.DataObjects;
using TraveLLisTService.Models;

namespace TraveLLisTService.Controllers
{
    public class JourneyController : TableController<Journey>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            TraveLLisTContext context = new TraveLLisTContext();
            DomainManager = new EntityDomainManager<Journey>(context, Request, Services);
        }

        // GET tables/TodoItem
        public IQueryable<Journey> GetAllJourneys()
        {
            return Query();
        }

        // GET tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Journey> GetJourney(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Journey> PatchJourney(string id, Delta<Journey> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/TodoItem
        public async Task<IHttpActionResult> PostJourney(Journey journey)
        {
            Journey current = await InsertAsync(journey);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteTodoItem(string id)
        {
            return DeleteAsync(id);
        }
    }
}