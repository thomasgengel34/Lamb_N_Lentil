using System;
using System.Collections.Generic;
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
        public string ReturnStatusTextToDisplay { get; set; }

        public static async Task<ListOfFoodsViewModel> MapListOfSearchedFoodsToListOfFoods(IUsdaAsync async, UsdaListofFoods listOfFoods)
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
                    if (item != null)
                    {

                        _UsdaFoodReport report = await async.FetchUsdaFoodReport(item.ndbno);

                        FoodItem foodItem = new FoodItem()
                        {
                            Name = item.name,
                            Ndbno = item.ndbno,
                            Ingredients = report.foods.First().food.ing.desc,
                            ServingSize = GetServingSize(report),
                            MakerOrFoodGroup = FetchMakerOrFoodGroup(report),
                            TotalCarbohydrate = FetchTotalCarbohydrate(report),
                        };

                        vm.FoodItems.Add(foodItem);
                    }
                }
            }
            return vm;
        }

        private static decimal FetchTotalCarbohydrate(_UsdaFoodReport report)
        {
            decimal value = 0M;

            if (report.foods.First().food.nutrients != null)
            {
                var totCarb = report.foods.First().food.nutrients.Where(i => i.nutrient_id == 205);
                if (totCarb != null)
                {
                    if (totCarb.First() != null)
                    {
                        if (totCarb.First().measures != null)
                        {
                            if (totCarb.First().measures.FirstOrDefault() != null)
                            {
                                value = totCarb.First().measures.First().value;
                            }
                        }
                    }

                }
            }
            return value;
        }


        private static string FetchMakerOrFoodGroup(_UsdaFoodReport report)
        {
            string foodGroup = report.foods.First().food.desc.fg ?? "";
            string maker = report.foods.First().food.desc.manu ?? "";
            if (foodGroup.Length > maker.Length)
            {
                return foodGroup;
            }
            else
            {
                return maker;
            }
        }

        internal static Task<ListOfFoodsViewModel> MapListOfSearchedFoodsToListOfFoodsByLeastFiveCarbohydrates(UsdaListofFoods list) => throw new NotImplementedException();

        private static string GetServingSize(_UsdaFoodReport report)
        {
            string serving = "";
            if (report.foods.First().food.nutrients.First().measures.Count() == 0)
            {
                return serving;
            }

            if (report.foods.First().food.nutrients.First().measures[0].label != null)
            {
                serving = report.foods.First().food.nutrients.First().measures[0].label;
            }
            return serving;
        }

       // Moving sorting functions  in domain and testing methods. 
        public static void SortTotalCarbohydrates(ListOfFoodsViewModel vm) => vm.FoodItems = vm.FoodItems.OrderBy(t => t.TotalCarbohydrate).ToList();
    }
}