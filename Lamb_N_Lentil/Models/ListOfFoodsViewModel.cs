using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.Domain.UsdaInformation.List;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using _UsdaFoodReport = Lamb_N_Lentil.Domain.UsdaInformation.UsdaFoodReport;
using System.Reflection;

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
                    UsdaFoodReport report = await new UsdaAsync().FetchUsdaFoodReport(item.ndbno);

                    FoodItem foodItem = new FoodItem()
                    {
                        Name = item.name,
                        Ndbno = item.ndbno,
                        Ingredients = report.foods.First().food.ing.desc,
                        ServingSize = GetServingSize(report),
                        MakerOrFoodGroup = FetchMakerOrFoodGroup(report),
                    };

                    vm.FoodItems.Add(foodItem);
                };
            }
            return vm;
        }

        private static string FetchMakerOrFoodGroup(UsdaFoodReport report)
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
            if (report.foods.First() == null) return serving;
            if (report.foods.First().food == null) return serving;
            if (report.foods.First().food.nutrients == null) return serving;
            if (report.foods.First().food.nutrients.First() == null) return serving;
            if (report.foods.First().food.nutrients.First().measures == null) return serving;
            var x = report.foods.First().food.nutrients.First().measures;
            Type type = x.GetType();
            if (type==typeof(Array))
            {
                serving= report.foods.First().food.nutrients.First().measures[0].label  ;
            }
            

            //var x1 = report;
            //var x2 = report.foods;
            //var x3 = x2.First();
            //var x4 = x3.food;
            //var x5 = x4.nutrients;
            //var x6 = x5.First();
            //var x7 = x6.measures;
            //var x8 = x7.First();
            // var x9 = x8.label;

            //   serving = report.foods.First().food.nutrients.First().measures.First().label;

            return serving;
        }

        private static string GetIngredients(string ndbno)
        {
            throw new NotImplementedException();
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