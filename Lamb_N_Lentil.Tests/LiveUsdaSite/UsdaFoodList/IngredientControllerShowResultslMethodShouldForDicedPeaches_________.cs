using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodList
{
    [TestClass]
    public class IngredientControllerShowResultsMethodShouldForDicedPeaches______:  IngredientControllerShowResultsMethodShould
    { 

        [TestInitialize]
        public new async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync);
            searchText = "Diced Peaches";
            viewResult = (ViewResult)(await Controller.ShowResults(searchText));
            model = (ListOfFoodsViewModel)viewResult.Model;
        }
         
        [TestMethod]
        public void HaveQuery()
        {
            var correct = searchText;
            var returned = model.Query;
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void HaveNameCorrectInFirst()
        { 
            var correct = "DICED PEACHES & PEARS, YELLOW CLING PEACHES & BARTLETT PEARS IN ORGANIC PEAR JUICE FROM CONCENTRATE, UPC: 036800285040";
            var returned = model.FoodItems.First().Name;
            Assert.AreEqual(correct, returned);
        }
     
        [TestMethod]
        public void HaveIngredientsCorrectInFirst()
        { 
            var correct = "WATER, ORGANIC PEACHES, ORGANIC PEARS, ORGANIC PEAR JUICE CONCENTRATE, ASCORBIC ACID (VITAMIN C) TO PROTECT COLOR, CITRIC ACID.";
            var returned = model.FoodItems.First().Ingredients;
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void HaveCorrectServingSize()
        {
            var correct = "BOWL";
            var returned = model.FoodItems.First().ServingSize;
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void HaveNdbnos()
        {
            var correct = new List<string>{"45097553",
            "45356637",
            "45265781",
            "45097535",
            "45012443",
            "45029687",
            "45288561",
            "45079491",
            "45282665",
            "45276860",
            "45095641",
            "45100463",
            "45356677",
            "45356669",
            "45282522",
            "45356641",
            "45280648",
            "45356597",
            "45356912",
            "45095634",
            "45286460",
            "45346666",
            "45215104",
            "45063284",
            "45079487",
            "45323973",
            "45307665",
            "45197213",
            "45343199",
            "45021018",
            "45012352",
            "45360122",
            "45326510",
            "45326996",
            "45050898",
            "45050892",
            "45018651",
            "45323612",
            "45316608",
            "45292396",
            "45292332",
            "45195931",
            "45196024",
            "45032657",
            "45004096",
            "45032698",
            "45058184",
            "45196022",
            "45258428",
            "45345735",};
            var returned = model.FoodItems.Select(t => t.Ndbno).ToList();
            CollectionAssert.AreEqual(correct, returned);
        }
    }
} 