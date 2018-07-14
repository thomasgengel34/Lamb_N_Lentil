 
using Lamb_N_Lentil.Domain.UsdaInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsdaFR = Lamb_N_Lentil.Domain.UsdaInformation.UsdaFoodReport;

namespace Lamb_N_Lentil.Tests.LiveUsdaSite.UsdaFoodReport
{    
    public class LiveUsdaSiteTestSetup
    {
       
        protected internal string Ndbno { get; set; }
        protected UsdaFR report;
        protected IUsdaAsync usdaAsync;

        protected async Task FetchReport()
        {
            usdaAsync = new UsdaAsync();
            report = await usdaAsync.FetchUsdaFoodReport(Ndbno);
        }
    }    
}
