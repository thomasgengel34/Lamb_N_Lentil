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
    public class MinisCrackers45309635 : IngredientControllerDetailMethodShould
    { 

        [TestInitialize]
        public new async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync, usdaAsyncFoodReport);
            searchText = "45309635";
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
            var correct = "MINIS CRACKERS , UPC: 030100490524";
            var returned = model.Description;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HaveIngredients()
        { 
            var correct = "ENRICHED FLOUR (WHEAT FLOUR, NIACIN, REDUCED IRON, VITAMIN B1 [THIAMIN MONONITRATE], VITAMIN B2 [RIBOFLAVIN], FOLIC ACID), CANOLA OIL WITH TBHQ FOR FRESHNESS, MODIFIED CORNSTARCH, SUGAR, CONTAINS 2% OR LESS OF SALT, LEAVENING (SODIUM ACID PYROPHOSPHATE, BAKING SODA, MONOCALCIUM PHOSPHATE), HIGH FRUCTOSE CORN SYRUP, CORN SYRUP, SOY LECITHIN.";
            var returned = model.Ingredients;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectNumberOfNutrients()
        {
            var correct = 16;
            var returned = model.Nutrients.Count();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Iron()
        {
            var correct = 0.72M;
            var returned = model.Iron;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void IronDailyPercentage()
        {
            var correct = 4;
            var returned = model.IronPercentageDailyValue;
            Assert.AreEqual(correct, returned);
        }
    }
}
