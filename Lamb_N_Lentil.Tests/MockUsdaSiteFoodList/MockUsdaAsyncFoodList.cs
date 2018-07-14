using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lamb_N_Lentil.Domain;
using Lamb_N_Lentil.Domain.UsdaInformation;

namespace Lamb_N_Lentil.Tests.MockUsdaAsyncSiteFoodList
{
    /*  internal class MockUsdaAsyncFoodList : IUsdaAsync
      {
          public int FetchedTotalFromSearch { get; set; }
          public string FetchedIngredientsInIngredient { get; set; }

          public async Task<List<UsdaFoodReport>> GetListOfIngredientsFromTextSearch(string searchString, string description)
          {
              int someRandomID = 79258888;
              string sampleManufacturerOrFoodGroup = "";
              if (description == "" || description == UsdaDataSource.Both.ToString())
              {
                  sampleManufacturerOrFoodGroup = "Sample Manufacturer Or Food Group For Empty String";
              }
              if (description == UsdaDataSource.BrandedFoodProducts.ToString())
              {
                  sampleManufacturerOrFoodGroup = "Sample Manufacturer Or Food Group For Branded Products String";
              }
              if (description == UsdaDataSource.StandardReference.ToString())
              {
                  sampleManufacturerOrFoodGroup = "Sample Manufacturer Or Food Group For Standard String";
              }

              await Task.Delay(0);
              List<IIngredient> list = new List<IIngredient>();
              IIngredient ingredient = new Entity() { InstanceName = searchString, ID = someRandomID };
              ingredient.ManufacturerOrFoodGroup = sampleManufacturerOrFoodGroup;

              if (searchString == "This Should Return No Ingredients")
              {
                  return list;
              }

              if (searchString == "1000" ||
                  searchString == "1003" ||
                  searchString == "1049" ||
                  searchString == "1050" ||
                  searchString == "1051"
                 )
              { return BuildIngredientList(list, searchString); }


              if (searchString == "total")
              {
                  FetchedTotalFromSearch = 445321;
                  for (int i = 0; i < FetchedTotalFromSearch; i++)
                  {
                      list.Add(ingredient);
                  }
                  return list;
              }
              else
              {
                  list.Add(ingredient);
                  return list;
              }
          }

          //private static List<IIngredient> BuildIngredientList(List<IIngredient> list, string searchString)
          //{
          //    int length = Convert.ToInt32(searchString) - 1000;
          //    list.Clear();
          //    for (int i = 0; i < length; i++)
          //    {
          //        list.Add(new Entity { ID = i });
          //    }
          //    return list;
          //}

          //Task<List<IIngredient>> IUsdaAsync.GetListOfIngredientsFromTextSearch(string searchString, string dataSource) =>  GetListOfIngredientsFromTextSearch(searchString, dataSource);


          //Task<UsdaFoodReport> IUsdaAsync.FetchUsdaFoodReport(string ndbno)
          // => throw new NotImplementedException("MockUsdaAsyncFoodList Fetch is not implemented for the interface");

          //Task<List<UsdaFoodReport>> IUsdaAsync.FetchUsdaFood(string searchText)
          //{
          //    throw new NotImplementedException();
          //}
      }
  }
    */
}