using Newtonsoft.Json;
using POSApplication.Models.DTOs;
using POSApplication.Models.ViewModels;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
namespace POSApplication.DAL.Invoice;

public class InvoiceRepository() : IInvoiceRepository
{
    string baseAddress = "https://localhost:7015/api/";
    private static readonly HttpClient _httpClient = new HttpClient();
    public async Task<ResponseModel> AddInvoice(InvoiceInfoVm invoice)
    {

        invoice.userName = "Test";
        invoice.customerId = "Test";
        string jsonPayload = JsonConvert.SerializeObject(invoice);

        using (var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json"))
        {
            string url = baseAddress + "Invoice";
            HttpResponseMessage response = await _httpClient.PostAsync(url, content);

            ResponseModel responseModel = new()
            {
                Code = response.IsSuccessStatusCode ? 200 : 400,
                Message = response.IsSuccessStatusCode ? "Successful" : "An error occured",
            };

            return responseModel;
        }
    }

    public async Task<List<InvoiceInfoDTO>> GetInvoices()
    {
        string url = baseAddress + "Invoice";
        var invoices = await _httpClient.GetFromJsonAsync<List<InvoiceInfoDTO>>(url);

        return invoices;

    }
}
