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

        }
        public Travel(string name, DateTime date)
        {
            this.Name = name;
            this.Date = date;
            
        }
        private List<Category> categories;

        public string Name { get; set; }
        public decimal PercentageDone { get; set; }
        public DateTime Date { get; set; }
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
