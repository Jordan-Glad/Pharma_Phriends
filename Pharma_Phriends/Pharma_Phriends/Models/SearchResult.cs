using System.Collections.Generic;

namespace Pharma_Phriends.Models
{
    public class SearchResult
    {
        public int RxDrugId { get; set; }
        public string DrugName { get; set; }
        public List<PharmaPrice> PharmaPrices { get; set; }

        public SearchResult(string drugName, List<PharmaPrice> pharmaPrices, int rxDrugId)
        {
            DrugName = drugName;
            PharmaPrices = pharmaPrices;
            RxDrugId = rxDrugId;
        }
    }
}
