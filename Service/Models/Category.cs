using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelListTeamStupid.Model
{
    public class Category
    {
        private List<Item> items;
        String Name { get; set; }
        double PercentCompleted { get; set; }
    }
}
