using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.Domain.UsdaInformation.List;
using Lamb_N_Lentil.UI.Models;

namespace Lamb_N_Lentil.Tests.MockUsdaSite.MockUsdaSiteFoodList
{
    public class MockUsdaAsyncFoodList : IUsdaAsync
    {
        public int FetchedTotalFromSearch { get; set; }
        public string FetchedIngredientsInIngredient { get; set; }


        public async Task<List<FoodItem>> GetListOfIngredientsFromTextSearch(string searchString, string description)
        {
            string sampleManufacturerOrFoodGroup = "";

            await Task.Delay(0);
            List<FoodItem> list = new List<FoodItem>();
            FoodItem ingredient = new FoodItem() { Name = searchString, Ndbno = "someRandomNumber" };
            ingredient.MakerOrFoodGroup = sampleManufacturerOrFoodGroup;

            if (searchString == "This Should Return No Ingredients")
            {
                return list;
            }

            if (searchString == "1000" ||
                searchString == "1003" ||
                searchString == "1049" ||
                searchString == "1050" ||
                searchString == "1051"
               )
            { return FoodItem.BuildIngredientList(list, searchString); }


            if (searchString == "total")
            {
                FetchedTotalFromSearch = 445321;
                for (int i = 0; i < FetchedTotalFromSearch; i++)
                {
                    list.Add(ingredient);
                }
                return list;
            }

            else
            {
                list.Add(ingredient);
                return list;
            }
        }



        public async Task<ListOfFoodsViewModel> GetListForLeastFiveCarbsAscending()
        {
            UsdaListofFoods usdaListofFoods = new UsdaListofFoods();
            usdaListofFoods.list = new list();
            usdaListofFoods.list.item = new item[]{
                new item {ndbno="carb1"},
                new item {ndbno="carb2"},
                new item {ndbno="carb3"},
                new item {ndbno="carb4"},
                new item {ndbno="carb5"} };
            var vm = await ListOfFoodsViewModel.MapListOfSearchedFoodsToListOfFoods(null, usdaListofFoods);
            ListOfFoodsViewModel.SortTotalCarbohydrates(vm);

            return vm;
        }

        public async Task<ListOfFoodsViewModel> GetListForLeastFiveCarbsAscendingOrderShifted52545()
        {
            UsdaListofFoods usdaListofFoods = new UsdaListofFoods();
            usdaListofFoods.list = new list();
            usdaListofFoods.list.item = new item[]{
                new item {ndbno="carb5"},
                new item {ndbno="carb2"},
                new item {ndbno="carb5"},
                new item {ndbno="carb4"},
                new item {ndbno="carb5"} };
            var vm = await ListOfFoodsViewModel.MapListOfSearchedFoodsToListOfFoods(null, usdaListofFoods);
            ListOfFoodsViewModel.SortTotalCarbohydrates(vm);

            return vm;
        }


