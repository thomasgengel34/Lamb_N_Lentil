﻿using Lamb_N_Lentil.Domain.UsdaInformation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite
{
    [TestClass]
    public class LiveUsdaAsyncShouldReturnValidFoodReportForHominy20030:LiveUsdaSiteTestSetup
    {    
        [TestInitialize]
        public async Task CallFetchReport()
        {
            Ndbno = "20030";  
            await FetchReport();
        } 

        [TestMethod]
        public void HasCorrectName()
        {
            string correct = "Hominy, canned, white";
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
            string correct = "g";
            Assert.AreEqual(correct, report.foods[0].food.nutrients[0].unit);
        }

        [TestMethod]
        public void HasCorrectServingSizeForFirstNutrient()
        {
            decimal correct = 0.0M;
            Assert.AreEqual(correct, report.foods[0].food.nutrients[0].qty);
        }
    }
}
