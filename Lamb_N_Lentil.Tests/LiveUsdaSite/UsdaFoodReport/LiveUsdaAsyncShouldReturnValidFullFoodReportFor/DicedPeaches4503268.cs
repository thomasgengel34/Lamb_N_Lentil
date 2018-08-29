using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.LiveUsdaAsyncShouldReturnValidFullFoodReportFor
{
    [TestClass]
    public class DicedPeaches4503268 : LiveUsdaSiteTestSetup
    {  
        [TestInitialize]
        public async Task Start()
        {
           Ndbno = "45032698";
           report = await usdaAsync.FetchUsdaFoodReport(Ndbno);
        }

        [TestMethod]
        public void When45032698IsSearchText()
        { 
            var correct = "DICED PEACHES, WATER, SUGAR, NATURAL FLAVORS, ASCORBIC ACID (VITAMIN C) TO PROTECT COLOR, CITRIC ACID."; 
            var returned = report.foods.First().food.ing.desc;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnIngredientsListInFoodReport()
        { 
            var correct = "DICED PEACHES, WATER, SUGAR, NATURAL FLAVORS, ASCORBIC ACID (VITAMIN C) TO PROTECT COLOR, CITRIC ACID."; 
           var returned = report.foods.First().food.ing.desc;
            Assert.AreEqual(correct, returned);
        }
    }
}
