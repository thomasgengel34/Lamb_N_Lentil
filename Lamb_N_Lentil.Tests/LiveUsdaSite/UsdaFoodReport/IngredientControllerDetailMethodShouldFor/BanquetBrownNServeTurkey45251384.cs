using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.IngredientControllerDetailMethodShouldFor
{
    [TestClass]
    public class  BanquetBrownNServeTurkey45251384 : IngredientControllerDetailMethodShould
    { 

        [TestInitialize]
        public new async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync, usdaAsyncFoodReport);
            searchText = "45251384";
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
            var correct = "BANQUET, BROWN 'N SERVE, FULLY COOKED SAUSAGE LINKS, TURKEY, UPC: 031000184629";
            var returned = model.Description;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HaveIngredients()
        { 
            var correct = "TURKEY MECHANICALLY SEPARATED TURKEY, WATER, SOY PROTEIN CONCENTRATE, CONTAINS LESS THAN 2% OF: DEXTROSE, SALT, SUGAR, SPICES, CORN SYRUP, NATURAL FLAVOR, CITRIC ACID, BHA BHT.";
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
            var correct = 0;
            var returned = model.ThiaminePercentageDailyValue;
            Assert.AreEqual(correct, returned);
        }
    }
}
