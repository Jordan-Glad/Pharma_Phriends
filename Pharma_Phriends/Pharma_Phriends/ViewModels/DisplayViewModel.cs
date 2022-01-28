using Microsoft.AspNetCore.Mvc.Rendering;
using Pharma_Phriends.Data;
using Pharma_Phriends.Models;
using System.Collections.Generic;

namespace Pharma_Phriends.ViewModels
{
    public class DisplayViewModel


    {
        public List<SelectListItem> AllDrugs { get; set; }
        public List<RxDrug> RxDrugs { get; set; }
        public string RxDrugDescription { get; set; }
        public string RxDrugName { get; set; }
        public float Prices { get; set; }
        public string Pharmacy { get; set; }


        private ApplicationDbContext context;
        public DisplayViewModel(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
        public DisplayViewModel(string rxDrugDescription, string rxDrugName)
        {
            RxDrugDescription = rxDrugDescription;
            RxDrugName = rxDrugName;
        }
        public DisplayViewModel(List<RxDrug> rxDrugs)
             {
            AllDrugs = new List<SelectListItem>();

            foreach (var drug in rxDrugs)
            {
                AllDrugs.Add(new SelectListItem
                {
                  
                    Text = drug.DrugName,
                   /* Text = drug.DrugDescription*/
                });
            }
        }

    }
}
