using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraveLLisTService.DataObjects
{
    public class Category : EntityData
    {
        public Category() {
            Items = new List<Item>();
        }

        public string Name { get; set; }
        public virtual ICollection<Item> Items { get; set; }

        public string JourneyId { get; set; }
        public virtual Journey journey {get; set;}
    }
}
