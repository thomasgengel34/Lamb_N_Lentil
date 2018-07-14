using System.Collections.Generic;
using Lamb_N_Lentil.Domain;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lamb_N_Lentil.Domain.UsdaInformation;
using System.Threading.Tasks;
using System.Linq;
using UsdaFR = Lamb_N_Lentil.Domain.UsdaInformation.UsdaFoodReport;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport
{
     [TestClass]
    public class LiveUsdaAsyncShouldReturnValidFoodReportForCheddarCheese01009 : LiveUsdaAsyncShouldReturnValidFoodReportWhen
    { 
        [TestInitialize]
        public async Task CallFetchReport()
        {
            Ndbno = "01009";
            await FetchReport();
        } 
         

        [TestMethod]
        public void WithCorrectName()
        {
            var correct = "Cheese, cheddar (Includes foods for USDA's Food Distribution Program)";

            Assert.AreEqual(correct , report.foods[0].food.desc.name);
        }

        [TestMethod]
        public void WithCorrectNdbno()
        { 
            Assert.AreEqual(Ndbno, report.foods[0].food.desc.ndbno);
        }
         

        [TestMethod]
        public async Task Manufacturer()
        { 
            var correct = 0.0M;
            UsdaFR report = await usdaAsync.FetchUsdaFoodReport(Ndbno);
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 431
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectServingSizeForFirstNutrient()
        {
            var correct = 1.0M;
            Assert.AreEqual(correct, report.foods[0].food.nutrients[0].measures[0].qty);
        }

        [TestMethod]
        public void FolicAcid()
        {
            decimal correct = 0.0M;
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 431
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Magnesium()
        { 
            var correct = 36.0M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 304
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }
        
        [TestMethod]
        public void Calcium()
        { 
            var correct = 937.0M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 301
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void VitaminD()
        { 
            var correct = 32.0M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 324
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Thiamine()
        { 
            var correct = 0.038M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 404
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Riboflavin()
        { 
            var correct = 0.565M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 405
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Niacin()
        { 
            var correct = 0.078M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 406
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void VitaminB6()
        { 
           var correct = 0.087M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 415
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void VitaminB12()
        { 
            var correct = 1.45M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 418
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void NutritionalUnitForTotalFatOf()
        {
            var correct = "g";
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 204
                            select c.measures.First().eunit).First();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void NutritionalUnitForEnergyOf()
        {
            var correct = "kcal";
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 208
                            select c.unit).First();
            Assert.AreEqual(correct, returned);
        }
    }  
}
