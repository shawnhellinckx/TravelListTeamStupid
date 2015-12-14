using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraveLLisTService.DataObjects
{
    public class Item : EntityData
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public int Total { get; set; }
        public bool Done { get; set; }
    }
}
