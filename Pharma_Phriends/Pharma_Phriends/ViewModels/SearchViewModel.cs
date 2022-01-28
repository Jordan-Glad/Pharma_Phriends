using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Pharma_Phriends.Models;
using System.ComponentModel.DataAnnotations;
using Pharma_Phriends.Controllers;
using Pharma_Phriends.Data;

namespace Pharma_Phriends.ViewModels
{
    public class SearchViewModel
    {
        public int RxDrugsId { get; set; }
        public List<SelectListItem> AllDrugs { get; set; }
        public List<RxDrug> RxDrugs { get; set; }
        [Required]
        public int ZipCode { get; set; }
        public string RxDrugName { get; set; }
        public List<Price> Prices { get; set; }
        public List<Pharmacy> Pharmacies { get; set; }
        public float DrugPrice { get; set; }
        public SearchViewModel(){ }
        public string ListPrice     { get; set; }
        public List<Display> Display { get; set; }
        public SearchController ViewModel { get; set; }

        private ApplicationDbContext context;
        public SearchViewModel(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        public SearchViewModel(List<RxDrug> rxDrugs)
       
           
        {
            AllDrugs = new List<SelectListItem>();

            foreach(var drug in rxDrugs)
            {
                AllDrugs.Add(new SelectListItem
                {
                    Value = drug.Id.ToString(),
                    Text = drug.DrugName
                });
            }
        }

        public SearchViewModel(RxDrug theRxDrug, List<Price> prices, List<Pharmacy> pharmacies)
        {

            RxDrugName = theRxDrug.DrugName;

            Prices = prices;
            Pharmacies = pharmacies;
        }

        public SearchViewModel(SearchController viewModel)
        {
            
        }
    }
}
