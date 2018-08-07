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
    public class IngredientControllerShowResultsMethodShouldForButter : IngredientControllerShowResultsMethodShould
    {
        ListOfFoodsViewModel foo { get; set; }

        [TestInitialize]
        public async Task Start()
        {
            model = await GetModel();
        }



        public async Task<ListOfFoodsViewModel> GetModel()
        {
            Controller = new IngredientsController(null, usdaAsync);
            searchText = "Butter";
            viewResult = (ViewResult)(await Controller.ShowResults(searchText));
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
            List<string> correct = new List<string>{"45093459", "45112260",
 "01323",
 "04585",
 "45123923",
 "45310372",
 "45310353",
 "45309706",
 "45309609",
 "45309598",
 "45156970",
 "45166932",
 "45091154",
 "45091155",
 "45340897",
 "45093454",
 "45093440",
 "45093419",
 "45170191",
 "45167682",
 "45246152",
 "45307774",
 "45360742",
 "45164967",
 "45324602",
 "45365441",
 "45312263",
 "45015542",
 "45192259",
 "45192268",
 "45192267",
 "45160382",
 "45053371",
 "45348887",
 "45216796",
 "45187982",
 "45160006",
 "45021625",
 "45284723",
 "45357193",
 "45188178",
 "45017392",
 "45064086",
 "45165309",
 "45291096",
 "45144034",
 "45038484",
 "45037291",
 "45036114",
 "45091165"};
            List<string> returned = model.FoodItems.Select(t => t.Ndbno).ToList<string>();

            CollectionAssert.AreEqual(correct, returned);
        } 
    }
} 

 

