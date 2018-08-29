using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodList;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.LeastFiveCarbohydrates
{
    [TestClass]
    public class  IngredientControllerLeastfFiveCarbohydratesShouldForClarifiedGheeButter : IngredientControllerShowResultsMethodShould
    {
        ListOfFoodsViewModel ListOfFoodsViewModel { get; set; }

        [TestInitialize]
        public new async Task Start() => model = await GetModel();



        public async Task<ListOfFoodsViewModel> GetModel()
        {
            Controller = new IngredientsController(null, usdaAsync);
            searchText = "45365538";
            viewResult = (ViewResult)( await Controller.LeastFiveCarbohydrates(usdaAsync, searchText ));
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
        public void HaveNdbno()
        {
            List<string> correct = new List<string> { "45365538" };
            List<string> returned = model.FoodItems.Select(t => t.Ndbno).ToList();

            CollectionAssert.AreEqual(correct, returned);
        } 
    }
} 