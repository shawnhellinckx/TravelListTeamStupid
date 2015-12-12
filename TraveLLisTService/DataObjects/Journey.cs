using Microsoft.WindowsAzure.Mobile.Service;
using System;

namespace TraveLLisTService.DataObjects
{
    public class Journey : EntityData
    {
        //private IList<Category> categories;

        public string Name { get; set; }
        public DateTime Date { get; set; }

        //public void CreateEmptyCategoryList() {
        //    categories = new List<Category>();
        //}

        //public IList<Category> getCategories() {
        //    return categories;
        //}
    }
}