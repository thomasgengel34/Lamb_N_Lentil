﻿using Lamb_N_Lentil.Domain.UsdaInformation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Linq;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite
{
    [TestClass]
    public class LiveUsdaAsyncShouldReturnValidFoodReportForKiwi45209709 : LiveUsdaSiteTestSetup
    {    
        [TestInitialize]
        public async Task CallFetchReport()
        {
            Ndbno = "45209709";  
            await FetchReport();
        } 

        [TestMethod]
        public void HasCorrectName()
        {
            string correct = "KIWI, UPC: 028744019140";
            Assert.AreEqual(correct, report.foods[0].food.desc.name);
        }

        [TestMethod]
        public void HasCorrectNdbno()
        {
            Assert.AreEqual(Ndbno, report.foods[0].food.desc.ndbno);
        }

        [TestMethod]
        public void HasCorrectUnitForFirstNutrient()
        {
            string correct = "kcal";
            Assert.AreEqual(correct, report.foods[0].food.nutrients[0].unit);
        }

        [TestMethod]
        public void HasCorrectServingSizeForFirstNutrient()
        {
            decimal correct = 0.0M;
            Assert.AreEqual(correct, report.foods[0].food.nutrients[0].qty);
        }


        [TestMethod]
        public void DietaryFiber()
        { 
            decimal correct = 1.00m; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 291
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Sugar()
        { 
            decimal correct = 20.00M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 269
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void VitaminA()
        { 
            decimal correct = 0.00M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 318
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void ServingSize()
        { 
            string correct  = "cup"; 
            string returned  = report.foods.First().food.nutrients.First().measures.First().label;
            Assert.AreEqual(correct , returned );
        }

    }
}
