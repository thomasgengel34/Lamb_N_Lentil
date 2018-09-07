﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodList;
using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.LeastFiveCarbohydrates
{
    [TestClass]
    public class IngredientControllerLeastFiveCarbohydratesShouldForButter : IngredientControllerShowResultsMethodShould
    {
        private ListOfFoodsViewModel ListOfFoodsViewModel { get; set; }

        [TestInitialize]
        public new async Task Start() => model = await GetModel();



        public async Task<ListOfFoodsViewModel> GetModel()
        {
            Controller = new IngredientsController(null, usdaAsync);
            searchText = "Butter";
            viewResult = (ViewResult)(await Controller.LeastFiveCarbohydrates(searchText));
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
        public void HaveNdbnos()
        {
            List<string> correct = new List<string>
            {
                 "01323" ,"45188178","45167682" ,"45037291" ,"45187982"    };
            List<string> returned = model.FoodItems.Select(t => t.Ndbno).ToList();

            CollectionAssert.AreEqual(correct, returned);
     
        }

        [TestMethod]
        public void HaveCarbohydratesInIncreasingOrder()
        {
            List<decimal> correct = new List<decimal>
            {  0,0,0,0,0 };
            List<decimal> returned = model.FoodItems.Select(t => t.TotalCarbohydrate).ToList();
            CollectionAssert.AreEqual(correct, returned);

        }
    }
}