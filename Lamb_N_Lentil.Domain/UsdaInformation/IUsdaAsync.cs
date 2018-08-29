using System.Threading.Tasks;
using Lamb_N_Lentil.Domain.UsdaInformation.List;

namespace    Lamb_N_Lentil.Domain.UsdaInformation 
{
    public interface IUsdaAsync  
    {
        Task<UsdaListofFoods> FetchUsdaListOfFoods(string searchText, int defaultCount); 
        Task<UsdaFoodReport> FetchUsdaFoodReport(string ndbno); 
    }
}
