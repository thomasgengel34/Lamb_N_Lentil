using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.LiveUsdaAsyncShouldReturnValidFullFoodReportFor
{
    [TestClass]
    public class MinisCrackers45309635 :  LiveUsdaSiteTestSetup
    {    
        [TestInitialize]
        public async Task CallFetchReport()
        {
            Ndbno = "45309635";  
            await FetchReport();
        }  

        [TestMethod]
        public void HasCorrectName()
        {
            var correct = "MINIS CRACKERS , UPC: 030100490524";
            var returned = report.foods[0].food.desc.name;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectNdbno()
        {
            var returned = report.foods[0].food.desc.ndbno;
            Assert.AreEqual(Ndbno, returned);
        }
         

        [TestMethod]
        public void DietaryFiber()
        { 
            var correct = 0.00m; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 291
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Sugar()
        { 
            var correct = 1.00M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 269
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void VitaminA()
        { 
            var correct =  0.00M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 318
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Iron()
        { 
            var correct = 0.72M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 303
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        } 
    }   
}
