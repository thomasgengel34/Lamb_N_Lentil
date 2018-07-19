using System.Collections.Generic;
using Lamb_N_Lentil.Domain;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lamb_N_Lentil.Domain.UsdaInformation;
using System.Threading.Tasks;
using System.Linq;
using UsdaFR = Lamb_N_Lentil.Domain.UsdaInformation.UsdaFoodReport;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.LiveUsdaAsyncShouldReturnValidFullFoodReportFor
{
    [TestClass]
    public class  DicedPeaches45032698 : LiveUsdaSiteTestSetup
    { 
        [TestInitialize]
        public async Task CallFetchReport()
        {
            Ndbno = "45032698";
            await FetchReport();
        } 

        private async Task<UsdaFR> GetReport(string ndbno)
        {
            report = await usdaAsync.FetchUsdaFoodReport(ndbno);
            return report;
        }

        [TestMethod]
        public void WithCorrectName()
        {
           var correct = "DICED PEACHES, UPC: 078742212050";

            Assert.AreEqual(correct, report.foods[0].food.desc.name);
        }

        [TestMethod]
        public void WithCorrectNdbno()
        { 
            Assert.AreEqual(Ndbno, report.foods[0].food.desc.ndbno);
        }

        [TestMethod]
        public void WithCorrectIngredients()
        {
            var correct  = "DICED PEACHES, WATER, SUGAR, NATURAL FLAVORS, ASCORBIC ACID (VITAMIN C) TO PROTECT COLOR, CITRIC ACID."; 
            Assert.AreEqual(correct , report.foods[0].food.ing.desc);
        }

        [TestMethod]
        public void WithCorrectUpdateDate()
        {
            var correct = "04/10/2018"; 
            var returned = report.foods[0].food.ing.upd;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void WithCorrectEqv()
        {
            var correct = 113.0M; 
            var returned = report.foods[0].food.nutrients.First().measures.First().eqv;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void WithCorrectFoodGroupOrManufacturer()
        {
            var correct = "WAL-MART STORES, INC."; 
           var returnedFg = report.foods[0].food.desc.fg;
            var returnedManu = report.foods[0].food.desc.manu;
            Assert.AreEqual(correct, returnedManu);
            Assert.IsNull(returnedFg);
        }

        [TestMethod]
        public void HasCorrectServingSizeForFirstNutrient()
        {
            var correct = 0.0M;
            Assert.AreEqual(correct, report.foods[0].food.nutrients[0].qty);
        }
    }
 }
