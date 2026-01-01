using POSAPI.Models.Models;

namespace POSAPI.Models.ViewModels;

public class InvoiceInfoVm
{
    public decimal TotalAmount { get; set; }
    public decimal TaxAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public string CustomerId { get; set; } = null!;
    public string CustomerName { get; set; } = null!;
    public string CustomerPhone { get; set; } = null!;
    public string UserName { get; set; } = null!;

    public virtual IEnumerable<InvoiceDetailsVm> InvoiceDetails { get; set; }
}
