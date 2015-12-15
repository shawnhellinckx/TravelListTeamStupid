﻿using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using TraveLLisTService.DataObjects;
using TraveLLisTService.Models;

namespace TraveLLisTService.Controllers
{
    public class CategoryController : TableController<Category>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            TraveLLisTContext context = new TraveLLisTContext();
            DomainManager = new EntityDomainManager<Category>(context, Request, Services);
        }

        // GET tables/Category
        [QueryableExpand("Items")]
        public IQueryable<Category> GetAllCategory()
        {
            return Query(); 
        }

        // GET tables/Category/48D68C86-6EA6-4C25-AA33-223FC9A27959
        [QueryableExpand("Items")]
        public SingleResult<Category> GetCategory(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Category/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Category> PatchCategory(string id, Delta<Category> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Category
        public async Task<IHttpActionResult> PostCategory(Category item)
        {
            Category current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Category/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteCategory(string id)
        {
             return DeleteAsync(id);
        }

    }
}