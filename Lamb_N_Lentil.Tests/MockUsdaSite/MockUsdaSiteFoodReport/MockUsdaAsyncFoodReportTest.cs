using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.Tests.MockUsdaAsyncSiteFoodList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Lamb_N_Lentil.Tests.MockUsdaSiteFoodReport
{
    [TestClass]
    public class MockUsdaAsyncFoodReportTest : MockUsdaAsyncForFoodReport
    {
        IUsdaAsync usdaAsync;

        [TestInitialize]
        public async Task Start()
        {
            usdaAsync = new MockUsdaAsyncForFoodReport();
            var testString = "ShouldReturnIngredients";
            report = await usdaAsync.FetchUsdaFoodReport(testString);
        }


        [TestMethod]
        public void ReturnValueInFoodReport()
        {
            var correct = 654.2M;
            var returned = report.foods.First().food.nutrients[0].measures[0].value;
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void ReturnManufacturer()
        {
            var correct = "default manufacturer";
            var returned = report.foods.First().food.desc.manu;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnFoodGroup()
        {
            var correct = "default food group";
            var returned = report.foods.First().food.desc.fg;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnServingSize()
        {
            var correct = 1.0101M;
            decimal returned = report.foods.First().food.nutrients.First().measures.First().qty;
            Assert.AreEqual(correct, returned);
        }

        async internal Task<UsdaFoodReport> FetchUsdaFoodReport(string testString)
        {
            return MockUsdaAsyncFoodList.GetFoodReport(testString);
        }
    }
}
