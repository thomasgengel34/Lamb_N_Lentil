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
    public class IngredientControllerShowResultsMethodShouldForUnfindable:  IngredientControllerShowResultsMethodShould
    { 

        [TestInitialize]
        public new async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync);
            searchText = "-1";
            viewResult = (ViewResult)(await Controller.ShowResults(searchText));
            model = (ListOfFoodsViewModel)viewResult.Model;
        }
         
        [TestMethod]
        public void HaveNullQuery()
        { 
            var returned = model.Query;
            Assert.IsNull( returned);
        }


        [TestMethod]
        public void HaveNullFoodItems()
        { 
            var returned = model.FoodItems;
            Assert.IsNull( returned);
        }
     
        
    }
}
