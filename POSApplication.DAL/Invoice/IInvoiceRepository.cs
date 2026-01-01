using POSApplication.Models.DTOs;
using POSApplication.Models.ViewModels;

namespace POSApplication.DAL.Invoice;

public interface IInvoiceRepository
{
    Task<ResponseModel> AddInvoice(InvoiceInfoVm invoice);
    Task<List<InvoiceInfoDTO>> GetInvoices();
}
