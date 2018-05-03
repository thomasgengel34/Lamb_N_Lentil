﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lamb_N_Lentil.Domain;
using Lamb_N_Lentil.Domain.UsdaInformation;

namespace Lamb_N_Lentil.Tests.MockUsdaSite
{
    internal class MockUsdaAsync : IUsdaAsync
    {
        public int FetchedTotalFromSearch { get; set; }
        public string FetchedIngredientsInIngredient { get; set; }

        public async Task<List<IIngredient>> GetListOfIngredientsFromTextSearch(string searchString, string description)
        {
            int someRandomID = 79258888;
            string sampleManufacturerOrFoodGroup;
            if (description == "" || description == UsdaDataSource.Both.ToString())
            {
                sampleManufacturerOrFoodGroup = "Sample Manufacturer Or Food Group For Empty String";
            }
            if (description == UsdaDataSource.BrandedFoodProducts.ToString())
            {
                sampleManufacturerOrFoodGroup = "Sample Manufacturer Or Food Group For Branded Products String";
            }
            if (description == UsdaDataSource.StandardReference.ToString())
            {
                sampleManufacturerOrFoodGroup = "Sample Manufacturer Or Food Group For Standard String";
            }

            await Task.Delay(0);
            List<IIngredient> list = new List<IIngredient>();
            IIngredient ingredient = new Entity() { InstanceName = searchString, ID = someRandomID };

            if (searchString == "This Should Return No Ingredients")
            {
                return list;
            }

            if (searchString == "1000")
                return BuildIngredientList(list, searchString);

            if (searchString == "1003")
                return BuildIngredientList(list, searchString);

            if (searchString == "1049")
                return BuildIngredientList(list, searchString);

            if (searchString == "1050")
                return BuildIngredientList(list, searchString);

            if (searchString == "1051")
                return BuildIngredientList(list, searchString);
            if (searchString == "total")
            {
                FetchedTotalFromSearch = 445321;
                list.Add(ingredient);
                return list;
            }
            else
            {
                list.Add(ingredient);
                return list;
            }
        }

        private static List<IIngredient> BuildIngredientList(List<IIngredient> list, string searchString)
        {
            int length = Convert.ToInt32(searchString) - 1000;
            list.Clear();
            for (int i = 0; i < length; i++)
            {
                list.Add(new Entity { ID = i });
            }
            return list;
        }

        public async Task<string> GetListOfIngredientstFromTextSearch(string searchString, string foodGroup = "", UsdaWebApiDataSource usdaWebApiDataSource = UsdaWebApiDataSource.BrandedFoodProducts)
        {
            Foods foods = new Foods();
            foods.food = new Foods.Food();
            foods.food.desc = new Foods.Food.Desc();
            foods.food.desc.Name = "This is a test";
            foods.food.ing = new Foods.Food.Ing();
            foods.food.ing.desc = "salt, pepper, butter, garlic, turmeric, egg";
            await Task.Delay(0);
            return foods.food.ing.desc;
        }

        public async Task<string> GetManufacturerOrFoodGroup(string ndbno)
        {
            await Task.Delay(0);
            if (ndbno == "01009")
            {

                return "Valley Brook Farm";
            }
            else
            {
                return "this should not be possible to see";
            }
        }


        public async Task<UsdaFoodReport> FetchUsdaFoodReport(string searchString)
        {
            UsdaFoodReport report = new UsdaFoodReport();
            await Task.Delay(0);
            if (searchString == "ShouldReturnIngredients")
            {
                report.foods = new foods[1];
                report.foods[0] = new foods { food = new food() { ing = new ing() { desc = "peas, porridge, hot" } } };
                int setHigherThanEverExpected = 40;
                report.foods[0].food.nutrients = new nutrients[setHigherThanEverExpected];
                report.foods[0].food.nutrients[0] = new nutrients();
                report.foods[0].food.nutrients[0].name = "Energy";
                report.foods[0].food.nutrients[0].nutrient_id = 208;

                report.foods[0].food.nutrients[0].measures = new measures[1];
                report.foods[0].food.nutrients[0].measures[0] = new measures();
                report.foods[0].food.nutrients[0].measures[0].label = "I am a label";
                report.foods[0].food.nutrients[0].measures[0].eqv = 3.1415926M;
                report.foods[0].food.nutrients[0].measures[0].value = 76M;

                report.foods[0].food.nutrients[2] = new nutrients();
                report.foods[0].food.nutrients[2].name = "Total lipid(fat)";
                report.foods[0].food.nutrients[2].nutrient_id = 204;
                report.foods[0].food.nutrients[2].measures = new measures[1];
                report.foods[0].food.nutrients[2].measures[0] = new measures(); 
                report.foods[0].food.nutrients[2].measures[0].value = 987654.2M ;

                report.foods[0].food.nutrients[3] = new nutrients();
                report.foods[0].food.nutrients[3].nutrient_id = 205;  // total carbs - test w/o label
                report.foods[0].food.nutrients[3].measures = new measures[1];
                report.foods[0].food.nutrients[3].measures[0] = new measures();
                report.foods[0].food.nutrients[3].measures[0].value = 77.04M;

                report.foods[0].food.nutrients[4] = new nutrients();
                report.foods[0].food.nutrients[4].name = "Fatty acids, total saturated";
                report.foods[0].food.nutrients[4].nutrient_id = 606;
                report.foods[0].food.nutrients[4].measures = new measures[1];
                report.foods[0].food.nutrients[4].measures[0] = new measures();
                report.foods[0].food.nutrients[4].measures[0].value = 987654.2M;

                report.foods[0].food.nutrients[5] = new nutrients();
                report.foods[0].food.nutrients[5].name = "Fatty acids, total polyunsaturated";
                report.foods[0].food.nutrients[5].nutrient_id = 646;
                report.foods[0].food.nutrients[5].measures = new measures[1];
                report.foods[0].food.nutrients[5].measures[0] = new measures();
                report.foods[0].food.nutrients[5].measures[0].value = 736.08M;




                report.foods[0].food.nutrients[8] = new nutrients();
                report.foods[0].food.nutrients[8].name = "Sodium, Na";
                report.foods[0].food.nutrients[8].nutrient_id = 307;
                report.foods[0].food.nutrients[8].measures = new measures[1];
                report.foods[0].food.nutrients[8].measures[0] = new measures();
                report.foods[0].food.nutrients[8].measures[0].value = 143.0M;



                report.foods[0].food.nutrients[9] = new nutrients();
                report.foods[0].food.nutrients[9].measures = new measures[1];
                report.foods[0].food.nutrients[9].measures[0] = new measures();
                report.foods[0].food.nutrients[9].measures[0].value = 1234.56M;



                return report;
            }
            else throw new NotImplementedException("wrong search string");
        }
    }
}
