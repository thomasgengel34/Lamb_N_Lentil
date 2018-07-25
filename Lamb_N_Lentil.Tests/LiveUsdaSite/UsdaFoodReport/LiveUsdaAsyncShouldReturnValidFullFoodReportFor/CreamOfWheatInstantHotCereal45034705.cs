 using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.LiveUsdaAsyncShouldReturnValidFullFoodReportFor
{
    [TestClass]
    public class  CreamOfWheatInstantHotCereal45034705  : LiveUsdaSiteTestSetup
    { 
        [TestInitialize]
        public async Task  CallFetchReport()
        {
            Ndbno = "45034705";  
            await FetchReport();
        }

        [TestMethod]
        public void FolicAcid()
        { 
            var correct = 0.0M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 431
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void WithCorrectName()
        {
            var correct = "CREAM OF WHEAT, INSTANT HOT CEREAL, ORIGINAL, UPC: 072400060700";
            var returned = report.foods[0].food.desc.name;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void WithCorrectNdbno()
        {
            var returned = report.foods[0].food.desc.ndbno;
            Assert.AreEqual(Ndbno, returned );
        }
         

        [TestMethod]
        public void Manufacturer()
        { 
            var correct = 0.0M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 431
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectServingSizeForFirstNutrient()
        {
            var correct = 1.0M;
            var returned = report.foods[0].food.nutrients[0].measures[0].qty;
            Assert.AreEqual(correct, returned);
        }
        
        [TestMethod]
        public void Calories()
        { 
            var correct = 100; 
            var result = from r in report.foods[0].food.nutrients
                         where r.name == "Energy"
                         select r.measures[0].value; 
             var returned  = Convert.ToInt16(result.First());
            Assert.AreEqual(correct , returned );
        }


        [TestMethod]
        public void Potassium()
        { 
            var correct = 0.0M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 306
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void TransFat()
        { 
            var correct = 0.00m; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 605
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void SaturatedFat()
        { 
            var correct  = 0.00m; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 606
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        } 

        [TestMethod]
        public void PolyunsaturatedFat()
        { 
            var correct = 0.0M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 646
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void TotalCarbohydrates()
        { 
            var correct= 71.43M;  
           var returned  = Convert.ToDecimal(report.foods[0].food.nutrients[3].value);
            Assert.AreEqual(correct , returned);
        } 
    }    
}
