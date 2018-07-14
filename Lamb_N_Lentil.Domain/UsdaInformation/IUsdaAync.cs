using System.Collections.Generic;
using System.Threading.Tasks;
using Lamb_N_Lentil.Domain.UsdaList;

namespace Lamb_N_Lentil.Domain.UsdaInformation
{
    public interface IUsdaAsync
    {
        Task<UsdaFoodReport> FetchUsdaFoodReport(string ndbno); 
        Task<UsdaListofFoods> FetchUsdaFoodList(string searchText);
    }
}