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
    public class IngredientControllerShowResultsMethodShouldForDicedPeaches:  IngredientControllerShowResultsMethodShould
    { 

        [TestInitialize]
        public new async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync);
            searchText = "45032698";
            viewResult = (ViewResult)(await Controller.ShowResults(searchText));
            model = (ListOfFoodsViewModel)viewResult.Model;
        }
         
        [TestMethod]
        public void HaveQuery()
        {
            var correct = "45032698";
            var returned = model.Query;
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void HaveNameCorrectInFirst()
        { 
            var correct = "DICED PEACHES, UPC: 078742212050";
            var returned = model.FoodItems.First().Name;
            Assert.AreEqual(correct, returned);
        }
     
        [TestMethod]
        public void HaveIngredientsCorrectInFirst()
        { 
            var correct = "DICED PEACHES, WATER, SUGAR, NATURAL FLAVORS, ASCORBIC ACID (VITAMIN C) TO PROTECT COLOR, CITRIC ACID.";
            var returned = model.FoodItems.First().Ingredients;
            Assert.AreEqual(correct, returned);
        } 
    }
}