        private static decimal GetTotalCarbsFromFoodReport(UsdaFoodReport report)
        {
            decimal valueWeWant = 0;
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
                                valueWeWant = totCarb.First().measures.First().value;
                            }
                        }
                    }
                }
            }
            return valueWeWant;
        }


        public static UsdaFoodReport GetFoodReport(string ndbno)
        {
            UsdaFoodReport report = new UsdaFoodReport();
            report.foods = new foods[1];
            report.foods[0] = new foods();
            report.foods[0].food = new food();
            report.foods[0].food.desc = new desc();
            report.foods[0].food.desc.name = ndbno;
            report.foods[0].food.desc.fg = "test";
            report.foods[0].food.desc.manu = "";
            report.foods[0].food.ing = new ing();
            report.foods[0].food.ing.desc = "description of " + ndbno;
            report.foods[0].food.nutrients = new nutrients[1];
            report.foods[0].food.nutrients[0] = new nutrients();
            report.foods[0].food.nutrients[0].nutrient_id = 205;
            report.foods[0].food.nutrients[0].measures = new measures[1];
            report.foods[0].food.nutrients[0].measures[0] = new measures();
            report.foods[0].food.nutrients[0].measures[0].label = "test label";
            if (ndbno == "carb1")
            {
                report.foods[0].food.nutrients[0].measures[0].value = 5;
            }
            if (ndbno == "carb2")
            {
                report.foods[0].food.nutrients[0].measures[0].value = 4;
            }
            if (ndbno == "carb3")
            {
                report.foods[0].food.nutrients[0].measures[0].value = 3;
            }
            if (ndbno == "carb4")
            {
                report.foods[0].food.nutrients[0].measures[0].value = 2;
            }
            if (ndbno == "carb5")
            {
                report.foods[0].food.nutrients[0].measures[0].value = 1;
            }
            if (ndbno == "01323")
            {
                report.foods[0].food.nutrients[0].measures[0].value = 5;
            }
            if (ndbno == "45188178")
            {
                report.foods[0].food.nutrients[0].measures[0].value = 4;
            }
            if (ndbno == "45167682")
            {
                report.foods[0].food.nutrients[0].measures[0].value = 3;
            }
            if (ndbno == "45037291")
            {
                report.foods[0].food.nutrients[0].measures[0].value = 2;
            }
            if (ndbno == "45187982")
            {
                report.foods[0].food.nutrients[0].measures[0].value = 1;
            }
            return report;
        }

        private Task<List<UsdaFoodReport>> FetchUsdaFood(string searchText, int number) => throw new NotImplementedException();

        public async Task<ListOfFoodsViewModel> FetchUsdaFoodListByLeastFiveCarbohydrates(string searchText) => await GetListForLeastFiveCarbsAscending();

        public async Task<UsdaFoodReport> FetchUsdaFoodReport(string ndbno) => GetFoodReport(ndbno);

        async Task<UsdaListofFoods> IUsdaAsync.FetchUsdaListOfFoods(string searchText, int defaultCount) => GetList(searchText, defaultCount);

        async Task<UsdaFoodReport> IUsdaAsync.FetchUsdaFoodReport(string ndbno) => GetFoodReport(ndbno);


        private UsdaListofFoods GetList(string searchText, int defaultCount)
        {
            UsdaListofFoods usdaListofFoods = new UsdaListofFoods();
            usdaListofFoods.list = new list();
            usdaListofFoods.list.q = searchText;

            if (searchText == "MockedButter")
            {
                usdaListofFoods.list.total = 1;
                usdaListofFoods.list.item = new item[5];
                usdaListofFoods.list.item[0] = new item();
                usdaListofFoods.list.item[0].ndbno = "01323";
                usdaListofFoods.list.item[0].name = "first";
                usdaListofFoods.list.item[1] = new item();
                usdaListofFoods.list.item[1].ndbno = "45188178";
                usdaListofFoods.list.item[1].name = "second";
                usdaListofFoods.list.item[2] = new item();
                usdaListofFoods.list.item[2].ndbno = "45167682";
                usdaListofFoods.list.item[2].name = "third";
                usdaListofFoods.list.item[3] = new item();
                usdaListofFoods.list.item[3].ndbno = "45037291";
                usdaListofFoods.list.item[3].name = "fourth";
                usdaListofFoods.list.item[4] = new item();
                usdaListofFoods.list.item[4].ndbno = "45187982";
                usdaListofFoods.list.item[4].name = "fifth";
            }
            if (searchText == "MockedEgg")
            {
                usdaListofFoods.list.total = 1;
                usdaListofFoods.list.item = new item[5];
                usdaListofFoods.list.item[0] = new item();
                usdaListofFoods.list.item[0].ndbno = "carb5";
                usdaListofFoods.list.item[0].name = "first";
                usdaListofFoods.list.item[1] = new item();
                usdaListofFoods.list.item[1].ndbno = "carb4";
                usdaListofFoods.list.item[1].name = "second";
                usdaListofFoods.list.item[2] = new item();
                usdaListofFoods.list.item[2].ndbno = "carb3";
                usdaListofFoods.list.item[2].name = "third";
                usdaListofFoods.list.item[3] = new item();
                usdaListofFoods.list.item[3].ndbno = "carb2";
                usdaListofFoods.list.item[3].name = "fourth";
                usdaListofFoods.list.item[4] = new item();
                usdaListofFoods.list.item[4].ndbno = "carb1";
                usdaListofFoods.list.item[4].name = "fifth";
            }

            if (searchText == "MockedPizza")
            {
                usdaListofFoods.list.total = 1;
                usdaListofFoods.list.item = new item[5];
                usdaListofFoods.list.item[0] = new item();
                usdaListofFoods.list.item[0].ndbno = "carb3";
                usdaListofFoods.list.item[0].name = "first";
                usdaListofFoods.list.item[1] = new item();
                usdaListofFoods.list.item[1].ndbno = "carb2";
                usdaListofFoods.list.item[1].name = "second";
                usdaListofFoods.list.item[2] = new item();
                usdaListofFoods.list.item[2].ndbno = "carb5";
                usdaListofFoods.list.item[2].name = "third";
                usdaListofFoods.list.item[3] = new item();
                usdaListofFoods.list.item[3].ndbno = "carb1";
                usdaListofFoods.list.item[3].name = "fourth";
                usdaListofFoods.list.item[4] = new item();
                usdaListofFoods.list.item[4].ndbno = "carb4";
                usdaListofFoods.list.item[4].name = "fifth";
            }
            if (searchText == "MockedFiveZeros")
            {
                usdaListofFoods.list.total = 1;
                usdaListofFoods.list.item = new item[5];
                usdaListofFoods.list.item[0] = new item(); 
                usdaListofFoods.list.item[0].name = "first";
                usdaListofFoods.list.item[1] = new item();
              //  usdaListofFoods.list.item[1].ndbno = "carb2";
                usdaListofFoods.list.item[1].name = "second";
                usdaListofFoods.list.item[2] = new item();
              //  usdaListofFoods.list.item[2].ndbno = "carb5";
                usdaListofFoods.list.item[2].name = "third";
                usdaListofFoods.list.item[3] = new item();
              //  usdaListofFoods.list.item[3].ndbno = "carb1";
                usdaListofFoods.list.item[3].name = "fourth";
                usdaListofFoods.list.item[4] = new item();
              //  usdaListofFoods.list.item[4].ndbno = "carb4";
                usdaListofFoods.list.item[4].name = "fifth";
            }



            return usdaListofFoods;
        }
    }
}