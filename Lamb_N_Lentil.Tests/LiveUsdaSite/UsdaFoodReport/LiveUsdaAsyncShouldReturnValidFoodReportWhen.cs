using Lamb_N_Lentil.Domain;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.UI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;
using UsdaFR = Lamb_N_Lentil.Domain.UsdaInformation.UsdaFoodReport;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport
{
    [TestClass]
    public class LiveUsdaAsyncShouldReturnValidFoodReportWhen
    {
        private protected readonly IUsdaAsync usdaAsync = new UsdaAsync();
        private protected IngredientsController Controller;
        private protected string Ndbno { get; set; }
        private protected UsdaFR report;

        public LiveUsdaAsyncShouldReturnValidFoodReportWhen()
        {
            Controller = new IngredientsController(null, usdaAsync);
        }

        protected async Task FetchReport()
        {
            report = await usdaAsync.FetchUsdaFoodReport(Ndbno);
        }
    }
}
