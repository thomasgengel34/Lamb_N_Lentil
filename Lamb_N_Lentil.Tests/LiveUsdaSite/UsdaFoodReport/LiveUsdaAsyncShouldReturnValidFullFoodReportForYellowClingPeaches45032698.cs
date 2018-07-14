using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport
{   
    [TestClass]
    public class LiveUsdaAsyncShouldReturnValidFoodReportForYellowClingPeaches45032698: LiveUsdaAsyncShouldReturnValidFoodReportWhen
    { 
        [TestInitialize]
        public async Task CallFetchReport()
        {
            Ndbno = "45032698";
            await FetchReport();
        }

        [TestMethod]
        public void FolicAcid()
        { 
            decimal correct = 0.0M; 
            var returned = (from c in report.foods.First().food.nutrients
                            where c.nutrient_id == 431
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void WithCorrectName()
        {
            string correctName = "DICED PEACHES, UPC: 078742212050";

            Assert.AreEqual(correctName, report.foods.First().food.desc.name);
        }

        [TestMethod]
        public void WithCorrectNdbno()
        { 
            Assert.AreEqual(Ndbno, report.foods.First().food.desc.ndbno);
        }
         

        [TestMethod]
        public void Manufacturer()
        { 
            decimal correct = 0.0M; 
            var returned = (from c in report.foods.First().food.nutrients
                            where c.nutrient_id == 431
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectServingSizeForFirstNutrient()
        {
            decimal correct = 1.0M;
            Assert.AreEqual(correct, report.foods.First().food.nutrients[0].measures[0].qty);
        }


        [TestMethod]
        public void Calories()
        { 
            int correctkcal = 80; 
            var result = from r in report.foods.First().food.nutrients
                         where r.name == "Energy"
                         select r.measures[0].value;
            int returnedkcal = Convert.ToInt16(result.First());
            Assert.AreEqual(correctkcal, returnedkcal);
        }


        [TestMethod]
        public void Potassium()
        { 
            decimal correct = 31M; 
            var returned = (from c in report.foods.First().food.nutrients
                            where c.nutrient_id == 306
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void TransFat()
        { 
            decimal correct = 0.00m; 
            var returned = (from c in report.foods.First().food.nutrients
                            where c.nutrient_id == 605
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void SaturatedFatForYellowClingPeaches45032698()
        { 
            decimal correctSaturatedFat = 0.00m; 
            var returned = (from c in report.foods.First().food.nutrients
                            where c.nutrient_id == 606
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correctSaturatedFat, returned);
        } 
    }  
}
