using Pharma_Phriends.Models;

namespace Pharma_Phriends.ViewModels
{
    public class DetailViewModel
    {
        public int RxDrugId { get; set; }
        public string RxDrugName { get; set; }

        public string DrugDescription { get; set; }

        public DetailViewModel(RxDrug rxDrug)
        {
            RxDrugId = rxDrug.Id;
            RxDrugName = rxDrug.DrugName;
            DrugDescription = rxDrug.DrugDescription;
        }

    }
}
