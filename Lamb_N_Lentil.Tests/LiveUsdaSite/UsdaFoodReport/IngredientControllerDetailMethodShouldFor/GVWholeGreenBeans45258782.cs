using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.IngredientControllerDetailMethodShouldFor
{
    [TestClass]
    public class GVWholeGreenBeans45258782 : IngredientControllerDetailMethodShould
    { 

        [TestInitialize]
        public new async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync, usdaAsyncFoodReport);
            searchText = "45258782";
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
            var correct = "WHOLE GREEN BEANS, UPC: 078742369426";
            var returned = model.Description;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HaveIngredients()
        { 
            var correct = "GREEN BEANS, WATER, SALT.";
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
            var correct = 0.00M;
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
          //  AcceptIfOffByOne(correct, returned);
        }
         
    }
}
