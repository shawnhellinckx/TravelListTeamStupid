using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;

namespace TraveLLisTService.DataObjects
{
    public class Journey : EntityData
    {
        public Journey() {
            Categories = new List<TodoItem>();
        }

        public string Name { get; set; }
        public DateTime? Date { get; set; }

        public virtual ICollection<TodoItem> Categories { get; set; }
    }
}