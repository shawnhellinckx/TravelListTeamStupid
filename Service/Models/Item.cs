using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelListTeamStupid.Model
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        String Name { get; set; }
        int Count { get; set; }
        bool Done { get; set; }
    }
}
