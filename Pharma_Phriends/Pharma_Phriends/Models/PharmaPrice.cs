namespace Pharma_Phriends.Models
{
    public class PharmaPrice
    {
        public string PharmacyName { get; set; }
        public float Price { get; set; }
        public PharmaPrice(string pharmacyName, float price)
        {
            PharmacyName = pharmacyName;
            Price = price;
        }
    }

}
