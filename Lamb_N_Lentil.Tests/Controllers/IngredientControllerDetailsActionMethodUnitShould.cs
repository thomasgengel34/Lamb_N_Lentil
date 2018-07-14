using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.Tests.MockUsdaAsyncSiteFoodList;
using Lamb_N_Lentil.Tests.MockUsdaSiteFoodReport;
using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Lamb_N_Lentil.Tests.Controllers
{
  /*  [TestClass]
    public class IngredientControllerDetailsActionMethodUnitShould
    {
        private readonly IUsdaAsync asyncFoodList = new MockUsdaAsyncFoodList();
        private readonly IUsdaAsync asyncFoodReport = new MockUsdaAsyncForFoodReport();
        private IngredientViewModel model;
        private ViewResult vr;

        public IngredientsController Controller { get; set; }

        [TestInitialize]
        public async Task GetViewResultAsync()
        {
            Controller = new IngredientsController(null, asyncFoodList, asyncFoodReport);
            vr = await Controller.Details("ShouldReturnIngredients");
            model = (IngredientViewModel)vr.Model;
        }


        [TestMethod]
        public void ReturnCorrectUnitForTotalFat()
        { 
            string correct = "unit for total fat";
            string returned = model.TotalFatUnit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnCorrectUnitForSaturatedFat()
        {
            string correct = "unit for saturated fat";
            string returned = model.SaturatedFatUnit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnCorrectUnitForTransFat()
        {
            string correct = "unit for trans fat";
            string returned = model.TransFatUnit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnCorrectUnitForPolyunsaturatedFat()
        {
            string correct = "unit for polyunsaturated fat";
            string returned = model.PolyunsaturatedFatUnit;
            Assert.AreEqual(correct, returned);
        } 

        [TestMethod]
        public void ReturnCorrectUnitForMonounsaturatedFat()
        {
            string correct = "unit for monounsaturated fat";
            string returned = model.MonounsaturatedFatUnit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnCorrectUnitForCholesterol()
        {
            string correct = "unit for cholesterol";
            string returned = model.CholesterolUnit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnCorrectUnitForSodium()
        {
            string correct = "unit for sodium";
            string returned = model.SodiumUnit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnCorrectUnitForPotassium()
        {
            string correct = "unit for potassium";
            string returned = model.PotassiumUnit;
            Assert.AreEqual(correct, returned);
        }  

        [TestMethod]
        public void ReturnCorrectUnitForTotalCarbohydrate()
        {
            string correct = "unit for total carbohydrate";
            string returned = model.TotalCarbohydrateUnit;
            Assert.AreEqual(correct, returned);
        }  

        [TestMethod]
        public void ReturnCorrectUnitForDietaryFiber()
        {
            string correct = "unit for Dietary Fiber";
            string returned = model.DietaryFiberUnit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnCorrectUnitForSugars()
        {
            string correct = "unit for Sugars";
            string returned = model.SugarsUnit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnCorrectUnitForProtein()
        {
            string correct = "unit for Protein";
            string returned = model.ProteinUnit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnCorrectUnitForVitaminA()
        {
            string correct = "unit for VitaminA";
            string returned = model.VitaminAUnit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnCorrectUnitForVitaminC()
        {
            string correct = "unit for VitaminC";
            string returned = model.VitaminCUnit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnCorrectUnitForCalcium()
        {
            string correct = "unit for Calcium";
            string returned = model.CalciumUnit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnCorrectUnitForIron()
        {
            string correct = "unit for Iron";
            string returned = model.IronUnit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnCorrectUnitForThiamine()
        {
            string correct = "unit for Thiamine";
            string returned = model.ThiamineUnit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnCorrectUnitForRiboflavin()
        {
            string correct = "unit for Riboflavin";
            string returned = model.RiboflavinUnit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnCorrectUnitForNiacin()
        {
            string correct = "unit for Niacin";
            string returned = model.NiacinUnit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnCorrectUnitForFolicAcid()
        {
            string correct = "unit for folic acid";
            string returned = model.FolicAcidUnit;
            Assert.AreEqual(correct, returned);
        }
        
        [TestMethod]
        public void ReturnCorrectUnitForVitaminD()
        { 
            string correct = "unit for vitamin D";
            string returned = model.VitaminDUnit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnCorrectUnitForVitaminB12()
        {
            string correct = "unit for vitamin B12";
            string returned = model.VitaminB12Unit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnCorrectUnitForVitaminB6()
        {
            string correct = "unit for vitamin B6";
            string returned = model.VitaminB6Unit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void ReturnCorrectServingSize()
        {
            decimal correct = 1.0101M;
            decimal returned = model.ServingSize;
            Assert.AreEqual(correct, returned);
        }
    }   */
}
