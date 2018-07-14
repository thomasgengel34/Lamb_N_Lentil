using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.Tests.MockUsdaAsyncSiteFoodList;
using Lamb_N_Lentil.Tests.MockUsdaSiteFoodReport;
using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.Controllers
{
    /*    [TestClass]
        public class IngredientControllerDetailsActionMethodTotalPercentageShould 
        {
           private readonly IUsdaAsync asyncFoodList = new MockUsdaAsyncFoodList();
           private   readonly IUsdaAsync asyncFoodReport = new MockUsdaAsyncForFoodReport();
            private IngredientViewModel model;
            private ViewResult vr;

            public IngredientsController Controller { get; set; }

            [TestInitialize]
            public  void GetViewResultAsync()
            {
                Controller = new IngredientsController(null, asyncFoodList, asyncFoodReport); 
            }


            [TestMethod]
            public async Task ReturnPercentDailyValueOfZeroForTotalFatOfZero()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueTotalFat0");
                model = (IngredientViewModel)vr.Model;
                int correct = 0;
                int returned = model.TotalFatPercentageDailyValue;
                Assert.AreEqual(correct,returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOf100ForTotalFatOf65()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueTotalFat65");
                model = (IngredientViewModel)vr.Model;
                int correct = 100;
                int returned = model.TotalFatPercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOfZeroForSaturatedFatOfZero()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueSaturatedFat0");
                model = (IngredientViewModel)vr.Model;
                int correct = 0;
                int returned = model.SaturatedFatPercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOf100ForSaturatedFatOf20()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueSaturatedFat20");
                model = (IngredientViewModel)vr.Model;
                int correct = 100;
                int returned = model.SaturatedFatPercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOfZeroForCholesterolOfZero()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueCholesterol0");
                model = (IngredientViewModel)vr.Model;
                int correct = 0;
                int returned = model.CholesterolPercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOf100ForCholesterolOf300()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueCholesterol300");
                model = (IngredientViewModel)vr.Model;
                int correct = 100;
                int returned = model.CholesterolPercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOfZeroForSodiumOfZero()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueSodium0");
                model = (IngredientViewModel)vr.Model;
                int correct = 0;
                int returned = model.SodiumPercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOf100ForSodiumOf2400()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueSodium2400");
                model = (IngredientViewModel)vr.Model;
                int correct = 100;
                int returned = model.SodiumPercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOfZeroForPotassiumOfZero()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValuePotassium0");
                model = (IngredientViewModel)vr.Model;
                int correct = 0;
                int returned = model.PotassiumPercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOf100ForPotassiumOf3500()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValuePotassium3500");
                model = (IngredientViewModel)vr.Model;
                int correct = 100;
                int returned = model.PotassiumPercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOfZeroForTotalCarbohydrateOfZero()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueTotalCarbohydrate0");
                model = (IngredientViewModel)vr.Model;
                int correct = 0;
                int returned = model.TotalCarbohydratePercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOf100ForTotalCarbohydrateOf300()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueTotalCarbohydrate300");
                model = (IngredientViewModel)vr.Model;
                int correct = 100;
                int returned = model.TotalCarbohydratePercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOfZeroForDietaryFiberOfZero()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueDietaryFiber0");
                model = (IngredientViewModel)vr.Model;
                int correct = 0;
                int returned = model.DietaryFiberPercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOf100ForDietaryFiberOf25()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueDietaryFiber25");
                model = (IngredientViewModel)vr.Model;
                int correct = 100;
                int returned = model.DietaryFiberPercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOfZeroForVitaminAOfZero()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueVitaminA0");
                model = (IngredientViewModel)vr.Model;
                int correct = 0;
                int returned = model.VitaminAPercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOf100ForVitaminAOf5000()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueVitaminA5000");
                model = (IngredientViewModel)vr.Model;
                int correct = 100;
                int returned = model.VitaminAPercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }



            [TestMethod]
            public async Task ReturnPercentDailyValueOfZeroForVitaminCOfZero()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueVitaminC0");
                model = (IngredientViewModel)vr.Model;
                int correct = 0;
                int returned = model.VitaminCPercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOf100ForVitaminCOf60()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueVitaminC60");
                model = (IngredientViewModel)vr.Model;
                int correct = 100;
                int returned = model.VitaminCPercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOfZeroForCalciumOfZero()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueCalcium0");
                model = (IngredientViewModel)vr.Model;
                int correct = 0;
                int returned = model.CalciumPercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOf100ForCalciumOf1000()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueCalcium1000");
                model = (IngredientViewModel)vr.Model;
                int correct = 100;
                int returned = model.CalciumPercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOfZeroForIronOfZero()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueIron0");
                model = (IngredientViewModel)vr.Model;
                int correct = 0;
                int returned = model.IronPercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOf100ForIronOf20()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueIron20");
                model = (IngredientViewModel)vr.Model;
                int correct = 100;
                int returned = model.IronPercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }


            [TestMethod]
            public async Task ReturnPercentDailyValueOfZeroForThiamineOfZero()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueThiamine0");
                model = (IngredientViewModel)vr.Model;
                int correct = 0;
                int returned = model.ThiaminePercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOf100ForThiamineOf1point5()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueThiamine1point5");
                model = (IngredientViewModel)vr.Model;
                int correct = 100;
                int returned = model.ThiaminePercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }

            [TestMethod]
            public async Task ReturnPercentDailyValueOfZeroForRiboflavinOfZero()
            { 
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueRiboflavin0");
                model = (IngredientViewModel)vr.Model;
                int correct = 0;
               int returned = model.RiboflavinPercentageDailyValue;
               Assert.AreEqual(correct, returned);
            }

             [TestMethod]
            public async Task ReturnPercentDailyValueOf100ForRiboflavinOf1point7()
            {
                vr = await Controller.Details("ShouldReturnIngredientsWithPercentageDailyValueRiboflavin1point7");
                model = (IngredientViewModel)vr.Model;
                int correct = 100;
                int returned = model.RiboflavinPercentageDailyValue;
                Assert.AreEqual(correct, returned);
            }
        }
      */
}