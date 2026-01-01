using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POSAPI.DAL.Invoice;
using POSAPI.Models.Models;
using POSAPI.Models.ViewModels;

namespace POSAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InvoiceController(IInvoiceRepository invoiceRepository) : ControllerBase
{
    [HttpPost]
    public IActionResult AddInvoice([FromBody] InvoiceInfoVm invoice)
    {
        var response = invoiceRepository.AddInvoice(invoice);
        return Ok(response);
    }
    [HttpGet]
    public IActionResult GetInvoices()
    {
        var invoices = invoiceRepository.Getinvoices();
        return Ok(invoices);
    }
}
