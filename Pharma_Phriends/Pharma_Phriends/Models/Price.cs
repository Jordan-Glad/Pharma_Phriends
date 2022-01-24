namespace Pharma_Phriends.Models
{
    public class Price
    {
        public int Id { get; set; }
        
        public int PharmacyId { get; set; }
        public Pharmacy Pharmacy { get; set; }

        public int DrugId { get; set; }
        public RxDrug RxDrugs { get; set; }

        
        public float DrugPrice { get; set; }
    }
}
