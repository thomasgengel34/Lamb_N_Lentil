using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Lamb_N_Lentil.Domain.UsdaInformation.List;

namespace Lamb_N_Lentil.Domain.UsdaInformation
{
    public class UsdaAsync : IUsdaAsync
    {
        private static readonly string key = "sFtfcrVdSOKA4ip3Z1MlylQmdj5Uw3JoIIWlbeQm";
        public static int FetchedTotalFromSearch { get; set; } = 0;
        public static string FetchedIngredientsInIngredient { get; set; } = "";

        //private  IUsdaAsync usdaAsync = new UsdaAsync();



        public static string ReduceStringLengthToWhatWillWorkOnUSDA(string searchString = "")
        {
            const int MaxStringLengthThatWillWork = 43;
            searchString = searchString ?? "";
            if (searchString.Length > MaxStringLengthThatWillWork)
            {
                searchString = searchString.Substring(searchString.Length - MaxStringLengthThatWillWork);
            }

            return searchString;
        }




        async Task<UsdaListofFoods> IUsdaAsync.FetchUsdaListOfFoods(string searchText, int defaultCount)
        {
            HttpClient client = new HttpClient();
            string http = " https://api.nal.usda.gov/ndb/search?format=json&q=";


            string http2 = "&max=" + defaultCount + "&offset=0&api_key=";

            string foodListUrl = string.Concat(http, searchText, http2, key);

            client.BaseAddress = new Uri(foodListUrl);

            client.BaseAddress = new Uri(foodListUrl);
            UsdaListofFoods usdaList = null;

            HttpResponseMessage response = await client.GetAsync(foodListUrl);
            if (response.IsSuccessStatusCode)
            {
                usdaList = await response.Content.ReadAsAsync<UsdaListofFoods>();
            }
            return usdaList;
        }
         

        public async Task<decimal> GetTotalCarbs(item item)
        {
            IUsdaAsync foo = new UsdaAsync();
            UsdaFoodReport report = await foo.FetchUsdaFoodReport(item.ndbno);
            var totalcarb = 0.0M;
            if (report.foods.FirstOrDefault().food.nutrients.Where(i => i.nutrient_id == 205).FirstOrDefault().value != null)
            {
                totalcarb = Convert.ToDecimal(report.foods.FirstOrDefault().food.nutrients.Where(i => i.nutrient_id == 205).FirstOrDefault().value);
            }
            else
            {
                totalcarb = report.foods.FirstOrDefault().food.nutrients.Where(i => i.nutrient_id == 205).FirstOrDefault().measures.FirstOrDefault().value;
            }
            return totalcarb;
        }

        async Task<UsdaFoodReport> IUsdaAsync.FetchUsdaFoodReport(string ndbno)
        {
            HttpClient client = new HttpClient();

            string http = "https://api.nal.usda.gov/ndb/V2/reports/?ndbno=";
            string apiKey = "&type=f&format=json&api_key=";
            string foodsUrl = String.Concat(http, ndbno, apiKey, key);

            client.BaseAddress = new Uri(foodsUrl);

            UsdaFoodReport usdaFoodReport = null;
            HttpResponseMessage response = await client.GetAsync(foodsUrl);
            if (response.IsSuccessStatusCode)
            {
                usdaFoodReport = await response.Content.ReadAsAsync<UsdaFoodReport>();
            }

            if (usdaFoodReport != null && usdaFoodReport.foods != null && usdaFoodReport.foods.First().food != null && usdaFoodReport.foods.First().food != null && usdaFoodReport.foods.First().food.ing != null && usdaFoodReport.foods.First().food.ing.desc != null)
            {
                FetchedIngredientsInIngredient = usdaFoodReport.foods.First().food.ing.desc;
            }
            else
            {
                FetchedIngredientsInIngredient = "Not provided";
            }
            if (usdaFoodReport != null && usdaFoodReport.foods != null && usdaFoodReport.foods.First().food != null && usdaFoodReport.foods.First().food != null && usdaFoodReport.foods.First().food.ing == null)
            {
                usdaFoodReport.foods.First().food.ing = new ing() { desc = FetchedIngredientsInIngredient };
            }
            else if (usdaFoodReport != null && usdaFoodReport.foods != null && usdaFoodReport.foods.First().food != null && usdaFoodReport.foods.First().food != null && usdaFoodReport.foods.First().food.ing != null)
            {
                usdaFoodReport.foods.First().food.ing.desc = FetchedIngredientsInIngredient;
            }
            return usdaFoodReport;
        }
    }
}