using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.LiveUsdaAsyncShouldReturnValidFullFoodReportFor
{
    [TestClass]
    public class WalmartGardenRotini45058106
        : LiveUsdaSiteTestSetup
    { 
        [TestInitialize]
        public async Task CallFetchReport()
        {
            Ndbno = "45058106";
            await FetchReport();
        }

     

        [TestMethod]
        public void WithCorrectName()
        {
            var correct  = "GARDEN ROTINI, UPC: 078742228679";
            var returned = report.foods[0].food.desc.name;
            Assert.AreEqual(correct , returned);
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
            var correct = 0.75M;
            var returned = report.foods[0].food.nutrients[0].measures[0].qty;
            Assert.AreEqual(correct, returned );
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

    }   
}
