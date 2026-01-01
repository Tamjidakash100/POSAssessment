using POSAPI.Models.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSAPI.Models.ViewModels;

public class InvoiceDetailsVm
{

    public int ItemId { get; set; }
    public int Quantity { get; set; }
    public string UnitType { get; set; }
    public decimal UnitPrice { get; set; }
}
