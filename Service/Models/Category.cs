using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelListTeamStupid.Model
{
    public class Category
    {
        private List<Item> items;

        public int CategoryID { get; set; }
        public String Name { get; set; }
        public double PercentCompleted { get; set; }
    }
}
