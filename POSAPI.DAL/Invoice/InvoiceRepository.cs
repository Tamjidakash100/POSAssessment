using AutoMapper;
using Microsoft.EntityFrameworkCore;
using POSAPI.Models.Context;
using POSAPI.Models.DTOs;
using POSAPI.Models.Models;
using POSAPI.Models.ViewModels;

namespace POSAPI.DAL.Invoice;

public class InvoiceRepository(POSDbContext context, IMapper mapper) : IInvoiceRepository
{
    public ResponseModel AddInvoice(InvoiceInfoVm invoiceInfoVm)
    {
        try
        {
            InvoiceInfo invoice = mapper.Map<InvoiceInfo>(invoiceInfoVm);
            invoice.InvoiceNumber = Guid.NewGuid().ToString();
            invoice.InvoiceDate = DateTime.Now;

            var response = context.InvoiceInfos.Add(invoice);
            context.SaveChanges();

            return new ResponseModel
            {
                Code = 200,
                Message = "Invoice added successfully",
                Data = response.Entity.InvoiceNumber
            };

        }
        catch (Exception ex)
        {
            return new ResponseModel
            {
                Code = -1,
                Message = ex.Message,
            };
        }

    }

    public List<InvoiceInfoDTO> Getinvoices()
    {
        var invoices = context.InvoiceInfos.Include(x => x.InvoiceDetails).ToList();
        var invoiceVm = mapper.Map<List<InvoiceInfoDTO>>(invoices);
        return invoiceVm;
    }
}
