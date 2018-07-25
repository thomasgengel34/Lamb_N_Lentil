using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.LiveUsdaAsyncShouldReturnValidFullFoodReportFor
{
    [TestClass]
    public class  Hominy20030: LiveUsdaSiteTestSetup
    {    
        [TestInitialize]
        public async Task CallFetchReport()
        {
            Ndbno = "20030";  
            await FetchReport();
        } 

        [TestMethod]
        public void HasCorrectName()
        {
           var correct = "Hominy, canned, white";
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
            var correct = "g";
            var returned = report.foods[0].food.nutrients[0].unit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectServingSizeForFirstNutrient()
        {
            var correct = 0.0M;
            var returned = report.foods[0].food.nutrients[0].qty;
            Assert.AreEqual(correct, returned);
        }
         
    }   
}
