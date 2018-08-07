using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.Domain.UsdaInformation.List;
using _UsdaFoodReport = Lamb_N_Lentil.Domain.UsdaInformation.UsdaFoodReport;

namespace Lamb_N_Lentil.UI.Models
{
    public class ListOfFoodsViewModel
    {
        public string Query { get; set; }
        public List<FoodItem> FoodItems { get; set; }
        public int Total { get; set; }

        public static async Task<ListOfFoodsViewModel> MapListOfSearchedFoodsToListOfFoods(UsdaListofFoods listOfFoods)
        {
            ListOfFoodsViewModel vm = new ListOfFoodsViewModel();
            if (listOfFoods.list != null)
            {
                var list = listOfFoods.list;
                vm.Query = listOfFoods.list.q;

                vm.Total = list.total;
                vm.FoodItems = new List<FoodItem>();

                foreach (var item in list.item)
                {
                           _UsdaFoodReport report = await new UsdaAsync().FetchUsdaFoodReport(item.ndbno);

                           FoodItem foodItem = new FoodItem()
                           {
                               Name = item.name,
                                Ndbno = item.ndbno,
                              Ingredients = report.foods.First().food.ing.desc,
                                ServingSize = GetServingSize(report),
                               MakerOrFoodGroup = FetchMakerOrFoodGroup(report),
                            };

                          vm.FoodItems.Add(foodItem);
                }
            }
            return vm;
        }

        private static string FetchMakerOrFoodGroup(_UsdaFoodReport report)
        {
            string foodGroup = report.foods.First().food.desc.fg ?? "";
            string maker = report.foods.First().food.desc.manu ?? "";
            if (foodGroup.Length > maker.Length)
            {
                return foodGroup;
            }
            else return maker;
        }

        private static string GetServingSize(_UsdaFoodReport report)
        {
            string serving = "";
            if (report.foods.First().food.nutrients.First().measures.Count()==0)
            {
                var foo = report.foods.First().food.nutrients.First().measures;
                return serving;
            }

            if (report.foods.First().food.nutrients.First().measures[0].label != null)
            {
                serving = report.foods.First().food.nutrients.First().measures[0].label;
            }
            return serving;
        }
    }


    public class FoodItem
    {
        public string Name { get; set; }
        public string Ndbno { get; set; }
        public string Ingredients { get; set; }

        [Display(Name = "Serving Size")]
        public string ServingSize { get; set; }

        [Display(Name = "Maker Or Food Group")]
        public string MakerOrFoodGroup { get; set; }
    }
}