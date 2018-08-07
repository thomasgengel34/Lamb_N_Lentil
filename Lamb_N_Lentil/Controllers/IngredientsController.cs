using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Lamb_N_Lentil.Domain;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.UI.Models;

namespace Lamb_N_Lentil.UI.Controllers
{
    public class IngredientsController : Controller
    {

        public readonly IUsdaAsync usdaAsync;
        public readonly IUsdaAsync usdaAsyncFoodReport;

        public IngredientsController()
        {
            usdaAsync = new UsdaAsync();
            usdaAsyncFoodReport = new UsdaFoodReport();
        }

        public IngredientsController(Controller _controller = null) : base()
        {
        }

        public IngredientsController(Controller _controller = null, IUsdaAsync _usdaAsync = null, IUsdaAsync _usdaAsyncFoodReport = null) : base()
        {
            usdaAsync = _usdaAsync;
            usdaAsyncFoodReport = _usdaAsyncFoodReport;
        }

        // GET: Ingredients
        public ActionResult Index()
        {
            ViewBag.SearchTotal = 0;
            ViewBag.TotalShown = 0;
            return View(UIType.Index.ToString());
        }


        public async Task<ActionResult> ShowResults(string searchText)
        {
             var list = await usdaAsync.FetchUsdaFoodList(searchText);
             var vm = await ListOfFoodsViewModel.MapListOfSearchedFoodsToListOfFoods(list);
            ViewBag.NoResults = "";
            if (vm == null || vm.Total == 0)
            {
                ViewBag.NoResults = "Nothing was found. Please refine your search.";
            }
            else
            {
                ViewBag.NoResults = "";
            }
            return View(UIType.Index.ToString(), vm); 
        }

        public async Task<ViewResult> Details(string ndbno)
        {
            var report = await usdaAsyncFoodReport.FetchUsdaFoodReport(ndbno);
            var vm = UsdaFoodReportViewModel.MapUsdaFoodReportToItsViewModel(report);
            return View(UIType.Details.ToString(), vm);
        }
    }
}