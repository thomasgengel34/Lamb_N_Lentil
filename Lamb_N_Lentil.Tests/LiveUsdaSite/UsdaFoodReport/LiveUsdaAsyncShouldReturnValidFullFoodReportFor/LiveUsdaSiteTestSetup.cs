using System.Threading.Tasks;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.UI.Controllers; 
using _UsdaFoodReport = Lamb_N_Lentil.Domain.UsdaInformation.UsdaFoodReport;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport.LiveUsdaAsyncShouldReturnValidFullFoodReportFor
{
    public class LiveUsdaSiteTestSetup
    {
        private protected readonly IUsdaAsync usdaAsync = new UsdaAsync();
        private protected IngredientsController Controller;
        private protected string Ndbno { get; set; }
        private protected  _UsdaFoodReport report;

        public LiveUsdaSiteTestSetup()
        {
            Controller = new IngredientsController(null, usdaAsync);
        }

        protected async Task FetchReport()
        {
            report = await usdaAsync.FetchUsdaFoodReport(Ndbno);
        }
    }    
}
