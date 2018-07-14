using Lamb_N_Lentil.Domain.UsdaInformation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport
{   
    [TestClass]
    public class LiveUsdaAsyncShouldReturnValidFoodReportForSpumoniIceCream4532207 : LiveUsdaAsyncShouldReturnValidFoodReportWhen
    {    
        [TestInitialize]
        public async Task CallFetchReport()
        { 
            Ndbno = "45322307";  
            await FetchReport();
        } 

        [TestMethod]
        public void HasCorrectName()
        {
            string correct = "PREMIUM SPUMONI ICE CREAM, UPC: 070640000067";
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
            decimal correct = 0.00M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 291
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void Sugar()
        { 
            decimal correct = 16.00M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 269
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void VitaminA()
        { 
            decimal correct = 300.00M; 
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 318
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void TotalFat()
        { 
            decimal correctTotalFat = 9.72M; 
            decimal returnedTotalFat = Convert.ToDecimal(report.foods[0].food.nutrients[2].value);
            Assert.AreEqual(correctTotalFat, returnedTotalFat);
        }

    }   
}
