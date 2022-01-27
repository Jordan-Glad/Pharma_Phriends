using System;


namespace Pharma_Phriends.Models
{
    public class Display
    {
        public int RxDrugsId { get; set; }
        public RxDrug RxDrug { get; set; }
        public string RxDrugName { get; set; }
        public int PharmacyId { get; set; }
        public Pharmacy Pharmacy { get; set; }
        public float DrugPrice { get; set; }
        
        public Display()
        {
        }
  
    }
    

}
