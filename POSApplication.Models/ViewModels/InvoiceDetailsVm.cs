using System.ComponentModel.DataAnnotations.Schema;

namespace POSApplication.Models.ViewModels;

public class InvoiceDetailsVm
{

    public int itemId { get; set; }
    public string itemName { get; set; } = null!;
    public int quantity { get; set; }
    public string unitType { get; set; }
    public decimal unitPrice { get; set; }
    public decimal totalPrice { get; set; }
}
