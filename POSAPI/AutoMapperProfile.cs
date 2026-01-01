using AutoMapper;
using POSAPI.Models.DTOs;
using POSAPI.Models.Models;
using POSAPI.Models.ViewModels;

namespace POSAPI;

public class AutoMapperProfile: Profile
{
    public AutoMapperProfile()
    {

        CreateMap<InvoiceInfo, InvoiceInfoVm>().ReverseMap();
        CreateMap<InvoiceInfo, InvoiceInfoDTO>().ReverseMap();
        CreateMap<InvoiceDetails, InvoiceDetailsVm>().ReverseMap();
        CreateMap<InvoiceDetails, InvoiceDetailsDTO>().ReverseMap();

    }
}

