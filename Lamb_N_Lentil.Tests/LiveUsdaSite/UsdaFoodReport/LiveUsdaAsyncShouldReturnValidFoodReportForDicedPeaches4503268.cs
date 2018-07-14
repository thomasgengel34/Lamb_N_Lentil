using Lamb_N_Lentil.Domain;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.UI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport
{
    [TestClass]
    public class LiveUsdaAsyncShouldReturnValidFoodReportForDicedPeaches4503268: LiveUsdaAsyncShouldReturnValidFoodReportWhen
    {
        
        [TestMethod]
        public async Task When45032698IsSearchText()
        {
            string Ndbno = "45032698"; 
            string correct  = "DICED PEACHES, WATER, SUGAR, NATURAL FLAVORS, ASCORBIC ACID (VITAMIN C) TO PROTECT COLOR, CITRIC ACID.";

            var usdaFoodReport= await usdaAsync.FetchUsdaFoodReport(Ndbno);

            string returned =  usdaFoodReport.foods.First().food.ing.desc; 
            Assert.AreEqual(correct , returned );
        }

        [TestMethod]
        public async Task ReturnIngredientsListInFoodReport()
        {
            string Ndbno = "45032698";
            string correct = "DICED PEACHES, WATER, SUGAR, NATURAL FLAVORS, ASCORBIC ACID (VITAMIN C) TO PROTECT COLOR, CITRIC ACID.";
             var report= await new UsdaAsync().FetchUsdaFoodReport(Ndbno);
            string returned  = report.foods.First().food.ing.desc;
            Assert.AreEqual(correct, returned );
        }
    }    
}
