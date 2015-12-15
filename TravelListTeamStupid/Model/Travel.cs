using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelListTeamStupid.Model
{
    public class Travel
    {
        public Travel()
        {
            categories = new List<Category>();
        }

        public Travel(string name, DateTime date)
        {
            this.Name = name;
            this.Date = date;
            categories = new List<Category>();
        }

        [JsonProperty(PropertyName = "journeyId")]
        public string id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        public decimal PercentageDone { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "categories")]
        public List<Category> categories { get; set; }


        public List<Category> getCategories()
        {
            return categories;
        }

        public void addCategory(Category category)
        {
            categories.Add(category);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }
}
