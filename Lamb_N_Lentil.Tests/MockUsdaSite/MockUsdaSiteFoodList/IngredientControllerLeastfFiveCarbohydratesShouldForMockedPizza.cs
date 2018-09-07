using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.Domain.UsdaInformation.List;
using Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodList;
using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.MockUsdaSite.MockUsdaSiteFoodList
{
    [TestClass]
    public class IngredientControllerLeastFiveCarbohydratesShouldForMockedPizza 
    {
        private protected readonly IUsdaAsync usdaAsyncFoodList = new
            MockUsdaAsyncFoodList();
         
        private protected IngredientsController Controller;
        private protected ViewResult viewResult;
        private protected string searchText;
        private protected ListOfFoodsViewModel model;
        private ListOfFoodsViewModel ListOfFoodsViewModel { get; set; }

        [TestInitialize]
        public  async Task Start() => model = await GetModel();



        public async Task<ListOfFoodsViewModel> GetModel()
        {
            Controller = new IngredientsController(null, usdaAsyncFoodList);
            searchText = "MockedPizza";
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
        public void HaveCarbohydratesInIncreasingOrder()
        {
            List<decimal> correct = new List<decimal>
            {   1,2,3,4,5 };
            List<decimal> returned = model.FoodItems.Select(t => t.TotalCarbohydrate).ToList();
            CollectionAssert.AreEqual(correct, returned); 
        }
    }
}