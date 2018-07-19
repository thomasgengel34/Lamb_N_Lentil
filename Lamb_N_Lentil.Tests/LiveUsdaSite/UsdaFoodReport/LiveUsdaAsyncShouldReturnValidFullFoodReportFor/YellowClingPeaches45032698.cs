using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.LiveUsdaAsyncShouldReturnValidFullFoodReportFor
{   
    [TestClass]
    public class  YellowClingPeaches45032698: LiveUsdaSiteTestSetup
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
            var correct = 0.0M; 
            var returned = (from c in report.foods.First().food.nutrients
                            where c.nutrient_id == 431
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void WithCorrectName()
        {
            string correct = "DICED PEACHES, UPC: 078742212050";
            var returned = report.foods.First().food.desc.name;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void WithCorrectNdbno()
        {
            var returned = report.foods.First().food.desc.ndbno;
            Assert.AreEqual(Ndbno, returned );
        }
         

        [TestMethod]
        public void Manufacturer()
        { 
            var correct = 0.0M; 
            var returned = (from c in report.foods.First().food.nutrients
                            where c.nutrient_id == 431
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectServingSizeForFirstNutrient()
        {
            var correct = 1.0M;
            var returned = report.foods.First().food.nutrients[0].measures[0].qty;
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void Calories()
        { 
           var correct = 80; 
            var result = from r in report.foods.First().food.nutrients
                         where r.name == "Energy"
                         select r.measures[0].value;
           var returned = Convert.ToInt16(result.First());
            Assert.AreEqual(correct , returned );
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
        public void SaturatedFat()
        { 
            var correct = 0.00m; 
            var returned = (from c in report.foods.First().food.nutrients
                            where c.nutrient_id == 606
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

      
    }  
}
