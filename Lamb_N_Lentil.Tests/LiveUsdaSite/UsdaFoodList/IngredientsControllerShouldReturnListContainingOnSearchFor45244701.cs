using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using _UsdaFoodReport = Lamb_N_Lentil.Domain.UsdaInformation.UsdaFoodReport;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodList
{
    [TestClass]
    public class IngredientControllerShouldReturnListContainingOnSearchFor45244701
    {
        private readonly UsdaAsync usdaAsync = new UsdaAsync();
        private readonly _UsdaFoodReport usdaAsyncFoodReport = new _UsdaFoodReport();
        private IngredientsController Controller;
        private ActionResult actionResult;
        private ViewResult viewResult;
        private ListOfFoodsViewModel model;
        private readonly string searchText= "45244701";

        [TestInitialize]
        public async Task FetchViewResult()
        {
            Controller = new IngredientsController();
            actionResult =  await Controller.ShowResults(searchText);
            viewResult = (ViewResult)actionResult;
            model = (ListOfFoodsViewModel)(viewResult.Model);
        }

        [TestMethod]
        public void CorrectQuery()
        { 
           var correct = "45244701";
          var returned  = model.Query;
             Assert.AreEqual(correct , returned );
        }

        [TestMethod]
        public void CorrectTotal()
        {
            var correct = 1;
            var returned = model.Total;
            Assert.AreEqual(correct, returned);
        }
         
        [TestMethod]
        public void CorrectName()
        {
            var correct = "PEPSI, COLA, UPC: 01282609";
            var returned = model.FoodItems.FirstOrDefault().Name;
            returned = model.FoodItems.Where(f => f.Ndbno == searchText).First().Name;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void CorrectNdbno()
        {
            var correct = "45244701";
            var returned = model.FoodItems.Where(f => f.Ndbno == searchText).First().Ndbno;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void CorrectIngredients()
        {
            var correct = "CARBONATED WATER, HIGH FRUCTOSE CORN SYRUP, CARAMEL COLOR, SUGAR, PHOSPHORIC ACID, CAFFEINE, CITRIC ACID, NATURAL FLAVOR.";
            var returned = model.FoodItems.Where(f => f.Ndbno == searchText).FirstOrDefault().Ingredients;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void CorrectMakerOrFoodGroup()
        {
            var correct = "Meadow Mist Farms";
            var returned = model.FoodItems.Where(f => f.Ndbno == searchText).First().MakerOrFoodGroup;
            Assert.AreEqual(correct, returned);
        } 
    }
}
