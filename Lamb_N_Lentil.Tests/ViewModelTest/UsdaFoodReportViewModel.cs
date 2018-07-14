using Lamb_N_Lentil.Domain;
using Lamb_N_Lentil.Tests.Classes;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace Lamb_N_Lentil.Tests.ViewModelTest
{
    [TestClass]
    public class UsdaFoodReportViewModel : Common
    {

        Type type;
        PropertyInfo pInfo;

        public UsdaFoodReportViewModel()
        {
            type = typeof(UI.Models.UsdaFoodReportViewModel);
        }

        [TestMethod]
        public void HaveNdbnoProperty()
        {
            pInfo = type.GetProperty("Ndbno");
            Assert.AreEqual("Ndbno", pInfo.Name);
        }

        [TestMethod]
        public void HaveDescriptionProperty()
        {
             pInfo = type.GetProperty("Description");
            Assert.AreEqual("Description", pInfo.Name);
        }

        [TestMethod]
        public void HaveIngredientInIngredientsProperty()
        {
             pInfo = type.GetProperty("Ingredients");
            Assert.AreEqual("Ingredients", pInfo.Name);
        }

        [TestMethod]
        public void HaveSaturatedFatProperty()
        {
            pInfo = type.GetProperty("SaturatedFat");
            Assert.AreEqual("SaturatedFat", pInfo.Name);
        }

        [TestMethod]
        public void HaveSodiumProperty()
        {
            pInfo = type.GetProperty("Sodium");
            Assert.AreEqual("Sodium", pInfo.Name);
        }


        [TestMethod]
        public void HaveTransFatProperty()
        {
            pInfo = type.GetProperty("TransFat");
            Assert.AreEqual("TransFat", pInfo.Name);
        }


        [TestMethod]
        public void HavePolyunsaturatedFatProperty()
        {
            pInfo = type.GetProperty("PolyunsaturatedFat");
            Assert.AreEqual("PolyunsaturatedFat", pInfo.Name);
        }

        [TestMethod]
        public void HaveMonounsaturatedFatProperty()
        {
            pInfo = type.GetProperty("MonounsaturatedFat");
            Assert.AreEqual("MonounsaturatedFat", pInfo.Name);
        }

        [TestMethod]
        public void HaveCholesterolProperty()
        {
            pInfo = type.GetProperty("Cholesterol");
            Assert.AreEqual("Cholesterol", pInfo.Name);
        }

        [TestMethod]
        public void HavePotassiumProperty()
        {
            pInfo = type.GetProperty("Potassium");
            Assert.AreEqual("Potassium", pInfo.Name);
        }

        [TestMethod]
        public void HaveDietaryFiberProperty()
        {
            pInfo = type.GetProperty("DietaryFiber");
            Assert.AreEqual("DietaryFiber", pInfo.Name);
        }

        [TestMethod]
        public void HaveSugarsProperty()
        {
            pInfo = type.GetProperty("Sugars");
            Assert.AreEqual("Sugars", pInfo.Name);
        }

        [TestMethod]
        public void HaveProteinProperty()
        {
            pInfo = type.GetProperty("Protein");
            Assert.AreEqual("Protein", pInfo.Name);
        }

        [TestMethod]
        public void HaveVitaminAProperty()
        {
            pInfo = type.GetProperty("VitaminA");
            Assert.AreEqual("VitaminA", pInfo.Name);
        }

        [TestMethod]
        public void HaveVitaminCProperty()
        {
            pInfo = type.GetProperty("VitaminC");
            Assert.AreEqual("VitaminC", pInfo.Name);
        }

        [TestMethod]
        public void HaveVitaminDProperty()
        {
            pInfo = type.GetProperty("VitaminD");
            Assert.AreEqual("VitaminD", pInfo.Name);
        }


        [TestMethod]
        public void HaveCalciumProperty()
        {
            pInfo = type.GetProperty("Calcium");
            Assert.AreEqual("Calcium", pInfo.Name);
        }

        [TestMethod]
        public void HaveIronProperty()
        {
            pInfo = type.GetProperty("Iron");
            Assert.AreEqual("Iron", pInfo.Name);
        }

        [TestMethod]
        public void HaveRiboflavinProperty()
        {
            pInfo = type.GetProperty("Riboflavin");
            Assert.AreEqual("Riboflavin", pInfo.Name);
        }

        [TestMethod]
        public void HaveThiamineProperty()
        {
            pInfo = type.GetProperty("Thiamine");
            Assert.AreEqual("Thiamine", pInfo.Name);
        }

        [TestMethod]
        public void HaveNiacinProperty()
        {
            pInfo = type.GetProperty("Niacin");
            Assert.AreEqual("Niacin", pInfo.Name);
        }

        [TestMethod]
        public void HaveVitaminB6Property()
        {
            pInfo = type.GetProperty("VitaminB6");
            Assert.AreEqual("VitaminB6", pInfo.Name);
        }

        [TestMethod]
        public void HaveVitaminB12Property()
        {
            pInfo = type.GetProperty("VitaminB12");
            Assert.AreEqual("VitaminB12", pInfo.Name);
        }

        [TestMethod]
        public void HaveMagnesiumProperty()
        {
            pInfo = type.GetProperty("Magnesium");
            Assert.AreEqual("Magnesium", pInfo.Name);
        }

        [TestMethod]
        public void HaveFolicAcidProperty()
        {
            pInfo = type.GetProperty("FolicAcid");
            Assert.AreEqual("FolicAcid", pInfo.Name);
        }

        [TestMethod]
        public void HaveMapUsdaFoodReportToItsViewModelMethod()
        {
            var mInfo = type.GetMethod("MapUsdaFoodReportToItsViewModel");
            Assert.AreEqual("MapUsdaFoodReportToItsViewModel", mInfo.Name);
        }

        [TestMethod]
        public void HaveGetNutrientUnitMethod()
        {
            MethodInfo mInfo = type.GetMethod("GetNutrientUnit", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            Assert.AreEqual("GetNutrientUnit", mInfo.Name);
        }

        [TestMethod]
        public void HaveGetNutrientValueMethod()
        {
            MethodInfo mInfo = type.GetMethod("GetNutrientValue", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            Assert.AreEqual("GetNutrientValue", mInfo.Name);
        }
    }
}
