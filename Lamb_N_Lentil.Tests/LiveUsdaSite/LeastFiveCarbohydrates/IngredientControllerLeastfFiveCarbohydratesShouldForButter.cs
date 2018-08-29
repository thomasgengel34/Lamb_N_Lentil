using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodList;
using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.LeastFiveCarbohydrates
{
    [TestClass]
    public class IngredientControllerLeastFiveCarbohydratesShouldForButter : IngredientControllerShowResultsMethodShould
    {
        private ListOfFoodsViewModel ListOfFoodsViewModel { get; set; }

        [TestInitialize]
        public new async Task Start() => model = await GetModel();



        public async Task<ListOfFoodsViewModel> GetModel()
        {
            Controller = new IngredientsController(null, usdaAsync);
            searchText = "Butter";
            viewResult = (ViewResult)(await Controller.LeastFiveCarbohydrates(usdaAsync, searchText));
            model = (ListOfFoodsViewModel)viewResult.Model;
            return model;
        }

        [TestMethod]
        public void HaveQuery()
        {
            var correct = searchText;
            var returned = model.Query;
            Assert.AreEqual(correct, returned);
        }

       // [TestMethod]  wait on other tests to pass
        public void HaveNdbnos()
        {
            List<string> correct = new List<string>
            {
                 "45093459" ,"45112260","01323" ,"04585" ,"45360742"    };
            List<string> returned = model.FoodItems.Select(t => t.Ndbno).ToList();

            CollectionAssert.AreEqual(correct, returned);
            Assert.Fail("test not really a test.  Need to use a mock test with controlled values to see if the sequence is correct.  And include variant info. ");
        }
        [TestMethod]
        public void HaveCarbohydratesInIncreasingOrder()
        {
            List<decimal> correct = new List<decimal>
            {  0,0,0,0,0 };
            List<decimal> returned = model.FoodItems.Select(t => t.TotalCarbohydrate).ToList();
            CollectionAssert.AreEqual(correct, returned);

        }
    }
}