using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelListTeamStupid.Model;

namespace TravelListTeamStupid.ViewModels
{
    public class CategoriesViewModel
    {

        public static ObservableCollection<Category> Categories { set; get; }

        public CategoriesViewModel()
        {
            Categories = new ObservableCollection<Category>();
        }

        public static ObservableCollection<Category> GetAllCategories()
        {
            return Categories;
        }

        public void AddCategorie(Category c)
        {
            Categories.Add(c);
        }

        public int GetLastIndex()
        {
            if (Categories.Reverse().FirstOrDefault() == null)
                return 0;
            return Categories.Reverse().FirstOrDefault().Id;
        }

        public void AddCategories()
        {
            //DB request sturen
            ObservableCollection<Item> itemsKeuken = new ObservableCollection<Item>();
            itemsKeuken.Add(new Item() { Id = 1, Name = "Potten en pannetjes", Count = 5, Done = true });
            itemsKeuken.Add(new Item() { Id = 2, Name = "Spatels", Count = 1, Done = false });

            Categories.Add(new Category() { Id = 1, Name = "Keuken", items = itemsKeuken });
            Categories.Add(new Category() { Id = 2, Name = "Badkamer", items = new ObservableCollection<Item>() });
            Categories.Add(new Category() { Id = 3, Name = "Documenten", items = new ObservableCollection<Item>() });
            Categories.Add(new Category() { Id = 4, Name = "Medicijnen", items = new ObservableCollection<Item>() });
            Categories.Add(new Category() { Id = 5, Name = "Slaapkamer", items = new ObservableCollection<Item>() });
            Categories.Add(new Category() { Id = 6, Name = "Andere", items = new ObservableCollection<Item>() });
        }
    }
}
