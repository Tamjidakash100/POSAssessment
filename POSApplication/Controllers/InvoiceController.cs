using Microsoft.AspNetCore.Mvc;
using POSApplication.DAL.Invoice;
using POSApplication.Models.ViewModels;
using System.Threading.Tasks;

namespace POSApplication.Controllers;

public class InvoiceController(IInvoiceRepository invoiceRepository) : Controller
{
    public async Task<IActionResult> Index()
    {
        var invoices = await invoiceRepository.GetInvoices();
        return View(invoices);
    }
    
    public IActionResult AddInvoice()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> AddInvoice(InvoiceInfoVm invoiceInfo)
    {
        var response = await invoiceRepository.AddInvoice(invoiceInfo);
        return Ok(response);
    }
}
