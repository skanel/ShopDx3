using System.ComponentModel.DataAnnotations;

namespace ShopDx3.ViewModels
{
    public class PriceInventoryVm : InventoryVm
    {
        [Required(ErrorMessage = "Cost is required")]
        public string Price { get; set; }
    }
}