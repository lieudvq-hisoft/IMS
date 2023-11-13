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
        CreateMap<User, UserModel>();
        #endregion

        #region Server
        CreateMap<Component, ComponentModel>()
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type.ToString()));
        CreateMap<ComponentCreateModel, Component>();
        CreateMap<ComponentUpdateModel, Component>();

        CreateMap<ServerHardwareConfig, ServerHardwareConfigModel>();
        CreateMap<ServerHardwareConfigCreateModel, ServerHardwareConfig>();
        CreateMap<ServerHardwareConfigUpdateModel, ServerHardwareConfig>();

        CreateMap<RequestUpgrade, RequestUpgradeModel>();
        CreateMap<RequestUpgradeCreateModel, RequestUpgrade>();
        CreateMap<RequestUpgradeUpdateModel, RequestUpgrade>();
        #endregion'

        #region ServerAllocationModel
        CreateMap<ServerAllocation, ServerAllocationModel>();
        #endregion

        #region Service
        CreateMap<Request, RequestModel>();
        #endregion

        #region Location
        CreateMap<Area, AreaModel>();
        CreateMap<Rack, RackModel>();
        #endregion

        #region User
        CreateMap<User, UserModel>();
        #endregion
    }
}
