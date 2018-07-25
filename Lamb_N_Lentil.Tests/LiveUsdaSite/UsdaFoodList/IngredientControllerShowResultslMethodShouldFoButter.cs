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
    public class IngredientControllerShowResultsMethodShouldForButter:  IngredientControllerShowResultsMethodShould
    { 

        [TestInitialize]
        public new async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync);
            searchText = "Butter";
            viewResult = (ViewResult)(await Controller.ShowResults(searchText));
            model = (ListOfFoodsViewModel)viewResult.Model;
        }
         
        [TestMethod]
        public void HaveQuery()
        {
            var correct =  searchText ;
            var returned = model.Query;
            Assert.AreEqual(correct, returned);
        }
         
    }
}
