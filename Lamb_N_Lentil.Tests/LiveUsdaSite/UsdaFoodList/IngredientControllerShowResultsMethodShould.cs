using System.Threading.Tasks;
using System.Web.Mvc;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _UsdaListOfFoods = Lamb_N_Lentil.Domain.UsdaInformation.List.UsdaListofFoods;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodList
{
    [TestClass]
    public class IngredientControllerShowResultsMethodShould
    {
        private protected readonly IUsdaAsync usdaAsync = new UsdaAsync();
        private protected readonly _UsdaListOfFoods usdaAsyncFoodList = new _UsdaListOfFoods();
        private protected IngredientsController Controller;
        private protected ViewResult viewResult;
        private protected string searchText;
        private protected ListOfFoodsViewModel model;

        [TestInitialize]
        public async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync);
            searchText = "45032698";
            viewResult = (ViewResult)(await Controller.ShowResults(searchText));
            model = (ListOfFoodsViewModel)viewResult.Model;
        } 
    }
}
