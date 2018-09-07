﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.Domain.UsdaInformation.List;
using Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodList;
using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.MockUsdaSite.MockUsdaSiteFoodList
{
    [TestClass]
    public class IngredientControllerLeastFiveCarbohydratesShouldForMockedWithNoCarbs

    {
        private protected readonly IUsdaAsync usdaAsync = new
            MockUsdaAsyncFoodList();
        private protected readonly UsdaListofFoods usdaAsyncFoodList = new  UsdaListofFoods();
        private protected IngredientsController Controller;
        private protected ViewResult viewResult;
        private protected string searchText;
        private protected ListOfFoodsViewModel model;
        private ListOfFoodsViewModel ListOfFoodsViewModel { get; set; }

        [TestInitialize]
        public  async Task Start() => model = await GetModel();



        public async Task<ListOfFoodsViewModel> GetModel()
        {
            Controller = new IngredientsController(null, usdaAsync);
            searchText = "MockedFiveZeros";
            viewResult = (ViewResult)(await Controller.LeastFiveCarbohydrates( searchText));
            model = (ListOfFoodsViewModel)viewResult.Model;
            return model;
        }

        [TestMethod]
        public void HaveQuery()
        {
            var correct = searchText;
            var returned = model.Query;
            Assert.AreEqual(correct, returned);
        } 
        
        [TestMethod]
        public void HaveCarbohydratesInIncreasingOrder()
        {
            List<decimal> correct = new List<decimal>
            {   0,0,0,0,0 };
            List<decimal> returned = model.FoodItems.Select(t => t.TotalCarbohydrate).ToList();
            CollectionAssert.AreEqual(correct, returned); 
        }
    }
}