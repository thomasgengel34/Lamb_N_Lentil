using Lamb_N_Lentil.Domain.UsdaList;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lamb_N_Lentil.Domain.UsdaInformation
{
    public class UsdaAsync : IUsdaAsync
    {
        static readonly string key = "sFtfcrVdSOKA4ip3Z1MlylQmdj5Uw3JoIIWlbeQm";
        public int FetchedTotalFromSearch { get; set; }
        public string FetchedIngredientsInIngredient { get; set; }
          

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


        public async Task<UsdaFoodReport> FetchUsdaFoodReport(string ndbno)
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

        public async Task<UsdaListofFoods> FetchUsdaFoodList(string searchText)
        {
            HttpClient client = new HttpClient();
            string http = " https://api.nal.usda.gov/ndb/search?format=json&q=";


            string http2="&max=50&offset=0&api_key=";
           
            string foodListUrl = String.Concat(http,searchText,http2,key);

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
    } 
}
