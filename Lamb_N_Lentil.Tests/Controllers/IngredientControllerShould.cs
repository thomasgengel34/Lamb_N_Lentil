using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.UI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.Controllers
{
    [TestClass]
    public class IngredientControllerShould
    {
        Type type { get; set; }

        public IngredientControllerShould()
        {
            type = Type.GetType("Lamb_N_Lentil.UI.Controllers.IngredientsController, Lamb_N_Lentil.UI", true);
        }


        [TestMethod]
       public void InheritController()
        {
            bool IsController = type.IsSubclassOf(typeof(Controller));

            Assert.IsTrue(IsController);
        }

        [TestMethod]
        public void HaveDefaultConstructor()
        {
            var constructor = type.GetConstructor(Type.EmptyTypes);
            Assert.IsNotNull(constructor);
        }

        [TestMethod]
        public void HasTheCorrectNumberofConstructors()
        {
            int correctNumber = 3;
            var ctors = type.GetConstructors();
            int count = ctors.Length;
            Assert.AreEqual(correctNumber, count);
        }

        [TestMethod]
        public void HaveANonNullUsdaAsync() 
        {
            IngredientsController controller = new IngredientsController();
            Assert.IsNotNull(controller.usdaAsync);
        }

        [TestMethod]
        public void HaveAUsdaAsyncOfTypeUsdaAsync()
        {
            IngredientsController controller = new IngredientsController();
            Assert.IsInstanceOfType(controller.usdaAsync, typeof(UsdaAsync));
        } 
    }
}
