using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.LiveUsdaAsyncShouldReturnValidFullFoodReportFor
{
    [TestClass]
    public class  KrogerBlendedGradeALowFatStrawberryYogurtUPC011110452979 : LiveUsdaSiteTestSetup
    { 
        [TestInitialize]
        public async Task CallFetchReport()
        {
            Ndbno = "45114174";
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
            var correct  = "KROGER, BLENDED GRADE A LOWFAT YOGURT, STRAWBERRY, UPC: 011110452979";
            var returned = report.foods[0].food.desc.name;
            Assert.AreEqual(correct, returned );
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
            var correct = 190; 
            var result = from r in report.foods[0].food.nutrients
                         where r.name == "Energy"
                         select r.measures[0].value;
             var returned  =  result.First() ; 
            Assert.AreEqual(correct, returned );
        }


        [TestMethod]
        public void Potassium()
        { 
            var correct = 330M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 306
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void CorrectServingSizeOnFirstNutrient()
        {
            var correct = "CONTAINER";
            var returned = report.foods.First().food.nutrients.First().measures.First().label;
            Assert.AreEqual(correct, returned);
        }
    }   
}
