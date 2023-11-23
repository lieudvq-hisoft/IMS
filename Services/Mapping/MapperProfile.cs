using AutoMapper;
using Data.Entities;
using Data.Enums;
using Data.Models;

namespace Services.Mapping;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        #region Customer
        CreateMap<Customer, CustomerModel>();
        CreateMap<CustomerCreateModel, Customer>();
        CreateMap<CustomerUpdateModel, Customer>();
        CreateMap<User, UserModel>();
        #endregion

        #region ServerHardware
        CreateMap<Component, ComponentModel>()
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type.ToString()));
        CreateMap<ComponentCreateModel, Component>();
        CreateMap<ComponentUpdateModel, Component>();

        CreateMap<ServerHardwareConfig, ServerHardwareConfigModel>()
            .AfterMap((src, dest, context) =>
                dest.Component = context.Mapper.Map<Component, ComponentModel>(src.Component));
        CreateMap<ServerHardwareConfigCreateModel, ServerHardwareConfig>();
        CreateMap<ServerHardwareConfigUpdateModel, ServerHardwareConfig>();

        CreateMap<RequestUpgrade, RequestUpgradeModel>();
        CreateMap<RequestUpgrade, RequestUpgradeDetailModel>();
        CreateMap<RequestUpgradeCreateModel, RequestUpgrade>();
        CreateMap<RequestUpgradeUpdateModel, RequestUpgrade>();
        #endregion'

        #region ServerAllocation
        CreateMap<ServerAllocation, ServerAllocationModel>()
            .ForMember(dest => dest.MasterIp, opt => opt.MapFrom(src => src.IpAssignments.FirstOrDefault(x => x.Type == IpAssignmentTypes.Master).IpAddress.Address));
        CreateMap<ServerAllocationCreateModel, ServerAllocation>();
        CreateMap<ServerAllocationUpdateModel, ServerAllocation>();
        #endregion

        #region Location
        CreateMap<Area, AreaModel>();
        CreateMap<AreaCreateModel, Area>();
        CreateMap<AreaUpdateModel, Area>();

        CreateMap<Rack, RackModel>();
        CreateMap<RackCreateModel, Rack>();
        CreateMap<RackUpdateModel, Rack>();

        CreateMap<Location, LocationModel>();

        CreateMap<LocationAssignment, LocationAssignmentModel>();
        CreateMap<LocationAssignmentCreateModel, LocationAssignment>();
        #endregion

        #region User
        CreateMap<User, UserModel>();
        CreateMap<AppointmentUser, AppointmentUserModel>();
        CreateMap<RequestUpgradeUser, RequestUpgradeUserModel>();
        CreateMap<RequestExpandUser, RequestExpandUserModel>();

        #endregion

        #region Appointment
        CreateMap<RequestUpgradeAppointmentUpdateModel, RequestUpgradeAppointment>();
        CreateMap<RequestAppointmentCreateModel, RequestUpgradeAppointment>();
        CreateMap<RequestUpgradeAppointment, RequestUpgradeAppointmentModel>();

        CreateMap<Appointment, AppointmentModel>()
            .AfterMap((src, dest, context) =>
                dest.ServerAllocation = context.Mapper.Map<ServerAllocation, ServerAllocationModel>(src.ServerAllocation));
        CreateMap<AppointmentCreateModel, Appointment>();
        CreateMap<AppointmentUpdateModel, Appointment>();
        CreateMap<AppointmentCompleteModel, Appointment>();
        #endregion

        #region RequestExpand
        CreateMap<RequestExpand, RequestExpandModel>();
        CreateMap<RequestExpandCreateModel, RequestExpand>();
        CreateMap<RequestExpandUpdateModel, RequestExpand>();

        CreateMap<RequestExpandLocation, RequestExpandLocationModel>();
        CreateMap<RequestExpandLocationCreateModel, RequestExpandLocation>();

        CreateMap<RequestExpandAppointment, RequestExpandAppointmentModel>();
        CreateMap<RequestExpandAppointmentCreateModel, RequestExpandAppointment>();
        #endregion

        #region CompanyType
        CreateMap<CompanyType, CompanyTypeModel>();
        #endregion

        #region IP
        CreateMap<IpAddress, IpAddressModel>();
        CreateMap<IpSubnet, IpSubnetModel>();

        CreateMap<IpAssignment, IpAssignmentModel>();
        CreateMap<IpAssignmentCreateModel, IpAssignment>();
        CreateMap<IpAssignmentUpdateModel, IpAssignment>();
        #endregion
    }
}
