using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.UI.Models;

namespace Lamb_N_Lentil.UI.Controllers
{
    public class IngredientsController : Controller
    {
        public UsdaFoodReport usdaFoodReport;
        public ListOfFoodsViewModel listVm;
        public readonly IUsdaAsync async;

        public IngredientsController()
        {
            try
            {
                async = new UsdaAsync();
                usdaFoodReport = new UsdaFoodReport();
                listVm = new ListOfFoodsViewModel();
            }
            catch (System.Exception)
            {

                throw;
            }

        }

        public IngredientsController(Controller _controller = null) : base()
        {
            try
            {

            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public IngredientsController(Controller _controller = null, IUsdaAsync _usdaAsync = null) : base()
        {
            try
            {
                async = _usdaAsync;
            }
            catch (System.Exception)
            {

                throw;
            }

        }

        // GET: Ingredients
        public ActionResult Index()
        {
            try
            {
                var vm = new ListOfFoodsViewModel
                {
                    ReturnStatusTextToDisplay = ""
                };
                ViewBag.SearchTotal = 0;
                ViewBag.TotalShown = 0;
                return View(UIType.Index.ToString(), vm);
            }
            catch (System.Exception)
            {

                throw;
            }

        }


        public async Task<ActionResult> ShowResults(string searchText)
        {
            try
            {

                var vm = new ListOfFoodsViewModel();

                if (searchText == null || searchText == "")
                {
                    vm.ReturnStatusTextToDisplay = "No text was entered.  Please enter something.";
                    return View(UIType.Index.ToString(), vm);
                }

                vm.ReturnStatusTextToDisplay = "Searching";
                var list = await async.FetchUsdaListOfFoods(searchText, 50);
                vm = await ListOfFoodsViewModel.MapListOfSearchedFoodsToListOfFoods(async, list);
                vm.ReturnStatusTextToDisplay = "";
                if (vm == null || vm.Total == 0)
                {
                    vm.ReturnStatusTextToDisplay = "Nothing was found. Please refine your search.";
                }
                else
                {
                    vm.ReturnStatusTextToDisplay = "";
                }
                return View(UIType.Index.ToString(), vm);

            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public async Task<ActionResult> LeastFiveCarbohydrates(string searchTextLeastFiveCarb = "")
        //public async Task<ActionResult> LeastFiveCarbohydrates(IUsdaAsync async, string searchTextLeastFiveCarb)
        {
            try
            {
                string searchText = searchTextLeastFiveCarb;
                var vm = new ListOfFoodsViewModel();
                ViewBag.CarbTrigger = true;
                if (searchText == null || searchText == "")
                {
                    vm.ReturnStatusTextToDisplay = "No text was entered.  Please enter something.";
                    return View(UIType.Index.ToString(), vm);
                }
                var list = await async.FetchUsdaListOfFoods(searchText, 500);
                vm = await ListOfFoodsViewModel.MapListOfSearchedFoodsToListOfFoods(async, list);
                int count = 0;
                if (vm.FoodItems != null)
                {
                    count = vm.FoodItems.Count();
                }
                if (count > 4)
                {
                    count = 5;
                }
                if (count > 0)
                {
                    vm.FoodItems = vm.FoodItems.OrderBy(f => f.TotalCarbohydrate).Take(count).ToList();
                }

                vm.ReturnStatusTextToDisplay = "Searching";

                vm.ReturnStatusTextToDisplay = "";
                if (vm == null || vm.Total == 0)
                {
                    vm.ReturnStatusTextToDisplay = "Nothing was found. Please refine your search.";
                }
                else
                {
                    vm.ReturnStatusTextToDisplay = "";
                }
                return View(UIType.Index.ToString(), vm);

            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<ViewResult> Details(string ndbno)
        {
            try
            {

                var vm = new UsdaFoodReportViewModel();
                if (ndbno == null || ndbno == "")
                {
                    vm.ReturnStatusTextToDisplay = "No Data";
                    return View(UIType.Details.ToString(), vm);
                }

                var report = await async.FetchUsdaFoodReport(ndbno);
                vm = UsdaFoodReportViewModel.MapUsdaFoodReportToItsViewModel(report);
                return View(UIType.Details.ToString(), vm);

            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}