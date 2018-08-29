using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.IngredientControllerDetailMethodShouldFor
{
    [TestClass]
    public class PillsburyGrandsJuniorsSouthernHomestyle45237923 : IngredientControllerDetailMethodShould
    { 

        [TestInitialize]
        public new async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync);
            searchText = "45237923";
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
            var correct = "SOUTHERN HOMESTYLE BISCUITS, UPC: 01811205";
            var returned = model.Description;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HaveIngredients()
        { 
            var correct = "ENRICHED FLOUR BLEACHED (WHEAT FLOUR, NIACIN, FERROUS SULFATE, THIAMIN MONONITRATE, RIBOFLAVIN, FOLIC ACID), WATER, SOYBEAN AND PALM OIL, DEXTROSE, BAKING POWDER (BAKING SODA, SODIUM ACID PYROPHOSPHATE, SODIUM ALUMINUM PHOSPHATE). CONTAINS 2% OR LESS OF: SUGAR, HYDROGENATED SOYBEAN OIL, SALT, POTASSIUM CHLORIDE, NATURAL AND ARTIFICIAL FLAVOR.";
            var returned = model.Ingredients;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectNumberOfNutrients()
        {
            var correct = 14;
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
