using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Lamb_N_Lentil.Tests.UsdaListOfFoods
{
    [TestClass]
    public class IngredientControllerShouldReturnListContaining
    {
        private readonly IUsdaAsync usdaAsync = new UsdaAsync();
        private readonly IUsdaAsync usdaAsyncFoodReport = new UsdaAsyncFoodReport();
        private IngredientsController Controller;
        private ActionResult actionResult;
        private ViewResult viewResult;
        private ListOfFoodsViewModel model;
        private readonly string searchText="cola";

        [TestInitialize]
        public async Task FetchViewResult()
        {
            Controller = new IngredientsController(null, usdaAsync, usdaAsyncFoodReport);
            actionResult = await Controller.ShowResults(searchText);
            viewResult = (ViewResult)actionResult;
            model = (ListOfFoodsViewModel)(viewResult.Model);
        }

        [TestMethod]
        public void CorrectQuery()
        { 
           var correct = "cola";
          var returned  = model.Query;
             Assert.AreEqual(correct , returned );
        }

        [TestMethod]
        public void CorrectTotal()
        {
            var correct = 787;
            var returned = model.Total;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void CorrectTotalNumberOfNutrients()
        {
            var correct = 50;
            var returned = model.FoodItems.Count();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void CorrectNameOnFirstNutrient()
        {
            var correct = "PEPSI-COLA, 1893 COLA, GINGER COLA, UPC: 012000151903";
            var returned = model.FoodItems.First().Name;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void CorrectNdbnoOnFirstNutrient()
        {
            var correct = "PEPSI-COLA, 1893 COLA, GINGER COLA, UPC: 012000151903";
            var returned = model.FoodItems.First().Name;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void CorrectIngredientsOnFirstNutrient()
        {
            var correct = "CARBONATED WATER, SUGAR, CARAMEL COLOR, NATURAL FLAVOR, PHOSPHORIC ACID, SODIUM CITRATE, CAFFEINE, POTASSIUM SORBATE (PRESERVES FRESHNESS), MODIFIED FOOD STARCH, KOLA NUT EXTRACT, GINGER OLEORESIN.";
            var returned = model.FoodItems.First().Ingredients;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void CorrectMakerOrFoodGroupOnFirstNutrient()
        {
            var correct = "Pepsi-Cola North America Inc.";
            var returned = model.FoodItems.First().MakerOrFoodGroup;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void CorrectServingSizeOnFirstNutrient()
        {
            var correct = "CAN";
            var returned = model.FoodItems.First().ServingSize;
            Assert.AreEqual(correct, returned);
        }
    }
}
