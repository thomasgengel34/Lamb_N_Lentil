using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.Domain.UsdaInformation.List;
using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.MockUsdaSite.MockUsdaSiteFoodList
{
    [TestClass]
    public class IngredientControllerLeastFiveCarbohydratesShouldForMockedEgg 
    {
        private protected readonly IUsdaAsync usdaAsync = new
            MockUsdaAsyncFoodList();
        private protected readonly UsdaListofFoods usdaAsyncFoodList = new  UsdaListofFoods();
        private protected IngredientsController Controller;
        private protected ViewResult viewResult;
        private protected string searchText;
        private protected ListOfFoodsViewModel model;
        private ListOfFoodsViewModel ListOfFoodsViewModel { get; set; }

        [TestInitialize]
        public  async Task Start() => model = await GetModel();



        public async Task<ListOfFoodsViewModel> GetModel()
        {
            Controller = new IngredientsController(null, usdaAsync);
            searchText = "MockedEgg";
            viewResult = (ViewResult)(await Controller.LeastFiveCarbohydrates(searchText));
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

        [TestMethod]   
        public void HaveNdbnos()
        {
            List<string> correct = new List<string>
            { "carb5","carb4" ,"carb3","carb2"  ,  "carb1"   }; 
            List<string> returned = model.FoodItems.Select(t => t.Ndbno).ToList();

            CollectionAssert.AreEqual(correct, returned ); 
        } 

        [TestMethod]
        public void HaveCarbohydratesInIncreasingOrder54321()
        {
            List<decimal> correct = new List<decimal>
            {   1,2,3,4,5 };
            List<decimal> returned = model.FoodItems.Select(t => t.TotalCarbohydrate).ToList();
            CollectionAssert.AreEqual(correct, returned); 
        }
    }
}