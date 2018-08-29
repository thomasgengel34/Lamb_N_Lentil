using System.Threading.Tasks;
using System.Web.Mvc;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.UI.Models;
using System.Linq;

namespace Lamb_N_Lentil.UI.Controllers
{
    public class IngredientsController : Controller
    {
         public readonly UsdaFoodReport usdaFoodReport;
        public ListOfFoodsViewModel listVm;
        public readonly IUsdaAsync async; 

        public IngredientsController()
        { 
            async = new UsdaAsync(); 
            usdaFoodReport = new UsdaFoodReport();
            listVm = new ListOfFoodsViewModel();
        }

        public IngredientsController(Controller _controller = null) : base()
        {
        }

        public IngredientsController(Controller _controller = null, IUsdaAsync _usdaAsync = null) : base() => async = _usdaAsync;

        // GET: Ingredients
        public ActionResult Index()
        {
            var vm = new ListOfFoodsViewModel
            {
                ReturnStatusTextToDisplay = ""
            };
            ViewBag.SearchTotal = 0;
            ViewBag.TotalShown = 0;
            return View(UIType.Index.ToString(), vm);
        }


        public async Task<ActionResult> ShowResults(string searchText)
        {
            var vm = new ListOfFoodsViewModel();

            if (searchText == null || searchText == "")
            {
                vm.ReturnStatusTextToDisplay = "No text was entered.  Please enter something.";
                return View(UIType.Index.ToString(), vm);
            }

            vm.ReturnStatusTextToDisplay = "Searching";
            var list = await async.FetchUsdaListOfFoods(searchText,50);
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

        public async Task<ActionResult> LeastFiveCarbohydrates(IUsdaAsync async, string searchTextLeastFiveCarb)
        {
            string searchText = searchTextLeastFiveCarb;
            var vm = new ListOfFoodsViewModel();

            if (searchText == null || searchText == "")
            {
                vm.ReturnStatusTextToDisplay = "No text was entered.  Please enter something.";
                return View(UIType.Index.ToString(), vm);
            }
            var list = await async.FetchUsdaListOfFoods(searchText,500);
               vm = await ListOfFoodsViewModel.MapListOfSearchedFoodsToListOfFoods(async, list);
            vm.FoodItems = vm.FoodItems.OrderBy(f => f.TotalCarbohydrate).Take(5).ToList(); 


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

        public async Task<ViewResult> Details(string ndbno)
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
    }
}