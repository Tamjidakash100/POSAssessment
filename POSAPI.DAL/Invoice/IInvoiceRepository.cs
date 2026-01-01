using POSAPI.Models.DTOs;
using POSAPI.Models.ViewModels;

namespace POSAPI.DAL.Invoice;

public interface IInvoiceRepository
{
    ResponseModel AddInvoice (InvoiceInfoVm invoiceInfoVm);
    List<InvoiceInfoDTO> Getinvoices ();
}
