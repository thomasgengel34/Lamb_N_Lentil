using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodList
{
    [TestClass]
    public class IngredientControllerShowResultsMethodShouldForNoTextEntered : IngredientControllerShowResultsMethodShould
    {
        ListOfFoodsViewModel foo { get; set; }

        [TestInitialize]
        public async Task Start() => model = await GetModel();



        public async Task<ListOfFoodsViewModel> GetModel()
        {
            Controller = new IngredientsController(null, usdaAsync);
            searchText = "";
            viewResult = (ViewResult)(await Controller.ShowResults(searchText));
            model = (ListOfFoodsViewModel)viewResult.Model;
            return model;
        }

        [TestMethod]
        public async Task HasEmptyString()
        {
            searchText = "";
            viewResult = (ViewResult)(await Controller.ShowResults(searchText));
            var correct = "No text was entered.  Please enter something.";
            var returned = ((ListOfFoodsViewModel)viewResult.Model).ReturnStatusTextToDisplay;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public async Task HasNullString()
        {
            searchText = null;
            viewResult = (ViewResult)(await Controller.ShowResults(searchText));
            var correct = "No text was entered.  Please enter something.";
            var returned = ((ListOfFoodsViewModel)viewResult.Model).ReturnStatusTextToDisplay;
            Assert.AreEqual(correct, returned);
        }

    }
}



