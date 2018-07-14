using System.Linq;
using Lamb_N_Lentil.Domain;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.Models
{
    /*  [TestClass]
  public class MapUsdaFoodReportToIngredientShould
    {
         private food food;
       readonly private string correctName = "test name";
       readonly private string correctNumber = "test number";
       readonly private string correctDesc = "test desc";
       readonly private string correctDate = "4/17/2017";
       readonly private decimal correctCalories = 99M;
       readonly private decimal correctTotalFat = 987654.2M;
       readonly private decimal correctSaturatedFat = 12345.67M;
       readonly private decimal correctTotalCarbohydrate = 99.012M;
       readonly private decimal correctSodium = 98.6M;
       readonly private decimal correctProtein = 7.15M;
       readonly private decimal correctVitaminA = 3.11M;

        private IIngredient ingredient;


        public MapUsdaFoodReportToIngredientShould()
        {
            food = new food
            {
                desc = new desc()
            };
            food.desc.name = correctName;
            food.desc.ndbno = correctNumber;
            food.ing = new ing
            {
                desc = correctDesc,
                upd = correctDate
            };
            int setHigherThanEverExpected = 40;
            food.nutrients = new nutrients[setHigherThanEverExpected];
        
            food.nutrients[0] = new nutrients
            {
                measures = new measures[1],
                name = "Energy",
                nutrient_id = 208,
               
        };
            food.nutrients[0].measures[0] = new measures
            {
                value = correctCalories,
                qty =7.25M, 
            };

            food.nutrients[2] = new nutrients
            {
                name = "Total lipid(fat)",
                nutrient_id = 204,
                measures = new measures[1]
            };
            food.nutrients[2].measures[0] = new measures
            {
                value = correctTotalFat
            };

            food.nutrients[3] = new nutrients
            {
                name = "Fatty acids, total saturated",
                nutrient_id = 606,
                measures = new measures[1]
            };
            food.nutrients[3].measures[0] = new measures
            {
                value = correctSaturatedFat
            };

            food.nutrients[4] = new nutrients
            {
                name = "Fiber, total dietary",
                nutrient_id = 291,
                measures = new measures[1]
            };
            food.nutrients[4].measures[0] = new measures
            {
                value = correctSaturatedFat
            };

            food.nutrients[5] = new nutrients
            {
                name = "Vitamin A, IU",
                nutrient_id = 318,
                measures = new measures[1]
            };
            food.nutrients[5].measures[0] = new measures
            {
                value = correctVitaminA
            };

            food.nutrients[9] = new nutrients
            {
                name = "Protein",
                nutrient_id = 203,
                measures = new measures[1]
            };
            food.nutrients[9].measures[0] = new measures
            {
                value = 7.15M
            };

            food.nutrients[10] = new nutrients
            {
                name = "Sodium, Na",
                nutrient_id = 307,
                measures = new measures[1]
            };
            food.nutrients[10].measures[0] = new measures
            {
                value = correctSodium
            };

            food.nutrients[11] = new nutrients
            {
                name = "Carbohydrate, by difference",
                nutrient_id = 205,
                measures = new measures[1]
            };
            food.nutrients[11].measures[0] = new measures
            {
                value = correctTotalCarbohydrate
            };

            foods[] foods =new foods[1];
            foods[0] = new foods
            {
                food = food
            };
            UsdaFoodReport report = new UsdaFoodReport
            {
                foods = foods
            };
            ingredient = MapUsdaFoodReportToIIngredient.ConvertUsdaFoodReportToIIngredient( report);
        }

        [TestMethod]
        public void ConvertName()
        {
            Assert.AreEqual(correctName, ingredient.InstanceName);
        }

        [TestMethod]
        public void ConvertUpdateDate()
        {
            Assert.AreEqual(correctDate, ingredient.UpdateDate);
        }

        //[TestMethod]
        //public void ConvertCaloriesValue()
        //{
        //    Assert.AreEqual(correctCalories, ingredient.Calories);
        //}

        //[TestMethod]
        //public void ConvertTotalFat()
        //{
        //    Assert.AreEqual(correctTotalFat, ingredient.TotalFat);
        //}

        //[TestMethod]
        //public void ConvertSaturatedFat()
        //{
        //    Assert.AreEqual(correctSaturatedFat, ingredient.SaturatedFat);
        //}

        //[TestMethod]
        //public void ConvertTotalCarbohydrate()
        //{
        //    Assert.AreEqual(correctTotalCarbohydrate, ingredient.TotalCarbohydrate);
        //}

        //[TestMethod]
        //public void ConvertSodium()
        //{
        //    Assert.AreEqual(correctSodium, ingredient.Sodium);
        //}

        //[TestMethod]
        //public void ConvertProtein()
        //{
        //    Assert.AreEqual(correctProtein, ingredient.Protein);
        //}

        //[TestMethod]
        //public void ConvertVitaminA()
        //{
        //    decimal correct = 3.11M;
        //    Assert.AreEqual(correct , ingredient.VitaminA);
        //}

        //[TestMethod]
        //public void ConvertServingSize()
        //{
        //    decimal correct = 7.25M;
        //    Assert.AreEqual(correct, ingredient.ServingSize);
        //}
    }   */
}
