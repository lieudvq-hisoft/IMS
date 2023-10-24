using AutoMapper;
using Data.Entities;
using Data.Model;
using Data.Models;

namespace Services.Mapping;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<User, UserModel>();
        CreateMap<User, UserViewModel>();

        CreateMap<Customer, CustomerModel>()
            .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.User.Address))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User.Email))
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.User.PhoneNumber))
            .ForMember(dest => dest.Fullname, opt => opt.MapFrom(src => src.User.Fullname))
            .ForMember(dest => dest.CompanyType, opt => opt.MapFrom(src => src.CompanyType.Name));

        CreateMap<CompanyType, CompanyTypeModel>();

        CreateMap<Service, ServiceModel>();

        CreateMap<Colocation, ColocationModel>();
        CreateMap<Colocation, ColocationRequestModel>()
            .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Customer.CompanyName))
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.GetColocationRequestType()))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.GetColocationRequestStatus()));

        CreateMap<Area, AreaModel>();
        CreateMap<Rack, RackModel>();
        CreateMap<Rack, RackDetailModel>();
        CreateMap<Location, LocationModel>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Device.Server != null ? src.Device.Server.Model : src.Device.Type))
            .ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.Device.Size))
            .ForMember(dest => dest.StartPosition, opt => opt.MapFrom(src => src.StartPosition));
    }
}
