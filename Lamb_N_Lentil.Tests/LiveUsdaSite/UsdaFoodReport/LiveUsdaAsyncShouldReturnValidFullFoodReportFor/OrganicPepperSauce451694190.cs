﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.LiveUsdaAsyncShouldReturnValidFullFoodReportFor
{
    [TestClass]
    public class  OrganicPepperSauce451649190: LiveUsdaSiteTestSetup
    {    
        [TestInitialize]
        public async Task CallFetchReport()
        {
            Ndbno =   "45169419";
            await FetchReport();
        }  

        [TestMethod]
        public void HasCorrectName()
        {
            var correct = "A&B AMERICAN STYLE, ORGANIC PEPPER SAUCE, UPC: 851063005118";
            var returned = report.foods[0].food.desc.name;
            Assert.AreEqual(correct, returned );
        }

        [TestMethod]
        public void HasCorrectNdbno()
        { var returned = report.foods[0].food.desc.ndbno;
            Assert.AreEqual(Ndbno, returned );
        }

        [TestMethod]
        public void HasCorrectUnitForFirstNutrient()
        {
            var correct = "kcal";
            var returned = report.foods[0].food.nutrients[0].unit;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectServingSizeForFirstNutrient()
        {
            var correct = 0.0M;
            var returned = report.foods[0].food.nutrients[0].qty;
            Assert.AreEqual(correct,returned );
        }


        [TestMethod]
        public void DietaryFiber()
        { 
            var correct = 0.00m; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 291
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Sugar()
        { 
            var correct = 0.00M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 269
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void VitaminA()
        { 
            var correct =  0.00M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 318
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Iron()
        { 
            var correct = 0.00M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 303
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void Sodium()
        { 
            var correct = 10M; 
            var returned  = Convert.ToDecimal((from c in report.foods[0].food.nutrients
                                                        where c.nutrient_id == 307
                                                        select c.measures[0].value).First());
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void SaturatedFatFor()
        { 
           var correct = 0; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 606
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }
    }  
} 
