using AutoMapper;
using Data.Entities;
using Data.Entities.Pending;
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

        CreateMap<RequestUpgrade, RequestUpgradeModel>()
            .AfterMap((src, dest, context) =>
                dest.Component = context.Mapper.Map<Component, ComponentModel>(src.Component))
            .AfterMap((src, dest, context) =>
            {
                var creator = src.RequestUpgradeUsers.FirstOrDefault(x => x.Action == RequestUserAction.Create);
                if (creator != null)
                {
                    dest.Creator = context.Mapper.Map<User, UserModel>(creator.User);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                var evaluator = src.RequestUpgradeUsers.FirstOrDefault(x => x.Action == RequestUserAction.Evaluate);
                if (evaluator != null)
                {
                    dest.Evaluator = context.Mapper.Map<User, UserModel>(evaluator.User);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                var executor = src.RequestUpgradeUsers.FirstOrDefault(x => x.Action == RequestUserAction.Execute);
                if (executor != null)
                {
                    dest.Executor = context.Mapper.Map<User, UserModel>(executor.User);
                }
            });
        CreateMap<RequestUpgrade, RequestUpgradeDetailModel>();
        CreateMap<RequestUpgradeCreateModel, RequestUpgrade>();
        CreateMap<RequestUpgradeUpdateModel, RequestUpgrade>();
        #endregion'

        #region ServerAllocation
        CreateMap<ServerAllocation, ServerAllocationModel>()
            .ForMember(dest => dest.MasterIp, opt => opt.MapFrom(src => src.IpAssignments.FirstOrDefault(x => x.Type == IpAssignmentTypes.Master).IpAddress.Address))
            .AfterMap((src, dest, context) =>
                dest.Customer = context.Mapper.Map<Customer, CustomerModel>(src.Customer));
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

        CreateMap<Appointment, AppointmentModel>();
        CreateMap<Appointment, AppointmentResultModel>();
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
        CreateMap<IpSubnet, IpSubnetModel>()
            .ForMember(dest => dest.SubnetIds, opt => opt.MapFrom(src => src.SubNets.Select(x => x.Id)));

        CreateMap<IpAssignment, IpAssignmentModel>();
        CreateMap<IpAssignmentCreateModel, IpAssignment>();
        CreateMap<IpAssignmentUpdateModel, IpAssignment>();
        #endregion

        #region ResultModel
        CreateMap<ServerHardwareConfig, ServerHardwareConfigResultModel>();
        CreateMap<ServerAllocation, ServerAllocationResultModel>();
        CreateMap<RequestUpgrade, RequestUpgradeResultModel>();
        CreateMap<RequestExpand, RequestExpandResultModel>();
        CreateMap<RequestUpgradeUser, RequestUpgradeUserResultModel>();
        CreateMap<RequestUpgradeAppointment, RequestUpgradeAppointmentResultModel>();
        CreateMap<RequestHost, RequestHostResultModel>();
        CreateMap<RequestExpandLocation, RequestExpandLocationResultModel>();
        CreateMap<RequestExpandAppointment, RequestExpandAppointmentResultModel>();
        CreateMap<Rack, RackResultModel>();
        CreateMap<Location, LocationResultModel>();
        CreateMap<LocationAssignment, LocationAssignmentResultModel>();
        CreateMap<IpSubnet, IpSubnetResultModel>();
        CreateMap<IpAddress, IpAddressResultModel>();
        //CreateMap<Device, DeviceResultModel>();
        CreateMap<Customer, CustomerResultModel>();
        CreateMap<Component, ComponentResultModel>();
        CreateMap<Area, AreaResultModel>();
        CreateMap<AppointmentUser, AppointmentUserResultModel>();
        CreateMap<Appointment, AppointmentResultModel>();
        #endregion
    }
}
