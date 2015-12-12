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
        public DateTime Date { get; set; }

        public void CreateEmptyCategoryList() {
            categories = new List<Category>();
        }

        public IList<Category> getCategories() {
            return categories;
        }
    }
}