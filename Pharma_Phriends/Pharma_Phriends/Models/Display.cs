namespace Pharma_Phriends.Models
{
    public class Display
    {
        public int RxDrugsId { get; set; }
        public RxDrug RxDrug    { get; set; }
        public string RxDrugName { get; set; }
        
        public int PharmacyId { get; set; }
        public Pharmacy Pharmacy { get; set; }
        public float Prices { get; set; }
        public string PharmacyName { get; set; }
    

    public Display() { }

    public Display(RxDrug theRxDrug, Pharmacy thePharmacy, float Prices)
        {

            RxDrug = theRxDrug;
            Pharmacy = thePharmacy;
          


        }
}
}