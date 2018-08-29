using System;
using System.Linq;
using System.Threading.Tasks;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.Domain.UsdaInformation.List;
using Lamb_N_Lentil.UI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodList
{
    [TestClass]
    public class LiveUsdaAsyncForDicedPeachesShouldReturnListContaining:IDisposable
    {
        private readonly  IUsdaAsync usdaAsync = new UsdaAsync();
        private readonly IngredientsController Controller;
        private UsdaListofFoods foodList;
        private readonly string searchText = "DICED PEACHES, UPC: 078742212050";

        public LiveUsdaAsyncForDicedPeachesShouldReturnListContaining() => Controller = new IngredientsController(null, usdaAsync);

        [TestInitialize]
        public async Task Start() => foodList = await FetchList(searchText);


        private async Task<UsdaListofFoods> FetchList(string searchText) => await usdaAsync.FetchUsdaListOfFoods(searchText,50);

        [TestMethod]
        public void  TotalIsCorrect()
        {
            int correct = 108; 
            var returned = foodList.list.total;
            Assert.AreEqual(correct , returned );
        }

        [TestMethod]
        public void QueryIsCorrect()
        { 
            var returned = foodList.list.q;
            Assert.AreEqual(searchText, returned );
        }

        [TestMethod]
        public void ItemCountIsCorrect()
        {
            int correct = 50;
            var returned = foodList.list.item.Count();
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void FirstItemNameIsCorrect()
        {
            string correct = "DICED PEACHES, UPC: 078742212050";
            var returned = foodList.list.item.First().name;
            Assert.AreEqual(correct, returned);
        }

        [TestMethod]
        public void LastItemNdnbnoIsCorrect()
        {
            string correct = "45282575";
            var returned = foodList.list.item.Last().ndbno;
            Assert.AreEqual(correct, returned);
        }

        public void Dispose() => ((IDisposable)Controller).Dispose();
    }
}
