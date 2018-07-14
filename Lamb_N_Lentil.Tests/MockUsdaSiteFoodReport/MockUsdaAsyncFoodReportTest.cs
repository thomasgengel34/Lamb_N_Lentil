using Lamb_N_Lentil.Domain.UsdaInformation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace Lamb_N_Lentil.Tests.MockUsdaSiteFoodReport
{
    [TestClass]
    public class MockUsdaAsyncFoodReportTest : MockUsdaAsyncForFoodReport
    {
        IUsdaAsync usdaAsyncFoodReport;

        public MockUsdaAsyncFoodReportTest()
        {
            usdaAsyncFoodReport = new MockUsdaAsyncForFoodReport();
        }

        [TestMethod]
        public async Task ReturnValueInFoodReport()
        {
            string testString = "ShouldReturnIngredients";
            decimal correct = 654.2M;
            UsdaFoodReport report = await usdaAsyncFoodReport.FetchUsdaFoodReport(testString);

            decimal returned = report.foods.First().food.nutrients[0].measures[0].value;
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public async Task ReturnManufacturer()
        {
            string testString = "ShouldReturnIngredients";
            string correct = "default manufacturer";
            UsdaFoodReport report = await usdaAsyncFoodReport.FetchUsdaFoodReport(testString);
            string returned = report.foods.First().food.desc.manu;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public async Task ReturnFoodGroup()
        {
            string testString = "ShouldReturnIngredients";
            string correct = "default food group";
            UsdaFoodReport report = await usdaAsyncFoodReport.FetchUsdaFoodReport(testString);
            string returned = report.foods.First().food.desc.fg;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public async Task ReturnServingSize()
        {
            string testString = "ShouldReturnIngredients";
           decimal correct = 1.0101M;
            UsdaFoodReport report = await usdaAsyncFoodReport.FetchUsdaFoodReport(testString);
            decimal returned = report.foods.First().food.nutrients.First().measures.First().qty; 
            Assert.AreEqual(correct, returned);
        }
    }
}
