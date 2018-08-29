using System.Linq;
using System.Threading.Tasks;
using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.IngredientControllerDetailMethodShouldFor
{
    [TestClass]
    public class GreatValueDarkRedKidneyBeans45056370 : IngredientControllerDetailMethodShould
    { 

        [TestInitialize]
        public new async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync);
            searchText = "45056370";
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
            var correct = "DARK RED KIDNEY BEANS, UPC: 078742370859";
            var returned = model.Description;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HaveIngredients()
        { 
            var correct = "PREPARED KIDNEY BEANS, WATER, SUGAR, SALT, CALCIUM CHLORIDE (FIRMING AGENT), DISODIUM EDTA ADDED TO PROMOTE COLOR RETENTION.";
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
            var correct = 1.79M;   // db
            var returned = model.Iron;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void IronDailyPercentage()
        {
            var correct = 9;  // round 1.79 to 2, 9
            var returned = model.IronPercentageDailyValue;
            Assert.AreEqual(correct, returned);
        }
    }
}
