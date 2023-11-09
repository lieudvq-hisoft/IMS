using AutoMapper;
using Data.Entities;
using Data.Models;
using OfficeOpenXml.Style;

namespace Services.Mapping;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        #region
        CreateMap<Customer, CustomerModel>();
        #endregion

        #region Request
        CreateMap<Request, RequestModel>();
        #endregion

        #region Service
        CreateMap<Service, ServiceModel>();
        #endregion
    }
}
