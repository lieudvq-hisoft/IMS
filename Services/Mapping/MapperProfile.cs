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

        CreateMap<Customer, CustomerModel>()
            .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.User.Address))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User.Email))
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.User.PhoneNumber))
            .ForMember(dest => dest.Fullname, opt => opt.MapFrom(src => src.User.Fullname))
            .ForMember(dest => dest.CompanyType, opt => opt.MapFrom(src => src.CompanyType.Name));

        CreateMap<CompanyType, CompanyTypeModel>();

        CreateMap<Service, ServiceModel>();

        CreateMap<Collocation, CollocationModel>();
        CreateMap<Collocation, CollocationRequestModel>()
            .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Customer.CompanyName))
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => GetCollocationRequestType(src)));

        CreateMap<Area, AreaModel>();
        CreateMap<Rack, RackModel>();
        CreateMap<Rack, RackDetailModel>();
        CreateMap<Location, LocationModel>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Device.Server != null? src.Device.Server.Model: src.Device.Type ))
            .ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.Device.Size))
            .ForMember(dest => dest.StartPosition, opt => opt.MapFrom(src => src.StartPosition));
    }

    private string GetCollocationRequestType(Collocation collocation)
    {
        string type = "";
        if (collocation.Status == Data.Enums.CollocationStatus.Pending)
        {
            if (collocation.AdditionalServices.Any(x => x.Status == Data.Enums.AdditionalServiceStatus.Pending))
            {
                type = "Mix";
            }
            else
            {
                type = "New Collocation";
            }
        }
        else
        {
            type = "Addtional Service";
        }

        return type;
    }
}
