using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lamb_N_Lentil.Domain;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.Domain.UsdaInformation.List;
using Lamb_N_Lentil.UI.Models;

namespace Lamb_N_Lentil.Tests.MockUsdaAsyncSiteFoodList
{
    internal class MockUsdaAsyncFoodList : IUsdaAsync
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
            { return BuildIngredientList(list, searchString); }


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

        private static List<FoodItem> BuildIngredientList(List<FoodItem> list, string searchString)
        {
            int length = Convert.ToInt32(searchString) - 1000;
            list.Clear();
            for (int i = 0; i < length; i++)
            {
                list.Add(new FoodItem { Ndbno = i.ToString() });
            }
            return list;
        }

        //Task<List<FoodItem>>  GetListOfIngredientsFromTextSearch(string searchString, string dataSource) => GetListOfIngredientsFromTextSearch(searchString, dataSource);


        Task<UsdaFoodReport> IUsdaAsync.FetchUsdaFoodReport(string ndbno)
         => throw new NotImplementedException("MockUsdaAsyncFoodList Fetch is not implemented for the interface");

        Task<List<UsdaFoodReport>> FetchUsdaFood(string searchText)
        {
            throw new NotImplementedException();
        }

        public Task<UsdaListofFoods> FetchUsdaFoodList(string searchText) => throw new NotImplementedException();
    }
}