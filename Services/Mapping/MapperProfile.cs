using AutoMapper;
using Data.Entities;
using Data.Enums;
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

        CreateMap<Colocation, ColocationModel>();
        CreateMap<Colocation, ColocationRequestModel>()
            .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Customer.CompanyName))
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => GetColocationRequestType(src)))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => GetColocationRequestStatus(src)));

        CreateMap<Area, AreaModel>();
        CreateMap<Rack, RackModel>();
        CreateMap<Rack, RackDetailModel>();
        CreateMap<Location, LocationModel>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Device.Server != null ? src.Device.Server.Model : src.Device.Type))
            .ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.Device.Size))
            .ForMember(dest => dest.StartPosition, opt => opt.MapFrom(src => src.StartPosition));
    }

    private string GetColocationRequestType(Colocation colocation)
    {
        ColocationRequestType type;
        if (colocation.Status != ColocationStatus.Ongoing && colocation.Status != ColocationStatus.Stopped)
        {
            if (colocation.AdditionalServices.Any(x => x.Status != AdditionalServiceStatus.Success))
            {
                type = ColocationRequestType.Mixed;
            }
            else
            {
                type = ColocationRequestType.New;
            }
        }
        else
        {
            type = ColocationRequestType.Additional;
        }

        return type.ToString();
    }

    private string GetColocationRequestStatus(Colocation colocation)
    {
        string status;
        if (colocation.Status != ColocationStatus.Ongoing && colocation.Status != ColocationStatus.Stopped)
        {
            status = colocation.Status.ToString();
        }
        else
        {
            var services = colocation.AdditionalServices;
            if (services.All(x => x.Status == AdditionalServiceStatus.Success))
            {
                status = "Accepted";
            }
            else if (services.All(x => x.Status == AdditionalServiceStatus.Denied))
            {
                status = "Denied";
            }
            else if (services.All(x => x.Status == AdditionalServiceStatus.Pending))
            {
                status = "Pending";
            }
            else
            {
                status = "Mixed";
            }
        }

        return status;
    }
}
