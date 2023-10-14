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

        CreateMap<Collocation, CollocationModel>()
            .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Customer.CompanyName));
    }
}
