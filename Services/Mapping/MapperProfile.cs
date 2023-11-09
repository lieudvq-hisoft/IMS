using AutoMapper;
using Data.Entities;
using Data.Models;
using OfficeOpenXml.Style;

namespace Services.Mapping;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        //#region ServiceRequestModel
        //CreateMap<ServiceRequest, ServiceRequestModel>()
        //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Service.Name))
        //    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.DisplayStatus()));
        //#endregion

        //#region Request
        //CreateMap<Request, RequestModel>()
        //    .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.User.Fullname))
        //    .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.GetRequestType()))
        //    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.GetRequestStatus()))
        //    .ForMember(dest => dest.ServiceRequestModels, opt => opt.MapFrom((src, dest, i, context) => context.Mapper.Map<List<ServiceRequestModel>>(src.ServiceRequests)));
        //#endregion

        //#region CompanyType
        //CreateMap<CompanyType, CompanyTypeModel>();
        //#endregion

        //#region User
        //CreateMap<User, UserModel>();
        //CreateMap<User, UserViewModel>();
        //#endregion

        //#region Customer
        //CreateMap<Customer, CustomerModel>()
        //    .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.User.Address))
        //    .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User.Email))
        //    .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.User.PhoneNumber))
        //    .ForMember(dest => dest.Fullname, opt => opt.MapFrom(src => src.User.Fullname))
        //    .ForMember(dest => dest.CompanyType, opt => opt.MapFrom(src => src.CompanyType.Name));
        //#endregion

        //#region Service
        //CreateMap<Service, ServiceModel>();
        //#endregion

        //#region Location
        //CreateMap<Area, AreaModel>();
        //CreateMap<Rack, RackModel>();
        //CreateMap<Rack, RackDetailModel>();
        //CreateMap<Location, LocationModel>()
        //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Device.Server != null ? src.Device.Server.Model : src.Device.Type))
        //    .ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.Device.Size))
        //    .ForMember(dest => dest.StartPosition, opt => opt.MapFrom(src => src.StartPosition));
        //#endregion

        //#region Server
        //CreateMap<Server, ServerForAppointmentModel>();
        //CreateMap<Server, ServerModel>()
        //    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.DisplayStatus()))
        //    .ForMember(dest => dest.IpAddress, opt => opt.MapFrom(src => src.IpAssignments.FirstOrDefault(x => x.Type == Data.Enums.IpAssignmentType.Host).Ip.DisplayIp()))
        //    .ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.Device.Size + src.Device.AdditionalSize))
        //    .ForMember(dest => dest.Power, opt => opt.MapFrom(src => src.Device.BasePower + src.Device.AdditionalPower))
        //    .ForMember(dest => dest.Customer, opt => opt.MapFrom(src => src.Request.Customer.User.Fullname));
        //CreateMap<Server, ServerDetailModel>()
        //    .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Request.Customer.CompanyName))
        //    .ForMember(dest => dest.Customer, opt => opt.MapFrom(src => src.Request.Customer.User.Fullname))
        //    .ForMember(dest => dest.ReceiptOfRecipientFilePath, opt => opt.MapFrom(src => src.Request.ReceiptOfRecipientFilePath))
        //    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Request.Status))
        //    .ForMember(dest => dest.DateCreated, opt => opt.MapFrom(src => src.Request.DateCreated))
        //    .ForMember(dest => dest.BasePower, opt => opt.MapFrom(src => src.Device.BasePower))
        //    .ForMember(dest => dest.Power, opt => opt.MapFrom(src => src.Device.BasePower + src.Device.AdditionalPower))
        //    .ForMember(dest => dest.BaseSize, opt => opt.MapFrom(src => src.Device.Size))
        //    .ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.Device.Size + src.Device.AdditionalSize))
        //    .ForMember(dest => dest.DateCreated, opt => opt.MapFrom(src => src.Request.DateCreated))
        //    .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Device.Locations.FirstOrDefault().Rack.DisplayRack()))
        //    .ForMember(dest => dest.IpAddress, opt => opt.MapFrom(src => src.IpAssignments.FirstOrDefault(x => x.Type == Data.Enums.IpAssignmentType.Host).Ip.DisplayIp()))
        //    .ForMember(dest => dest.RequestExtendHistoryModel, opt => opt.MapFrom(src => src.Request.RequestExtendHistories.Where(x => x.IsAccepted)))
        //    .ForMember(dest => dest.ServiceRequests, opt => opt.MapFrom((src, dest, i, context) => context.Mapper.Map<List<ServiceRequestModel>>(src.Request.ServiceRequests)));
        //#endregion

        //#region Device
        //CreateMap<Device, DeviceModel>()
        //     .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.DisplayStatus()))
        //     .ForMember(dest => dest.BaseSize, opt => opt.MapFrom(src => src.Size))
        //     .ForMember(dest => dest.Rack, opt => opt.MapFrom(src => src.Locations.FirstOrDefault().Rack.DisplayRack()));
        //#endregion

        //#region IpAssignment
        //CreateMap<IpAssignment, IpAssignmentModel>()
        //     .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.DisplayStatus()))
        //     .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.DisplayContent()))
        //     .ForMember(dest => dest.IpAddress, opt => opt.MapFrom(src => src.Ip.DisplayIp()));
        //#endregion
        //#region AppointmentSchedule
        //CreateMap<AppointmentSchedule, AppointmentScheduleModel>()
        //    .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Customer.CompanyName))
        //    .ForMember(dest => dest.ServerModel, opt => opt.MapFrom((src, dest, i, context) => context.Mapper.Map<List<ServerForAppointmentModel>>(src.ServerAppointments.Select(x => x.Server))));
        //CreateMap<AppointmentSchedule, AppointmentScheduleDetailModel>()
        //    .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Customer.CompanyName))
        //    .ForMember(dest => dest.ServerModel, opt => opt.MapFrom((src, dest, i, context) => context.Mapper.Map<List<ServerForAppointmentModel>>(src.ServerAppointments.Select(x => x.Server))));
        //#endregion
    }
}
