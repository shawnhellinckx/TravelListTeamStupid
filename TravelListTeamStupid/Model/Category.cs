using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelListTeamStupid.Model
{
    public class Category : INotifyPropertyChanged
    {
        public ObservableCollection<Item> items;

        public int Id { get; set; }
        public String Name { get; set; }

        public double Percent => GetPercentCompleted();


        private double GetPercentCompleted()
        {
            double output = ((items.Count(i => i.Done) / (double)items.Count) * 100);
            if (double.IsNaN(output))
                return 0;
            return output;
        }

        public ObservableCollection<Item> GetItems()
        {
            return items;
        }

        public int GetLastIndex()
        {
            if (items.Reverse().FirstOrDefault() == null)
                return 0;
            return items.Reverse().FirstOrDefault().Id;
        }

        public void AddItem(Item item)
        {
            items.Add(item);
            items.OrderBy(i => i.Id);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
