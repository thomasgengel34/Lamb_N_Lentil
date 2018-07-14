using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lamb_N_Lentil.Domain.UsdaList;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite
{
    //[TestClass]
    //public class LiveUsdaAsyncTest
    //{
    //    public readonly IUsdaAsync usdaAsync = new UsdaAsync();
    //    public readonly IUsdaAsync usdaAsyncFoodReport = new UsdaAsyncFoodReport();

    //    [TestMethod]
    //    public void ReduceStringLengthToWhatWillWorkOnUsdaWillNotThrowErrorWithEmptyString()
    //    {
    //        string result = UsdaAsync.ReduceStringLengthToWhatWillWorkOnUSDA("");
    //    }

    //    [TestMethod]
    //    public void ReduceStringLengthToWhatWillWorkOnUsdaWillNotThrowErrorWithNullString()
    //    {
    //        string result = UsdaAsync.ReduceStringLengthToWhatWillWorkOnUSDA(null);
    //    }

    //    [TestMethod]
    //    public void ReduceStringLengthToWhatWillWorkOnUsdaWillReduceStringToCorrectLength()
    //    {
    //        int correctLength = 43;
    //        string testString = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
    //        int testStringLength = testString.Length;
    //        int whatTestStringLengthShouldBe = 87;

    //        string returnedString = UsdaAsync.ReduceStringLengthToWhatWillWorkOnUSDA(testString);

    //        Assert.AreEqual(whatTestStringLengthShouldBe, testStringLength);
    //        Assert.AreEqual(correctLength, returnedString.Length);
    //    }


    //    [TestMethod]
    //    public async Task ShouldGetListOfIngredientsFromTextSearch()
    //    {
    //        string testString = "cream";
    //       var list = await new UsdaAsync().FetchUsdaFoodList(testString);

    //        Assert.IsNotNull(list);
    //        Assert.IsInstanceOfType(list, typeof(UsdaListofFoods));
    //    }

    //    [TestMethod]
    //    public async Task ShouldCreateNewIngredientsListWhenNoResultsASreFound()
    //    {
    //        string testString = "qq";
    //        var list = await new UsdaAsync().FetchUsdaFoodList(testString);

    //        Assert.IsNotNull(list);
    //        Assert.IsInstanceOfType(list, typeof(UsdaListofFoods));
    //    }



     

    //    [TestMethod]
    //    public async Task ReturnIngredientsListInFoodReportFor078895122565()
    //    {
    //        string testString = "078895122565";
    //        string correctIngredients = "SUGAR, SALTED PLUMS (PLUMS, SALT), WATER, RICE VINEGAR, MODIFIED CORN STARCH, GINGER, CITRIC ACID, SODIUM CITRATE, CHILI PEPPERS, XANTHAN GUM.";

    //        var list = await new UsdaAsync().FetchUsdaFoodList(testString);
    //        var report = await usdaAsyncFoodReport.FetchUsdaFoodReport(list.list.item.First().ndbno);
    //        string returnedIngredients = report.foods.First().food.ing.desc;
    //        Assert.AreEqual(correctIngredients, returnedIngredients);
    //    }

    //    [TestMethod]
    //    public async Task ReturnFoodGroupFoodReportForCheddarCheese()
    //    {
    //        string testString = "01009";
    //        string correct = "Dairy and Egg Products";


    //        var report = await usdaAsyncFoodReport.FetchUsdaFoodReport(testString);

    //        string returned = report.foods.First().food.desc.fg;
    //        Assert.AreEqual(correct, returned);
    //    }
    //}
}
