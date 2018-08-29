using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.IngredientControllerDetailMethodShouldFor
{
    [TestClass]
    public class GreatValuePorkAndBeansInTomatoSauce45056553 : IngredientControllerDetailMethodShould
    { 

        [TestInitialize]
        public new async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync);
            searchText = "45056553";
            viewResult = await Controller.Details(searchText);
            model = (UsdaFoodReportViewModel)viewResult.Model;
        }
         
        [TestMethod]
        public void HaveNdbno()
        {
            var correct = searchText;
            var returned = model.Ndbno;
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void HaveName()
        { 
            var correct = "PORK & BEANS IN TOMATO SAUCE, UPC: 078742370842";
            var returned = model.Description;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HaveIngredients()
        { 
            var correct = "PREPARED WHITE BEANS, WATER, TOMATO PUREE (WATER, TOMATO PASTE), SUGAR, CONTAINS LESS THAN 2% OF: HIGH FRUCTOSE CORN SYRUP, SALT, DISTILLED VINEGAR, PORK, BAKING SODA, ONION POWDER, NATURAL AND ARTIFICIAL FLAVORS, SPICE, CALCIUM CHLORIDE (A FIRMING AGENT).";
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
        public void Iron()
        {
            var correct = 1.44M; // can has 2
            var returned = model.Iron;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void IronDailyPercentage()
        {
            var correct = 8; //  can has 10 
             var returned = model.IronPercentageDailyValue;
            Assert.AreEqual(correct, returned);
        }
    }
}
