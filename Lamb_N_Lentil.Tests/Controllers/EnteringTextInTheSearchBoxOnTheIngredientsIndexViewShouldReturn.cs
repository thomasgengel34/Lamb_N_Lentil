﻿using Lamb_N_Lentil.Domain;
using Lamb_N_Lentil.Tests.MockUsdaAsyncSiteFoodList;
using Lamb_N_Lentil.UI.Controllers;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Lamb_N_Lentil.Tests.Controllers
{
    [TestClass]
    public class EnteringTextInTheSearchBoxOnTheIngredientsIndexViewShouldReturn
    {
        private IngredientsController controller;

        [TestInitialize]
        public void Setup()
        {
          controller = new IngredientsController(null,new  MockUsdaAsyncFoodList()); 
        }
         

        private async Task<IIngredient> GetTheIngredient()
        {
            ActionResult ar = await controller.ShowResults(" 076606619663");
            ViewResult vr = (ViewResult)ar;
            List<IngredientListViewModel> ingredients = (List<IngredientListViewModel>)(vr.Model);
            IIngredient ingredient = IngredientListViewModel.MapIIngredientListViewModelToIngredient(ingredients.First());
            return ingredient;
        }
  
    }
}
