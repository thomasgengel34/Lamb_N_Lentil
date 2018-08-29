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
    public class CheezItGroovesCrackerChipsSharpWhiteCheddar45252231 : IngredientControllerDetailMethodShould
    { 

        [TestInitialize]
        public new async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync);
            searchText = "45252231";
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
            var correct = "CHEEZ-IT, GROOVES CRACKER CHIPS, SHARP WHITE CHEDDAR, UPC: 024100108350";
            var returned = model.Description;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HaveIngredients()
        { 
            var correct = "ENRICHED FLOUR (WHEAT FLOUR, NIACIN, REDUCED IRON, VITAMIN B1 [THIAMIN MONONITRATE], VITAMIN B2 (RIBOFLAVIN), FOLIC ACID), RICE FLOUR, VEGETABLE OIL (SOYBEAN OIL WITH TBHQ FOR FRESHNESS, PALM OIL), WHITE CHEDDAR CHEESE (MILK, CHEESE CULTURES, SALT, ENZYMES), CONTAINS TWO PERCENT OR LESS OF SUGAR, SALT, SOY LECITHIN, CHEDDAR CHEESE (MILK, CHEESE CULTURES, SALT, ENZYMES), WHEY, LEAVENING (BAKING SODA, SODIUM ACID PYROPHOSPHATE, MONOCALCIUM PHOSPHATE), MALTO- DEXTRIN, NATURAL AND ARTIFICIAL FLAVORS, MONOSODIUM GLUTAMATE, LACTIC ACID, BUTTERMILK, YEAST EXTRACT, CITRIC ACID, DISODIUM INOSINATE, DISODIUM GUANYLATE, BUTTER (CREAM, SALT).";
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
            var correct = 0.36M;
            var returned = model.Iron;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void IronDailyPercentage()
        {
            var correct = 2;
            var returned = model.IronPercentageDailyValue;
            Assert.AreEqual(correct, returned);
        }
    }
}
