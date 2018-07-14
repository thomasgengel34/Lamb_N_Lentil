using System.Threading.Tasks;
using System.Web.Mvc;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport
{
    [TestClass]
    public class IngredientControllerDetailMethodShould
    {
        private protected readonly IUsdaAsync usdaAsync = new UsdaAsync();
        private protected readonly IUsdaAsync usdaAsyncFoodReport = new UsdaAsyncFoodReport();
        private protected IngredientsController Controller;
        private protected ViewResult viewResult;
        private protected string searchText;
        private protected UsdaFoodReportViewModel model;

        [TestInitialize]
        public async Task Start()
        {
            Controller = new IngredientsController(null, usdaAsync, usdaAsyncFoodReport);
            searchText = "45032698";
            viewResult = await Controller.Details(searchText);
            model = (UsdaFoodReportViewModel)viewResult.Model;
        } 
    }
}
