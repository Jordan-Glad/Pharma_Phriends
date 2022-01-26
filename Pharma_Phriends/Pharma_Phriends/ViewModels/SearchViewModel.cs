using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Pharma_Phriends.Models;
using System.ComponentModel.DataAnnotations;

namespace Pharma_Phriends.ViewModels
{
    public class SearchViewModel
    {
        public string DrugName { get; set; }
        public int RxDrugsId { get; set; }
        public List<SelectListItem> AllDrugs { get; set; }
        public List<RxDrug> RxDrugs { get; set; }
        [Required]
        public int ZipCode { get; set; }

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
