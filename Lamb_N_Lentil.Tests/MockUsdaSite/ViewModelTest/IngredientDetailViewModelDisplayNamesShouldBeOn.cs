using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using _UsdaFoodReportViewModel=Lamb_N_Lentil.UI.Models.UsdaFoodReportViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.ViewModelTest
{ 
    [TestClass]
    public class IngredientDetailViewModelDisplayNamesShouldBeOn
    {
        [TestMethod]
        public void ShouldHaveCorrectDisplayNamePropertyOnUpdateDate()
        {
            var pInfo = typeof(_UsdaFoodReportViewModel).GetProperty("UpdateDate")
                                .GetCustomAttributes(typeof(DisplayAttribute), false)
                                .Cast<DisplayAttribute>().FirstOrDefault();
            var name = pInfo.Name;

            Assert.AreEqual("Update Date", name);
        }

        [TestMethod]
        public void ShouldHaveCorrectDisplayNamePropertyOnSaturatedFat()
        { 
            var pInfo = typeof(_UsdaFoodReportViewModel).GetProperty("SaturatedFat")
                                .GetCustomAttributes(typeof(DisplayAttribute), false)
                                .Cast<DisplayAttribute>().FirstOrDefault();
            var name = pInfo.Name;

            Assert.AreEqual("Saturated Fat", name);
        }

         [TestMethod]
        public void ShouldHaveCorrectDisplayNamePropertyOnTransFat()
        {
            var pInfo = typeof(_UsdaFoodReportViewModel).GetProperty("TransFat")
                                .GetCustomAttributes(typeof(DisplayAttribute), false)
                                .Cast<DisplayAttribute>().FirstOrDefault();
            var name = pInfo.Name;

            Assert.AreEqual("Trans Fat", name);
        }

        [TestMethod]
        public void ShouldHaveCorrectDisplayNamePropertyOnPolyunsaturatedFat()
        {
            var pInfo = typeof(_UsdaFoodReportViewModel).GetProperty("PolyunsaturatedFat")
                                .GetCustomAttributes(typeof(DisplayAttribute), false)
                                .Cast<DisplayAttribute>().FirstOrDefault();
            var name = pInfo.Name;

            Assert.AreEqual("Polyunsaturated Fat", name);
        }

        [TestMethod]
        public void ShouldHaveCorrectDisplayNamePropertyOnMonunsaturatedFat()
        {
            var pInfo = typeof(_UsdaFoodReportViewModel).GetProperty("MonounsaturatedFat")
                                .GetCustomAttributes(typeof(DisplayAttribute), false)
                                .Cast<DisplayAttribute>().FirstOrDefault();
            var name = pInfo.Name;

            Assert.AreEqual("Monounsaturated Fat", name);
        }

        [TestMethod]
        public void ShouldHaveCorrectDisplayNamePropertyOnDietaryFiber()
        {
            var pInfo = typeof(_UsdaFoodReportViewModel).GetProperty("DietaryFiber")
                                .GetCustomAttributes(typeof(DisplayAttribute), false)
                                .Cast<DisplayAttribute>().FirstOrDefault();
            var name = pInfo.Name;

            Assert.AreEqual("Dietary Fiber", name);
        }

        [TestMethod]
        public void ShouldHaveCorrectDisplayNamePropertyOnVitaminA()
        {
            var pInfo = typeof(_UsdaFoodReportViewModel).GetProperty("VitaminA")
                                .GetCustomAttributes(typeof(DisplayAttribute), false)
                                .Cast<DisplayAttribute>().FirstOrDefault();
            var name = pInfo.Name;

            Assert.AreEqual("Vitamin A", name);
        }

        [TestMethod]
        public void ShouldHaveCorrectDisplayNamePropertyOnVitaminC()
        {
            var pInfo = typeof(_UsdaFoodReportViewModel).GetProperty("VitaminC")
                                .GetCustomAttributes(typeof(DisplayAttribute), false)
                                .Cast<DisplayAttribute>().FirstOrDefault();
            var name = pInfo.Name;

            Assert.AreEqual("Vitamin C", name);
        }

        [TestMethod]
        public void ShouldHaveCorrectDisplayNamePropertyOnVitaminD()
        {
            var pInfo = typeof(_UsdaFoodReportViewModel).GetProperty("VitaminD")
                                .GetCustomAttributes(typeof(DisplayAttribute), false)
                                .Cast<DisplayAttribute>().FirstOrDefault();
            var name = pInfo.Name;

            Assert.AreEqual("Vitamin D", name);
        }

        [TestMethod]
        public void ShouldHaveCorrectDisplayNamePropertyOnThiamine()
        {
            var pInfo = typeof(_UsdaFoodReportViewModel).GetProperty("Thiamine")
                                .GetCustomAttributes(typeof(DisplayAttribute), false)
                                .Cast<DisplayAttribute>().FirstOrDefault();
            var name = pInfo.Name;

            Assert.AreEqual("Thiamine (Vitamin B-1)", name);
        }

        [TestMethod]
        public void ShouldHaveCorrectDisplayNamePropertyOnRiboflavin()
        {
            var pInfo = typeof(_UsdaFoodReportViewModel).GetProperty("Riboflavin")
                                .GetCustomAttributes(typeof(DisplayAttribute), false)
                                .Cast<DisplayAttribute>().FirstOrDefault();
            var name = pInfo.Name;

            Assert.AreEqual("Riboflavin (Vitamin B-2)", name);
        }

        [TestMethod]
        public void ShouldHaveCorrectDisplayNamePropertyOnNiacin()
        {
            var foo = typeof(_UsdaFoodReportViewModel).GetProperty("Niacin");
            var pInfo = typeof(_UsdaFoodReportViewModel).GetProperty("Niacin")
                                .GetCustomAttributes(typeof(DisplayAttribute), false)
                                .Cast<DisplayAttribute>().FirstOrDefault();
            var name = pInfo.Name;

            Assert.AreEqual("Niacin(Vitamin B-3)", name);
        }

        [TestMethod]
        public void ShouldHaveCorrectDisplayNamePropertyOnVitaminB6()
        {
            var pInfo = typeof(_UsdaFoodReportViewModel).GetProperty("VitaminB6")
                                .GetCustomAttributes(typeof(DisplayAttribute), false)
                                .Cast<DisplayAttribute>().FirstOrDefault();
            var name = pInfo.Name;

            Assert.AreEqual("Vitamin B-6", name);
        }

        [TestMethod]
        public void ShouldHaveCorrectDisplayNamePropertyOnVitaminB12()
        {
            var pInfo = typeof(_UsdaFoodReportViewModel).GetProperty("VitaminB12")
                                .GetCustomAttributes(typeof(DisplayAttribute), false)
                                .Cast<DisplayAttribute>().FirstOrDefault();
            var name = pInfo.Name;

            Assert.AreEqual("Vitamin B-12", name);
        }

        [TestMethod]
        public void ShouldHaveCorrectDisplayNamePropertyOnFolicAcid2()
        {
            var pInfo = typeof(_UsdaFoodReportViewModel).GetProperty("FolicAcid")
                                .GetCustomAttributes(typeof(DisplayAttribute), false)
                                .Cast<DisplayAttribute>().FirstOrDefault();
            var name = pInfo.Name;

            Assert.AreEqual("Folic Acid", name);
        }  
    }
}
