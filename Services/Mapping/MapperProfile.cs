using AutoMapper;
using Data.Entities;
using Data.Models;

namespace Services.Mapping;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        #region
        CreateMap<Customer, CustomerModel>();
        #endregion

        #region Server
        CreateMap<Component, ComponentModel>();
        CreateMap<ComponentCreateModel, Component>();
        CreateMap<ComponentUpdateModel, Component>();

        CreateMap<ServerHardwareConfig, ServerHardwareConfigModel>();
        CreateMap<ServerHardwareConfigCreateModel, ServerHardwareConfig>();
        CreateMap<ServerHardwareConfigUpdateModel, ServerHardwareConfig>();
        #endregion'

        #region ServerAllocationModel
        CreateMap<ServerAllocation, ServerAllocationModel>();
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
