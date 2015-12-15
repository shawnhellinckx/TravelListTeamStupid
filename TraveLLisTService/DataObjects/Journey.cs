using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;

namespace TraveLLisTService.DataObjects
{
    public class Journey : EntityData
    {
        public Journey() {
            Categories = new List<Category>();
        }

        public string Name { get; set; }

        public DateTime? Date { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}