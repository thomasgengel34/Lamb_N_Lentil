using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Lamb_N_Lentil.Domain.UsdaInformation.List
{
    public class UsdaListofFoods 
    {
        public list list { get; set; } 
    }

    public class list
    {
        public string q { get; set; }
        public int total { get; set; }
        public item[] item { get; set; }
    }

    public class item
    {
        public string name { get; set; }
        public string ndbno { get; set; }
        public decimal TotalCarbohydrate { get; set; }

        public decimal FetchTotalCarbohydrate(UsdaFoodReport report) => throw new NotImplementedException();
    }
}
