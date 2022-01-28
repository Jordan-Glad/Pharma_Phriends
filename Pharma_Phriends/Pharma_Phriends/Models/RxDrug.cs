namespace Pharma_Phriends.Models
{
    public class RxDrug
    {
        public int Id { get; set; }
        public string DrugName { get; set; }
        public string DrugDescription { get; set; }
    

    public RxDrug (string drugName, string drugDescription)
        {
            DrugName = drugName;
            DrugDescription = drugDescription;
        }
}
}
