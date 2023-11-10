﻿using AutoMapper;
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
        CreateMap<Order, OrderModel>();
        #endregion

        #region Service
        CreateMap<Request, RequestModel>();
        #endregion

        #region Location
        CreateMap<Area, AreaModel>();
        CreateMap<Rack, RackModel>()
            .ForMember(dest => dest.Area, opt => opt.MapFrom((src, dest, i, context) => context.Mapper.Map<AreaModel>(src.Area)));
        #endregion
    }
}
