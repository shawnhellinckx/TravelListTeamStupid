using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;
using Microsoft.WindowsAzure.Mobile.Service;
using TraveLLisTService.DataObjects;
using TraveLLisTService.Models;

namespace TraveLLisTService
{
    public static class WebApiConfig
    {
        public static void Register()
        {
            // Use this class to set configuration options for your mobile service
            ConfigOptions options = new ConfigOptions();

            // Use this class to set WebAPI configuration options
            HttpConfiguration config = ServiceConfig.Initialize(new ConfigBuilder(options));

            // To display errors in the browser during development, uncomment the following
            // line. Comment it out again when you deploy your service for production use.
            // config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
            
            // Set default and null value handling to "Include" for Json Serializer
            config.Formatters.JsonFormatter.SerializerSettings.DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Include;
            config.Formatters.JsonFormatter.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Include;
            
            Database.SetInitializer(new TraveLLisTInitializer());
        }
    }

    //ClearDatabaseSchemaIfModelChanges
    //DropCreateDatabaseAlways
    public class TraveLLisTInitializer : DropCreateDatabaseAlways<TraveLLisTContext>
    {
        protected override void Seed(TraveLLisTContext context)
        {
            List<TodoItem> todoItems = new List<TodoItem>
            {
                new TodoItem { Id = Guid.NewGuid().ToString(), Text = "First item", Complete = false },
                new TodoItem { Id = Guid.NewGuid().ToString(), Text = "Second item", Complete = false },
            };

            foreach (TodoItem todoItem in todoItems)
            {
                context.Set<TodoItem>().Add(todoItem);
            }

            List<Item> ItemLijst1 = new List<Item>()
            {
                new Item { Id= Guid.NewGuid().ToString(), Name="Onderbroeken", Count=1, Total=5, Done= false },
                new Item { Id= Guid.NewGuid().ToString(), Name="T-shirt", Count=1, Total=5, Done= false },
                new Item { Id= Guid.NewGuid().ToString(), Name="Broek", Count=2, Total=2, Done= true }
            };

            foreach (Item item in ItemLijst1)
            {
                context.Set<Item>().Add(item);
            }

            List<Item> ItemLijst2 = new List<Item>()
            {
                new Item { Id= Guid.NewGuid().ToString(), Name="Tandpasta", Count=0, Total=1, Done= false },
                new Item { Id= Guid.NewGuid().ToString(), Name="Tandenborstel", Count=1, Total=1, Done= true }
            };

            foreach (Item item in ItemLijst2)
            {
                context.Set<Item>().Add(item);
            }

            List<Category> categories = new List<Category>()
            {
                new Category {Id= Guid.NewGuid().ToString(), Name="Kleren", Items=ItemLijst1 },
                new Category {Id= Guid.NewGuid().ToString(), Name="Badkamer", Items=ItemLijst2 }
            };

            foreach (Category category in categories)
            {
                context.Set<Category>().Add(category);
            }

            List<Journey> journeys = new List<Journey>() {
                new Journey { Id = Guid.NewGuid().ToString(), Name="Lisabon", Date= new DateTime(2015,02,03), Categories=categories},
            };

            foreach (Journey journey in journeys)
            {
                context.Set<Journey>().Add(journey);
            }

            base.Seed(context);
        }
    }
}

