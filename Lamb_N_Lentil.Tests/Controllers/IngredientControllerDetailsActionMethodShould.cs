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
 /*   [TestClass]
    public class IngredientControllerDetailsActionMethodShouldProduceAnIngredientDetailViewModelWith
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
        public void MyTestMethod1()
        {
         //   Controller = new IngredientsController(null, asyncFoodList, asyncFoodReport);
         //   vr = await Controller.Details("ShouldReturnIngredients");
            string returned  = model.Label;
            Assert.AreEqual("I am a label", returned );
        }

        [TestMethod]
        public void ALabel()
        {
            string returned = model.Label;
            Assert.AreEqual("I am a label", returned );
        }

        [TestMethod]
        public void AnEqv()
        {
            decimal returned = model.Eqv;
            decimal correct = 3.1415926M;
            Assert.IsNotNull(returned);
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void TotalFat()
        {
            decimal correct = 654.2M;
            decimal returned = model.TotalFat;
            Assert.IsNotNull(returned);
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Sodium()
        {
            decimal correct = 143.0M;
            decimal returned = model.Sodium;
            Assert.IsNotNull(returned);
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void TotalCarbohydrate()
        {
            decimal correct = 77.04M;
            decimal returned = model.TotalCarbohydrate;
            Assert.IsNotNull(returned);
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void PolyunsaturatedFat()
        {
            decimal correct = 736.08M;
            decimal returned = model.PolyunsaturatedFat;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void MonounsaturatedFat()
        {
            decimal correct = 81.92M;
            decimal returned = model.MonounsaturatedFat;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Cholesterol()
        {
            decimal correct = 82.93M;
            decimal returned = model.Cholesterol;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void TransFat()
        {
            decimal correct = 101.01M;
            decimal returned = model.TransFat;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Sugars()
        {
            decimal correct = 14.30M;
            decimal returned = model.Sugars;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Protein()
        {
            decimal correct = 7.15M;
            decimal returned = model.Protein;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void VitaminA()
        {
            decimal correct = 101.02M;
            decimal returned = model.VitaminA;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void VitaminC()
        {
            decimal correct = 1.8M;
            decimal returned = model.VitaminC;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Calcium()
        {
            decimal correct = 0.95M;
            decimal returned = model.Calcium;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Iron()
        {
            decimal correct = 0.114M;
            decimal returned = model.Iron;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void VitaminD()
        {
            decimal correct = 0.228M;
            decimal returned = model.VitaminD;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Thiamine()
        {
            decimal correct = 1.228M;
            decimal returned = model.Thiamine;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Riboflavin()
        {
            decimal correct = 3.333M;
            decimal returned = model.Riboflavin;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Magnesium()
        {
            decimal correct = 22.23M;
            decimal returned = model.Magnesium;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Niacin()
        {
            decimal correct = 21.045M;
            decimal returned = model.Niacin;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void VitaminB6()
        {
            decimal correct = 76.05M;
            decimal returned = model.VitaminB6;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void VitaminB12()
        {
            decimal correct = 71.055M;
            decimal returned = model.VitaminB12;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void FoodGroup()
        {
            string correct = "default food group";
            string returned = model.ManufacturerOrFoodGroup;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public async Task Manufacturer()
        {
            string correct = "default manufacturer";
            var controller = new IngredientsController(null, asyncFoodList, asyncFoodReport);
            vr = await controller.Details("ManufacturerNotFoodGroup");
            model = (IngredientViewModel)vr.Model;
            string returned = model.ManufacturerOrFoodGroup;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public async Task NoManufacturerOrFoodGroup()
        {
            string correct = "not provided";
            var controller = new IngredientsController(null, asyncFoodList, asyncFoodReport);
            vr = await controller.Details("NoManufacturerOrFoodGroup");
            model = (IngredientViewModel)vr.Model;
            string returned = model.ManufacturerOrFoodGroup;
            Assert.AreEqual(correct, returned);
        }
    }    */
}
