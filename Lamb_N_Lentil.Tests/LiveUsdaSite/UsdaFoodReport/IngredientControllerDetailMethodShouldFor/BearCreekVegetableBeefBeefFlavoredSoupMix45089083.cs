using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.IngredientControllerDetailMethodShouldFor
{
    [TestClass]
    public class BearCreekVegetableBeefBeefFlavoredSoupMix45089083 : IngredientControllerDetailMethodShould
    { 

        [TestInitialize]
        public new async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync, usdaAsyncFoodReport);
            searchText = "45089083";
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
            var correct = "VEGETABLE BEEF SOUP MIX, UPC: 760263000123";
            var returned = model.Description;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HaveIngredients()
        { 
            var correct = "ENRICHED LONG GRAIN RICE (IRON, NIACIN, THIAMINE MONONITRATE, FOLIC ACID), BARLEY, LENTILS, POTATOES, ENRICHED PASTA (WHEAT FLOUR, NIACIN, REDUCED IRON, THIAMINE MONONITRATE, RIBOFLAVIN, FOLIC ACID), PEAS, ONIONS, CARROTS, HYDROLYZED SOY, CORN AND WHEAT PROTEIN, SALT, NATURAL FLAVOR, SUGAR, CORN STARCH, GARLIC, CELERY, SPICES, BEEF STOCK, BEEF FAT, CARAMEL COLOR, MALTODEXTRIN, CITRIC ACID, BEEF BROTH, PARTIALLY HYDROGENATED SOY AND COTTONSEED OIL, DISODIUM INOSINATE AND DISODIUM GUANYLATE (FLAVOR ENHANCER).";
            var returned = model.Ingredients;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectNumberOfNutrients()
        {
            var correct = 14;
            var returned = model.Nutrients.Count();
            Assert.AreEqual(correct, returned);
        } 
         

         
        [TestMethod]
        public void Iron()
        {
            var correct = 1.08M;  
            var returned = model.Iron;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void IronDailyPercentage()
        {
            var correct = 6;
            var returned = model.IronPercentageDailyValue;
            Assert.AreEqual(correct, returned); 
        } 
    }
}
