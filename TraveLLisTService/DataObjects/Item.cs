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
        string Name { get; set; }
        int Count { get; set; }
        bool Done { get; set; }
    }
}
