using System.Linq;
using System.Threading.Tasks;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _UsdaFoodReport = Lamb_N_Lentil.Domain.UsdaInformation.UsdaFoodReport;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.LiveUsdaAsyncShouldReturnValidFullFoodReportFor
{
    [TestClass]
    public class DicedPeaches4503268 : LiveUsdaSiteTestSetup
    {
        private string Ndbno = "45032698";
        _UsdaFoodReport usdaFoodReport;

        [TestInitialize]
        public async Task Start()
        {
            usdaFoodReport = await usdaAsync.FetchUsdaFoodReport(Ndbno);
        }

        [TestMethod]
        public void When45032698IsSearchText()
        { 
            var correct = "DICED PEACHES, WATER, SUGAR, NATURAL FLAVORS, ASCORBIC ACID (VITAMIN C) TO PROTECT COLOR, CITRIC ACID."; 
            var returned = usdaFoodReport.foods.First().food.ing.desc;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnIngredientsListInFoodReport()
        { 
            var correct = "DICED PEACHES, WATER, SUGAR, NATURAL FLAVORS, ASCORBIC ACID (VITAMIN C) TO PROTECT COLOR, CITRIC ACID."; 
           var returned = usdaFoodReport.foods.First().food.ing.desc;
            Assert.AreEqual(correct, returned);
        }
    }
}
