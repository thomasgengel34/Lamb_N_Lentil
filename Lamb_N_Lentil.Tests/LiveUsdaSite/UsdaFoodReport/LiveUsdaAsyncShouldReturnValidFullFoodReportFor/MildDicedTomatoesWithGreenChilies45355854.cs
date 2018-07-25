using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.LiveUsdaAsyncShouldReturnValidFullFoodReportFor
{
    [TestClass]
    public class LiveUsdaAsyncShouldReturnValidFoodReportForMildDicedTomatoesWithGreenChilies45355854 : LiveUsdaSiteTestSetup
    {
        [TestInitialize]
        public async Task CallFetchReport()
        {
            Ndbno = "45355854";
            await FetchReport();
        }

        [TestMethod]
        public void FolicAcid()
        {
            var correct = 0.0M;
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 431
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void WithCorrectName()
        {
            var correct  = "MILD DICED TOMATOES WITH GREEN CHILIES, UPC: 078742002170";
            var returned = report.foods[0].food.desc.name;
            Assert.AreEqual(correct, returned );
        }

        [TestMethod]
        public void WithCorrectNdbno()
        {
            var returned = report.foods[0].food.desc.ndbno;
            Assert.AreEqual(Ndbno,returned);
        }


        [TestMethod]
        public void Manufacturer()
        {
            var correct = 0.0M;
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 431
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void HasCorrectServingSizeForFirstNutrient()
        {
            var correct = 0.5M;
            var returned = report.foods[0].food.nutrients[0].measures[0].qty;
            Assert.AreEqual(correct, returned );
        }


        [TestMethod]
        public void Calories()
        {
           var correct  = 20;
            var result = from r in report.foods[0].food.nutrients
                         where r.name == "Energy"
                         select r.measures[0].value;
              var returned  = result.First() ; 
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void Potassium()
        {
            var correct = 170M;
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 306
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void TransFat()
        {
            var  correct = 0.00m;
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 605
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned);
        }


        [TestMethod]
        public void SaturatedFatForYellowClingPeaches45032698()
        {
            var correct = 0.00M;
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 606
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct , returned);
        }

        [TestMethod]
        public void  Sugars()
        {
            var correct  = 3.00M;
            var returned = (from c in report.foods[0].food.nutrients
                            where c.nutrient_id == 269
                            select c.measures[0].value).FirstOrDefault();
            Assert.AreEqual(correct, returned); 
        }
    }   
}
