using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.IngredientControllerDetailMethodShouldFor
{
    [TestClass]
    public class  UnfrostedBrownSugarCinammonToasterPastries45309980 : IngredientControllerDetailMethodShould
    { 

        [TestInitialize]
        public new async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync);
            searchText = "45309980";
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
            var correct = "TOASTER PASTRIES, UPC: 038000301100";
            var returned = model.Description;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HaveIngredients()
        { 
            var correct = "ENRICHED FLOUR (WHEAT FLOUR, NIACIN, REDUCED IRON, VITAMIN B1 [THIAMIN MONONITRATE], VITAMIN B2 [RIBOFLAVIN], FOLIC ACID), SOYBEAN AND PALM OIL (WITH TBHQ FOR FRESHNESS), SUGAR, CORN SYRUP, DEXTROSE, HIGH FRUCTOSE CORN SYRUP, CRACKER MEAL, CONTAINS TWO PERCENT OR LESS OF MOLASSES, SALT, CALCIUM CARBONATE, LEAVENING (BAKING SODA, SODIUM ACID PYROPHOSPHATE, MONOCALCIUM PHOSPHATE), CINNAMON, WHEAT STARCH, SOY LECITHIN, VITAMIN A PALMITATE, NIACINAMIDE, REDUCED IRON, VITAMIN B6 (PYRIDOXINE HYDROCHLORIDE), VITAMIN B2 (RIBOFLAVIN), VITAMIN B1 (THIAMIN HYDROCHLORIDE).";
            var returned = model.Ingredients;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectNumberOfNutrients()
        {
            var correct = 20;
            var returned = model.Nutrients.Count();
            Assert.AreEqual(correct, returned);
        } 
         

         
        [TestMethod]
        public void Iron()
        {
            var correct = 1.80M;  
            var returned = model.Iron;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void IronDailyPercentage()
        {
            var correct = 10;
            var returned = model.IronPercentageDailyValue;
            Assert.AreEqual(correct, returned); 
        }

        [TestMethod]
        public void Thiamine()
        {
            var correct = 0;
            var returned = model.Thiamine;
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void ThiamineDailyPercentage()
        {
            var correct = 0; // db; box has 10%
            var returned = model.ThiaminePercentageDailyValue;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void FolicAcidDailyPercentage()
        {
            var correct = 0;
            var returned = model.ThiaminePercentageDailyValue;
            Assert.AreEqual(correct, returned);
        }
    }
}
