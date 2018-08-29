using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.IngredientControllerDetailMethodShouldFor
{
    [TestClass]
    public class GreatValueFatFreeRefriedBeans45066323 : IngredientControllerDetailMethodShould
    { 

        [TestInitialize]
        public new async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync);
            searchText = "45066323";
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
            var correct = "REFRIED BEANS, UPC: 605388186744";
            var returned = model.Description;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HaveIngredients()
        { 
            var correct = "COOKED BEANS, WATER, CONTAINS LESS THAN 2% OF: SALT, TOMATO PASTE, CHILI PEPPER, SUGAR, ONION POWDER, GARLIC POWDER, SPICE, YEAST EXTRACT.";
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
            var correct =  0m;
            var returned = model.TotalFat;
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void TotalFatDailyPercentage()
        {
            var correct = 0;
            var returned = model.TotalFatPercentageDailyValue;
            AcceptIfOffByOne(correct, returned);
        }

        [TestMethod]
        public void Iron()
        {
            var correct = 1.44m; // box 2.00m;
            var returned = model.Iron;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void IronDailyPercentage()
        {
            var correct = 8;  // box 10m;
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
            var returned = model.FolicAcidPercentageDailyValue;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void UpdateDate()
        {
            var correct = "03/11/2018";
            var returned = model.UpdateDate;
            Assert.AreEqual(correct, returned);
        }
         
    }
}
