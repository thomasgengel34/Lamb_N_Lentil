﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite
{
    [TestClass]
    public class LiveUsdaAsyncShouldReturnValidFoodReportForSoftMargarine45037282 : LiveUsdaSiteTestSetup
    { 
        [TestInitialize]
        public async Task CallFetchReport()
        {
            Ndbno = "45037282";
            await FetchReport();
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
        public void WithCorrectName()
        {
            string correctName = "SOFT MARGARINE, UPC: 041250040538";

            Assert.AreEqual(correctName, report.foods[0].food.desc.name);
        }

        [TestMethod]
        public void WithCorrectNdbno()
        { 
            Assert.AreEqual(Ndbno, report.foods[0].food.desc.ndbno);
        }
         

        [TestMethod]
        public void Manufacturer()
        { 
            decimal correct = 0.0M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 431
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectServingSizeForFirstNutrient()
        {
            decimal correct = 1.0M;
            Assert.AreEqual(correct, report.foods[0].food.nutrients[0].measures[0].qty);
        }


        [TestMethod]
        public void Calories()
        { 
            int correctkcal = 100; 
            var result = from r in report.foods[0].food.nutrients
                         where r.name == "Energy"
                         select r.measures[0].value;
            int returnedkcal = Convert.ToInt16(result.First());
            Assert.AreEqual(correctkcal, returnedkcal);
        }


        [TestMethod]
        public void Potassium()
        { 
            decimal correct = 0M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 306
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void TransFat()
        { 
            decimal correct = 1.00m; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 605
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        } 
    }
}
