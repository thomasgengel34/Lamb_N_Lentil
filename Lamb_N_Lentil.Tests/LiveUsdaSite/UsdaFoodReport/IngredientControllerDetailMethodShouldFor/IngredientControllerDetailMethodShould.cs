using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
 using _UsdaFoodReport =Lamb_N_Lentil.Domain.UsdaInformation.UsdaFoodReport; 

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.IngredientControllerDetailMethodShouldFor
{
    [TestClass]
    public class IngredientControllerDetailMethodShould
    {
        private protected readonly IUsdaAsync usdaAsync = new UsdaAsync();
        private protected readonly IUsdaAsync usdaAsyncFoodReport = new _UsdaFoodReport();
        private protected IngredientsController Controller;
        private protected ViewResult viewResult;
        private protected string searchText;
        private protected UsdaFoodReportViewModel model;

        [TestInitialize]
        public async Task Start()
        {
            Controller = new IngredientsController();
            searchText = "45032698";
            viewResult = await Controller.Details(searchText);
            model = (UsdaFoodReportViewModel)viewResult.Model;
        }


        protected private static void AcceptIfOffByOne(int correct, int returned)
        {
            var difference = Math.Abs(correct - returned);
            bool variance = false;
            if (difference < 1.1)
            {
                variance = true;
            }
            Assert.IsTrue(variance, "correct: " + correct + ", returned: " + returned);
        }
    }
}
