using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.LiveUsdaAsyncShouldReturnValidFullFoodReportFor
{
    [TestClass]
    public class LiveUsdaAsyncShouldReturnValidFoodReportForKiwi45209709 : LiveUsdaSiteTestSetup
    {    
        [TestInitialize]
        public async Task CallFetchReport()
        {
            Ndbno = "45209709";  
            await FetchReport();
        } 

        [TestMethod]
        public void HasCorrectName()
        {
            var correct = "KIWI, UPC: 028744019140";
            var returned = report.foods[0].food.desc.name;
            Assert.AreEqual(correct, returned );
        }

        [TestMethod]
        public void HasCorrectNdbno()
        {
            var returned = report.foods[0].food.desc.ndbno;
            Assert.AreEqual(Ndbno, returned);
        }

        [TestMethod]
        public void HasCorrectUnitForFirstNutrient()
        {
            var correct = "kcal";
            var returned = report.foods[0].food.nutrients[0].unit;
            Assert.AreEqual(correct, returned );
        }

        [TestMethod]
        public void HasCorrectServingSizeForFirstNutrient()
        {
            var correct = 0.0M;
            var returned = report.foods[0].food.nutrients[0].qty;
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void DietaryFiber()
        { 
            var correct = 1.00m; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 291
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Sugar()
        { 
            var correct = 20.00M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 269
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void VitaminA()
        { 
            var correct = 0.00M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 318
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void ServingSize()
        { 
            var correct  = "cup"; 
            var returned  = report.foods.First().food.nutrients.First().measures.First().label;
            Assert.AreEqual(correct , returned );
        }

        [TestMethod]
        public void CorrectServingSizeOnFirstNutrient()
        {
            var correct = "cup";
            var returned = report.foods.First().food.nutrients.First().measures.First().label;
            Assert.AreEqual(correct, returned);
        }
    }  
}
