using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport
{
    [TestClass]
    public class IngredientControllerDetailMethodShouldForDicedPeaches:IngredientControllerDetailMethodShould
    { 

        [TestInitialize]
        public new async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync, usdaAsyncFoodReport);
            searchText = "45032698";
            viewResult = await Controller.Details(searchText);
            model = (UsdaFoodReportViewModel)viewResult.Model;
        }
         
        [TestMethod]
        public void HaveNdbno()
        {
            var correct = "45032698";
            var returned = model.Ndbno;
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void HaveName()
        { 
            var correct = "DICED PEACHES, UPC: 078742212050";
            var returned = model.Description;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HaveIngredients()
        { 
            var correct = "DICED PEACHES, WATER, SUGAR, NATURAL FLAVORS, ASCORBIC ACID (VITAMIN C) TO PROTECT COLOR, CITRIC ACID.";
            var returned = model.Ingredients;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectNumberOfNutrients()
        {
            var correct = 17;
            var returned = model.Nutrients.Count();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectNameForFirstNutrient()
        {
            var correct = "Energy";
            var returned = model.Nutrients.First().Name;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectNameForLastNutrient()
        {
            var correct = "Cholesterol";
            var returned = model.Nutrients.Last().Name;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectIDForFirstNutrient()
        {
            var correct = 208;
            var returned = model.Nutrients.First().ID;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectIDForLastNutrient()
        {
            var correct = 601;
            var returned = model.Nutrients.Last().ID;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectLabelForFirstMeasureInFirstNutrient()
        {
            var correct = "BOWL";
            var returned = model.Nutrients.First().Measures.First().Label;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectQuantityForFirstMeasureInFirstNutrient()
        {
            var correct =  1.0M;
            var returned = model.Nutrients.First().Measures.First().Quantity;
            Assert.AreEqual(correct, returned);
        } 

        [TestMethod]
        public void HasCorrectValueForFirstMeasureInFirstNutrient()
        {
            var correct = 80.0M;
            var returned = model.Nutrients.First().Measures.First().Value;
            Assert.AreEqual(correct, returned);
        } 

        [TestMethod]
        public void HasCorrectValueForFirstMeasureInCalories()
        {
            var correct = 80 ;
            var returned = model.Calories; 
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectValueForFirstMeasureInTotalFat()
        {
            var correct = 0;
            var returned = model.TotalFat;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectUnitForFirstMeasureInTotalFat()
        {
            var correct = "g";
            var returned = model.TotalFatUnit;
            Assert.AreEqual(correct, returned);
        }
    }
}
