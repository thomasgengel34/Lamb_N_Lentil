using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.IngredientControllerDetailMethodShouldFor
{
    [TestClass]
    public class  GreatValueGardenRotini45058106 : IngredientControllerDetailMethodShould
    { 

        [TestInitialize]
        public new async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync);
            searchText = "45058106";
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
            var correct = "GARDEN ROTINI, UPC: 078742228679";
            var returned = model.Description;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HaveIngredients()
        { 
            var correct = "SEMOLINA, DURUM FLOUR, SPINACH POWDER, TOMATO POWDER, NIACIN, FERROUS SULFATE (IRON), THIAMINE MONONITRATE, RIBOFLAVIN, FOLIC ACID.";
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
            var correct = 0.56M;
            var returned = model.Thiamine ;
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void ThiamineDailyPercentage()
        {
            var correct = 37;
            var returned = model.ThiaminePercentageDailyValue;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void FolicAcidDailyPercentage()
        {
            var correct = 0;   // box has 25
            var returned = model.FolicAcidPercentageDailyValue;
            Assert.AreEqual(correct, returned);
        }
    }
}
