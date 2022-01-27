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

 

        [HttpGet]
        public IActionResult Index()
        {
            SearchViewModel searchView = new SearchViewModel(context.RxDrugs.ToList());
            return View(searchView);
        }

        [HttpPost]
        public IActionResult Index(SearchViewModel searchViewModel)
        {
            SearchViewModel searchView = new SearchViewModel(context.RxDrugs.ToList());
            if (ModelState.IsValid)
            {
                RxDrug theRxDrug = context.RxDrugs.Find(searchViewModel.RxDrugsId);
                List<Pharmacy> pharmacies = context.Pharmacies
                    .Where(p => p.ZipCode == searchViewModel.ZipCode)
                    .ToList();
                List<Price> prices = new List<Price>();
                foreach (Pharmacy phar in pharmacies)
                {
                    Price price = context.Prices
                        .Where(price => price.PharmacyId == phar.Id)
                        .Where(price => price.RxDrugsId == theRxDrug.Id)
                        .Single();
                    prices.Add(price);
                }
                
               searchView.RxDrugName = theRxDrug.DrugName;
               searchView.Prices = prices;
               searchView.Pharmacies = pharmacies;
                SearchViewModel viewModel = new SearchViewModel(theRxDrug, prices, pharmacies);
                List<Display> theDisplay = new List<Display>();
                

          


                return View(searchView);

            }  
                  
            return View(searchView);
        }




    }
}
