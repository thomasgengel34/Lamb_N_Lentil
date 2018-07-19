using Lamb_N_Lentil.Domain.UsdaInformation.List;
using System.Threading.Tasks;

namespace Lamb_N_Lentil.Domain.UsdaInformation
{
    public interface IUsdaAsync
    {
        Task<UsdaFoodReport> FetchUsdaFoodReport(string ndbno); 
        Task<UsdaListofFoods> FetchUsdaFoodList(string searchText);
    }
}