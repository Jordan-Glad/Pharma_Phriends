using Microsoft.AspNetCore.Mvc.Rendering;
using Pharma_Phriends.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pharma_Phriends.View_Model
{
    public class AddDrugSearchListViewModel
    {
        public RxDrug RxDrugs { get; set; }
        [Required]
        public int RxDrugsId { get; set; }

        [Required]
        public string DrugName { get; set; }
        public List<RxDrug> RxDrugsList { get; set; }

        /*public List<int> SkillIds { get; set; }*/

        public List<SelectListItem> AllDrugs { get; set; }

        public int PharmacyId { get; set; }
        public Pharmacy Pharmacy { get; set; }
        public float DrugPrice { get; set; }
        public List<Pharmacy> PharmacyList { get;set; }
        public List<Price>  PriceList { get; set; }


        public AddDrugSearchListViewModel(List<RxDrug> rxDrugsList)
        {

            AllDrugs = new List<SelectListItem>();

            foreach (var drug in rxDrugsList)
            {
                AllDrugs.Add(new SelectListItem
                {
                    Value = drug.Id.ToString(),
                    Text = drug.DrugName
                });
            }

        }
        public AddDrugSearchListViewModel()
        {
        }
    }
}
