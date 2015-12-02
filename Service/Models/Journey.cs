using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelListTeamStupid.Model
{
    public class Journey
    {
        private IList<Category> categories;

        [Key]
        public int JourneyId { get; set; }
        public String Name { get; set; }
        public double PercentageDone { get; set; }

        public void createEmptyCategoryList() {
            categories = new List<Category>();
        }
    }
}
