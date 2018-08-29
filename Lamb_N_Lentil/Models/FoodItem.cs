using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lamb_N_Lentil.UI.Models
{

    public class FoodItem
    {
        public string Name { get; set; }
        public string Ndbno { get; set; }
        public string Ingredients { get; set; }

        [Display(Name = "Serving Size")]
        public string ServingSize { get; set; }

        [Display(Name = "Maker Or Food Group")]
        public string MakerOrFoodGroup { get; set; }

        [Display(Name = "Total Carbohydrate")]
        public decimal TotalCarbohydrate { get; set; }


        public static List<FoodItem> BuildIngredientList(List<FoodItem> list, string searchString)
        {
            int length = Convert.ToInt32(searchString) - 1000;
            list.Clear();
            for (int i = 0; i < length; i++)
            {
                list.Add(new FoodItem { Ndbno = i.ToString() });
            }
            return list;
        }
    }
}