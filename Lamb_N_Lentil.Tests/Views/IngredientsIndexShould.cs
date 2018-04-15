﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.Views
{
    [TestClass]
    public class IngredientsIndexShould : BaseViewTests
    {
        private static string filePath = @"C:\Dev\TGE\Lamb_N_Lentil\Lamb_N_Lentil\Views\Ingredients\Index.cshtml";

        public IngredientsIndexShould()
        {
            ObtainFileAsString(filePath);
        }

        [TestMethod]
        public void UseDomainUsdaInformation() => HaveCorrectText("@using Lamb_N_Lentil.Domain.UsdaInformation");
        

        [TestMethod]
        public void HaveCorrectSearchForm() => HaveCorrectText(
            "@using (Html.BeginForm(\"ShowResults\", UIType.Ingredients.ToString(), new { Controller = UIType.Ingredients.ToString(), searchText = \"searchText\", databaseSelection=Enum.TryParse(\"databaseSelection\",out UsdaDataSource databaseSelection) }))") ;

        [TestMethod]
        public void HaveCorrectLabelForTextSearch() => HaveCorrectText(
        "<p>  <label>Enter text to search for ingredients:</label></p>");


        [TestMethod]
        public void HaveCorrectLineForItemManufacturerOrFoodGroup() => HaveCorrectText(
            "@Html.DisplayFor(model => item.ManufacturerOrFoodGroup)");

        [TestMethod]
        public void HaveCorrectTextBoxToSearchForIngredients()
        {
            string testString = "@Html.TextBox(\"searchText\", \"Enter Description of What You are Looking For Here\", new { @class = \"ingredientTextBox\", maxlength = \"43\" })";
            HaveCorrectText(testString);
        }

        [TestMethod]
        public void HaveCorrectNoResultsLabel()
        {
            string testString = "<h2 class=\"no_results\">@ViewBag.NoResults</h2>";
            HaveCorrectText(testString);
        }
    }
}
