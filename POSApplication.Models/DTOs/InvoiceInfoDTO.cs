namespace POSApplication.Models.DTOs;

public class InvoiceInfoDTO
{
    public string InvoiceNumber { get; set; } = null!;
    public DateTime InvoiceDate { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal TaxAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public string CustomerId { get; set; } = null!;
    public string CustomerName { get; set; } = null!;
    public string CustomerPhone { get; set; } = null!;
    public string UserName { get; set; } = null!;

    public virtual IEnumerable<InvoiceDetailsDTO> InvoiceDetails { get; set; }
}
