using Microsoft.AspNetCore.Mvc;
using Pharma_Phriends.Data;
using Pharma_Phriends.Models;
using Pharma_Phriends.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Pharma_Phriends.Controllers
{
    public class SearchController : Controller
    {
        private ApplicationDbContext context;
        public SearchController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            List<RxDrug> rxDrugs = context.RxDrugs.ToList();
           
             return View(rxDrugs);
        }

        
        public IActionResult SearchDrug()
        {
        List<RxDrug> rxDrugs = context.RxDrugs.ToList();
            SearchViewModel searchViewModel = new SearchViewModel(context.RxDrugs.ToList());
        return View(searchViewModel);
        }

        
        /*public IActionResult ProcessSearchDrugForm(SearchViewModel searchViewModel)
        {
            if (ModelState.IsValid)
            {
                RxDrug theRxDrug = context.RxDrugs.Find(searchViewModel.RxDrugsId)
                RxDrug rxDrug = new RxDrug
                {
                    DrugName = SearchViewModel.DrugName,
                    RxDrugsId = SearchViewModel.RxDrugsId,
                    RxDrug = context.RxDrugs.Find()
                    
                };
            }
        }*/
     
    }
}
