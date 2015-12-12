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
        //private List<Item> items;

        //public int CategoryID { get; set; }
        public string Name { get; set; }
        //public double PercentCompleted { get; set; }
    }
}
