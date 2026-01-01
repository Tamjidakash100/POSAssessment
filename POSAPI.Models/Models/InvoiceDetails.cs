using System.ComponentModel.DataAnnotations.Schema;

namespace POSAPI.Models.Models;

public class InvoiceDetails
{
    public int InvoiceDetailsId { get; set; }
    
    public int InvoiceInfoId { get; set; }
    [ForeignKey(nameof(InvoiceInfoId))]
    public InvoiceInfo InvoiceInfo { get; set; }
    public int ItemId { get; set; }
    public string ItemName { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public string UnitType { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }
}
