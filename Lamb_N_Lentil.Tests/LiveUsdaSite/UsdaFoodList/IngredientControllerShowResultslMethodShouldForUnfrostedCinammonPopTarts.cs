using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodList
{
    [TestClass]
    public class IngredientControllerShowResultsMethodShouldForUnfrostedCinammonPopTarts:  IngredientControllerShowResultsMethodShould
    { 

        [TestInitialize]
        public   async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync);
            searchText = "45309980";
            viewResult = (ViewResult)(await Controller.ShowResults(searchText));
            model = (ListOfFoodsViewModel)viewResult.Model;
        }
         
        [TestMethod]
        public void HaveQuery()
        {
            var correct = "45309980";
            var returned = model.Query;
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void HaveNameCorrectInFirst()
        { 
            var correct = "TOASTER PASTRIES, UPC: 038000301100";
            var returned = model.FoodItems.First().Name;
            Assert.AreEqual(correct, returned);
        }
     
        [TestMethod]
        public void HaveIngredientsCorrectInFirst()
        { 
            var correct = "ENRICHED FLOUR (WHEAT FLOUR, NIACIN, REDUCED IRON, VITAMIN B1 [THIAMIN MONONITRATE], VITAMIN B2 [RIBOFLAVIN], FOLIC ACID), SOYBEAN AND PALM OIL (WITH TBHQ FOR FRESHNESS), SUGAR, CORN SYRUP, DEXTROSE, HIGH FRUCTOSE CORN SYRUP, CRACKER MEAL, CONTAINS TWO PERCENT OR LESS OF MOLASSES, SALT, CALCIUM CARBONATE, LEAVENING (BAKING SODA, SODIUM ACID PYROPHOSPHATE, MONOCALCIUM PHOSPHATE), CINNAMON, WHEAT STARCH, SOY LECITHIN, VITAMIN A PALMITATE, NIACINAMIDE, REDUCED IRON, VITAMIN B6 (PYRIDOXINE HYDROCHLORIDE), VITAMIN B2 (RIBOFLAVIN), VITAMIN B1 (THIAMIN HYDROCHLORIDE).";
            var returned = model.FoodItems.First().Ingredients;
            Assert.AreEqual(correct, returned);
        } 
    }
}
