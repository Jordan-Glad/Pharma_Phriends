using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Pharma_Phriends.Models;
using System.ComponentModel.DataAnnotations;

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

        public SearchViewModel(){ }
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
       
    }
}
