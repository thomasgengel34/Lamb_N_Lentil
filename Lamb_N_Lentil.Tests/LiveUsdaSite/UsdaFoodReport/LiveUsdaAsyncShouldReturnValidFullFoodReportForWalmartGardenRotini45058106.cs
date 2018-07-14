using System.Collections.Generic;
using Lamb_N_Lentil.Domain;
using Lamb_N_Lentil.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lamb_N_Lentil.Domain.UsdaInformation;
using System.Threading.Tasks;
using System.Linq;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport
{   
    [TestClass]
    public class LiveUsdaAsyncShouldReturnValidFoodReportForWalmartGardenRotini45058106
        : LiveUsdaAsyncShouldReturnValidFoodReportWhen
    { 
        [TestInitialize]
        public async Task CallFetchReport()
        {
            Ndbno = "45058106";
            await FetchReport();
        }

     

        [TestMethod]
        public void WithCorrectName()
        {
            string correct  = "GARDEN ROTINI, UPC: 078742228679"; 
            Assert.AreEqual(correct , report.foods[0].food.desc.name);
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
            decimal correct = 0.75M;
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

    }   
}
