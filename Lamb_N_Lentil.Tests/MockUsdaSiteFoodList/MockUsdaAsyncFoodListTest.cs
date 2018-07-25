using System.Linq;
using System.Threading.Tasks;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.Tests.MockUsdaSiteFoodReport;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.MockUsdaAsyncSiteFoodList
{   
    [TestClass]
    public class MockUsdaAsyncFoodListTest  
    {
        private readonly IUsdaAsync usdaAsync = new MockUsdaAsyncFoodList();
        private IUsdaAsync usdaAsyncFoodReport = new MockUsdaAsyncFoodReportTest(); 

        [TestMethod]
        public void ReduceStringLengthToWhatWillWorkOnUsdaWillNotThrowErrorWithEmptyString()
        {
            string result = UsdaAsync.ReduceStringLengthToWhatWillWorkOnUSDA("");
        }

        [TestMethod]
        public void ReduceStringLengthToWhatWillWorkOnUsdaWillNotThrowErrorWithNullString()
        {
            string result = UsdaAsync.ReduceStringLengthToWhatWillWorkOnUSDA(null);
        }

        [TestMethod]
        public void ReduceStringLengthToWhatWillWorkOnUsdaWillReduceStringToCorrectLength()
        {
            int correctLength = 43;
            string testString = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            int testStringLength = testString.Length;
            int whatTestStringLengthShouldBe = 87;

            string returnedString = UsdaAsync.ReduceStringLengthToWhatWillWorkOnUSDA(testString);

            Assert.AreEqual(whatTestStringLengthShouldBe, testStringLength);
            Assert.AreEqual(correctLength, returnedString.Length);
        }

        [TestMethod]
        public async Task ReturnIngredientsInIngredientInFoodReport()
        {
            string testString = "ShouldReturnIngredients";
            string correctIngredients = "ing-desc";
            UsdaFoodReport report = await usdaAsyncFoodReport.FetchUsdaFoodReport(testString);
                string returnedIngredients = report.foods.First().food.ing.desc;
           Assert.AreEqual(correctIngredients, returnedIngredients);
        } 
    }   
}
