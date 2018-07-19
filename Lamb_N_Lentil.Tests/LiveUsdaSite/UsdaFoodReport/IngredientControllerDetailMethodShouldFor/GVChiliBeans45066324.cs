using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.IngredientControllerDetailMethodShouldFor
{
    [TestClass]
    public class  GVChilBeans45066324 : IngredientControllerDetailMethodShould
    { 

        [TestInitialize]
        public new async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync, usdaAsyncFoodReport);
            searchText = "45066324";
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
            var correct = "CHILI BEANS, SMALL RED BEANS IN CHILI SAUCE, UPC: 078742370873";
            var returned = model.Description;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HaveIngredients()
        { 
            var correct = "PREPARED DRY BEANS, WATER, CONTAINS LESS THAN 2% OF THE FOLLOWING INGREDIENTS: SALT, CHILI POWDER (CHILI PEPPER, CUMIN, SALT, GARLIC POWDER, OREGANO), TOMATO PASTE, SUGAR, MODIFIED CORNSTARCH, CORNSTARCH, SOYBEAN OIL, PAPRIKA, SPICE, TORULA YEAST, ONION POWDER, GARLIC POWDER, OLEORESIN PAPRIKA, MUSTARD FLOUR, NATURAL FLAVORS.";
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
            var correct = 1.00m;
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
        public void SaturatedFatDailyPercentage()
        {
            var correct = 0.00m;
            var returned = model.SaturatedFatPercentageDailyValue;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void CholesterolDailyPercentage()
        {
            var correct = 0.00m;
            var returned = model.CholesterolPercentageDailyValue;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void SodiumDailyPercentage()
        {
            var correct = 20;
            var returned = model.SodiumPercentageDailyValue;
            AcceptIfOffByOne(correct, returned);
        }

        [TestMethod]
        public void Potassium()
        {
            var correct = 230.00m;
            var returned = model.Potassium;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void PotassiumUnit()
        {
            var correct = "mg";
            var returned = model.PotassiumUnit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void PotassiumDailyPercentage()
        {
            var correct = 7;
            var returned = model.PotassiumPercentageDailyValue;
            AcceptIfOffByOne(correct, returned);
        }

        [TestMethod]
        public void TotalCarbohydratesDailyPercentage()
        {
            var correct = 7 ;
            var returned = model.TotalCarbohydratePercentageDailyValue;
            AcceptIfOffByOne(correct, returned);
        }

        [TestMethod]
        public void DietaryFiberDailyPercentage()
        {
            var correct = 24.00m;
            var returned = model.DietaryFiberPercentageDailyValue;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void VitaminADailyPercentage()
        {
            var correct = 4.00m;
            var returned = model.VitaminAPercentageDailyValue; 
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void VitaminCDailyPercentage()
        {
            var correct = 0.00m;
            var returned = model.VitaminCPercentageDailyValue;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void CalciumDailyPercentage()
        {
            var correct = 4.00m;
            var returned = model.CalciumPercentageDailyValue;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Iron()
        {
            var correct = 1.44M;
            var returned = model.Iron;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void IronDailyPercentage()
        {
            var correct = 8;
            var returned = model.IronPercentageDailyValue;
            Assert.AreEqual(correct, returned);
            //AcceptIfOffByOne(correct, returned);
        }

        [TestMethod]
        public void FolicAcidDailyPercentage()
        {
            var correct = 0.00m;
            var returned = model.FolicAcidPercentageDailyValue;
            Assert.AreEqual(correct, returned);
        }
    }
}
