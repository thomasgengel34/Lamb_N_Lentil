using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.IngredientControllerDetailMethodShouldFor
{
    [TestClass]
    public class  GreatValueOriginalSaltines45042577 : IngredientControllerDetailMethodShould
    { 

        [TestInitialize]
        public new async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync, usdaAsyncFoodReport);
            searchText = "45042577";
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
            var correct = "SALTINE CRACKERS, UPC: 078742351414";
            var returned = model.Description;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HaveIngredients()
        { 
            var correct = "ENRICHED FLOUR (WHEAT FLOUR, NIACIN, REDUCED IRON, THIAMINE MONONITRATE, RIBOFLAVIN, FOLIC ACID), VEGETABLE OIL (CONTAINS ONE OR MORE OF THE FOLLOWING: CANOLA OIL, CORN OIL, PALM OIL, SOYBEAN OIL), SALT, CONTAINS 2% OR LESS OF THE FOLLOWING: SODIUM BICARBONATE (LEAVENING), WHEAT GLUTEN, MALTED BARLEY FLOUR, YEAST.";
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
        public void TotalFat()
        {
            var correct = 1.50m;
            var returned = model.TotalFat;
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void TotalFatDailyPercentage()
        {
            var correct = 2;
            var returned = model.TotalFatPercentageDailyValue;
            AcceptIfOffByOne(correct, returned);
        }

        [TestMethod]
        public void Iron()
        {
            var correct = 1.08m;
            var returned = model.Iron;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void IronDailyPercentage()
        {
            var correct = 4;
            var returned = model.IronPercentageDailyValue;
            Assert.AreEqual(correct, returned);
          //  AcceptIfOffByOne(correct, returned);
        }


        [TestMethod]
        public void ThiamineDailyPercentage()
        {
            var correct = 0;
            var returned = model.ThiaminePercentageDailyValue;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void FolicAcidDailyPercentage()
        {
            var correct = 6;
            var returned = model.FolicAcidPercentageDailyValue;
            Assert.AreEqual(correct, returned);
        }

    }
}
