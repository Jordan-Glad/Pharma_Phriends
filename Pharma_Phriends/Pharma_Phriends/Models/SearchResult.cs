using System.Collections.Generic;

namespace Pharma_Phriends.Models
{
    public class SearchResult
    {
        public string DrugName { get; set; }
        public List<PharmaPrice> PharmaPrices { get; set; }

        public SearchResult(string drugName, List<PharmaPrice> pharmaPrices)
        {
            DrugName = drugName;
            PharmaPrices = pharmaPrices;
        }
    }
}
