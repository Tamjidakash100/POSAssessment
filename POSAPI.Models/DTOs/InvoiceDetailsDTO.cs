using System.ComponentModel.DataAnnotations.Schema;

namespace POSAPI.Models.DTOs;

public class InvoiceDetailsDTO
{

    public int ItemId { get; set; }
    public int Quantity { get; set; }
    public string UnitType { get; set; }
    public decimal UnitPrice { get; set; }
}
