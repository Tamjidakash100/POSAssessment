namespace POSApplication.Models.ViewModels;

public class InvoiceInfoVm
{
    public decimal totalAmount { get; set; }
    public decimal taxAmount { get; set; }
    public decimal discountAmount { get; set; }
    public string customerId { get; set; } = null!;
    public string customerName { get; set; } = null!;
    public string customerPhone { get; set; } = null!;
    public string userName { get; set; } = null!;

    public virtual IEnumerable<InvoiceDetailsVm> invoiceDetails { get; set; }
}
