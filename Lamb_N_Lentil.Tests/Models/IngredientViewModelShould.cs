using System;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.Models
{
   /* [TestClass]
    public class IngredientViewModelShould
    {
        private IIngredient ingredient;
        private string correctDescription = "description";
        private string correctIngredientsInIngredient = "various";
        private string correctNdbno = "test ndbno";
        private string correctUpdateDate = "2/4/1932";
        private string correctLabel = "cup for label";
        private decimal correctEqv = 113.0M;
        private decimal correctCalories = 43.0M;
        private decimal correctTotalCarbohydrate = 810.1M;
        private decimal correctTotalFat = 11.0M;
        private decimal correctSugars = 0.01M;

        private IngredientViewModel ivm;


        public IngredientViewModelShould()
        {
            ingredient = new Entity();
            ingredient.Description = correctDescription;
            ingredient.IngredientsInIngredient = correctIngredientsInIngredient;
            ingredient.Ndbno = correctNdbno;
            ingredient.UpdateDate = correctUpdateDate;
            ////ingredient.Label = correctLabel;
            ingredient.Eqv = correctEqv;
            //ingredient.Calories = correctCalories;
            //ingredient.TotalFat = correctTotalFat;
            //ingredient.TotalCarbohydrate = correctTotalCarbohydrate;
            //ingredient.Sugars = correctSugars;
            ivm = IngredientViewModel.MapIIngredientToIngredientDetailViewModel(ingredient);
        }

        [TestMethod]
        public void HaveCorrectDescrption()
        {
            Assert.AreEqual(correctDescription, ivm.Description);
        }

        [TestMethod]
        public void HaveCorrectIngredientsInIngredient()
        {
            Assert.AreEqual(correctIngredientsInIngredient, ivm.IngredientsInIngredient);
        }

        [TestMethod]
        public void HaveCorrectNdbno()
        {
            Assert.AreEqual(correctNdbno, ivm.Ndbno);
        }

        [TestMethod]
        public void HaveCorrectUpdateDate()
        {
            Assert.AreEqual(correctUpdateDate, ivm.UpdateDate);
        }

        [TestMethod]
        public void HaveCorrectLabel()
        {
            Assert.AreEqual(correctLabel, ivm.Label);
        }

        [TestMethod]
        public void HaveCorrectEqv()
        {
            Assert.AreEqual(correctEqv, ivm.Eqv);
        }

        [TestMethod]
        public void HaveCorrectCalories()
        {
            Assert.AreEqual(correctCalories, ivm.Calories);
        }

        [TestMethod]
        public void HaveCorrectCaloriesFromFat()
        { 
            Assert.AreEqual(9 * correctTotalFat, ivm.CaloriesFromFat);
        }

        [TestMethod]
        public void HaveCorrectTotalCarbohydrate()
        {
            Assert.AreEqual( correctTotalCarbohydrate, ivm.TotalCarbohydrate);
        }

        [TestMethod]
        public void HaveCorrectSugars()
        {
            Assert.AreEqual(correctSugars, ivm.Sugars);
        }
    }   */
}
