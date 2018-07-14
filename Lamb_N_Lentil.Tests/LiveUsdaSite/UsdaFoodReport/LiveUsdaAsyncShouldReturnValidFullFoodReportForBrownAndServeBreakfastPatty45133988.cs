using Lamb_N_Lentil.Domain.UsdaInformation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Linq;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport
{    
    [TestClass]
    public class LiveUsdaAsyncShouldReturnValidFoodReportForBrownAndServeBreakfastPatty45133988 : LiveUsdaAsyncShouldReturnValidFoodReportWhen
    {    
        [TestInitialize]
        public async Task CallFetchReport()
        {
            Ndbno = "45133988";  
            await FetchReport();
        }  

        [TestMethod]
        public void HasCorrectName()
        {
            string correct = "BANQUET Brown N Serve Original Patty, UNPREPARED, GTIN: 00031000184643";
            Assert.AreEqual(correct, report.foods[0].food.desc.name);
        }

        [TestMethod]
        public void HasCorrectNdbno()
        {
            Assert.AreEqual(Ndbno, report.foods[0].food.desc.ndbno);
        }

        [TestMethod]
        public void HasCorrectUnitForFirstNutrient()
        {
            string correct = "kcal";
            Assert.AreEqual(correct, report.foods[0].food.nutrients[0].unit);
        }

        [TestMethod]
        public void HasCorrectServingSizeForFirstNutrient()
        {
            decimal correct = 0.0M;
            Assert.AreEqual(correct, report.foods[0].food.nutrients[0].qty);
        }


        [TestMethod]
        public void DietaryFiber()
        { 
            decimal correct = 0.00m; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 291
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Sugar()
        { 
            decimal correct = 1.00M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 269
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void VitaminA()
        { 
            decimal correct =  0.00M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 318
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Iron()
        { 
            decimal correct = 0.72M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 303
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

    }   
}
