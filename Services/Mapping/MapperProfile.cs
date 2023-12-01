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

        CreateMap<RequestUpgrade, RequestUpgradeModel>()
            .AfterMap((src, dest, context) =>
            {
                if (src.RequestUpgradeAppointments?.Any() == true)
                {
                    dest.AppointmentId = src.RequestUpgradeAppointments.Select(x => x.Appointment).FirstOrDefault(x => x.Status == RequestStatus.Accepted || x.Status == RequestStatus.Waiting)?.Id;
                }
            })
            .AfterMap((src, dest, context) =>
            {
                if (src.Component != null)
                {
                    dest.Component = context.Mapper.Map<Component, ComponentResultModel>(src.Component);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                if (src.ServerAllocation != null)
                {
                    dest.ServerAllocation = context.Mapper.Map<ServerAllocation, ServerAllocationResultModel>(src.ServerAllocation);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                var completeAppointment = src.RequestUpgradeAppointments?.Select(x => x.Appointment).FirstOrDefault(x => x.Status == RequestStatus.Success);
                if (completeAppointment != null)
                {
                    dest.SucceededAppointment = context.Mapper.Map<Appointment, AppointmentResultModel>(completeAppointment);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                if (src.ServerAllocation?.Customer != null)
                {
                    dest.Customer = context.Mapper.Map<Customer, CustomerResultModel>(src.ServerAllocation.Customer);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                var evaluator = src.RequestUpgradeUsers?.FirstOrDefault(x => x.Action == RequestUserAction.Evaluate);
                if (evaluator != null)
                {
                    dest.Evaluator = context.Mapper.Map<User, UserModel>(evaluator.User);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                var executor = src.RequestUpgradeUsers?.FirstOrDefault(x => x.Action == RequestUserAction.Execute);
                if (executor != null)
                {
                    dest.Executor = context.Mapper.Map<User, UserModel>(executor.User);
                }
            });
        CreateMap<RequestUpgradeCreateModel, RequestUpgrade>();
        CreateMap<RequestUpgradeUpdateModel, RequestUpgrade>();
        #endregion'

        #region ServerAllocation
        CreateMap<ServerAllocation, ServerAllocationModel>()
            .AfterMap((src, dest, context) =>
            {
                var masterIp = src.IpAssignments?.FirstOrDefault(x => x.Type == IpAssignmentTypes.Master)?.IpAddress;
                if (masterIp != null)
                {
                    dest.MasterIp = context.Mapper.Map<IpAddress, IpAddressResultModel>(masterIp);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                if (src.Customer != null)
                {
                    dest.Customer = context.Mapper.Map<Customer, CustomerModel>(src.Customer);
                }
            });
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

        CreateMap<Location, LocationModel>()
            .AfterMap((src, dest, context) =>
            {
                if (src.LocationAssignments?.Any() == true)
                {
                    dest.IsServer = src.LocationAssignments.FirstOrDefault()?.IsServer;
                }
            });
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
            {
                if (src.ServerAllocation != null)
                {
                    dest.ServerAllocation = context.Mapper.Map<ServerAllocation, ServerAllocationResultModel>(src.ServerAllocation);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                if (src.ServerAllocation?.Customer != null)
                {
                    dest.Customer = context.Mapper.Map<Customer, CustomerResultModel>(src.ServerAllocation.Customer);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                var evaluator = src.AppointmentUsers?.FirstOrDefault(x => x.Action == RequestUserAction.Evaluate);
                if (evaluator != null)
                {
                    dest.Evaluator = context.Mapper.Map<User, UserModel>(evaluator.User);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                var executor = src.AppointmentUsers?.FirstOrDefault(x => x.Action == RequestUserAction.Execute);
                if (executor != null)
                {
                    dest.Executor = context.Mapper.Map<User, UserModel>(executor.User);
                }
            });
        CreateMap<Appointment, AppointmentResultModel>();
        CreateMap<AppointmentCreateModel, Appointment>();
        CreateMap<AppointmentUpdateModel, Appointment>();
        CreateMap<AppointmentCompleteModel, Appointment>();
        #endregion

        #region RequestExpand 
        CreateMap<RequestExpand, RequestExpandModel>()
            .AfterMap((src, dest, context) =>
            {
                if (src.RequestExpandAppointments?.Any() == true)
                {
                    dest.AppointmentId = src.RequestExpandAppointments.Select(x => x.Appointment).FirstOrDefault(x => x.Status == RequestStatus.Accepted || x.Status == RequestStatus.Waiting)?.Id;
                }
            })
            .AfterMap((src, dest, context) =>
            {
                bool forRemoval = src.RemovalStatus != null;
                var completeAppointment = src.RequestExpandAppointments?.Where(x => x.ForRemoval == forRemoval).Select(x => x.Appointment).FirstOrDefault(x => x.Status == RequestStatus.Success);
                if (completeAppointment != null)
                {
                    dest.SucceededAppointment = context.Mapper.Map<Appointment, AppointmentResultModel>(completeAppointment);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                if (src.ServerAllocation?.Customer != null)
                {
                    dest.Customer = context.Mapper.Map<Customer, CustomerResultModel>(src.ServerAllocation.Customer);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                if (src.ServerAllocation != null)
                {
                    dest.ServerAllocation = context.Mapper.Map<ServerAllocation, ServerAllocationResultModel>(src.ServerAllocation);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                var evaluator = src.RequestExpandUsers?.FirstOrDefault(x => x.Action == RequestUserAction.Evaluate);
                if (evaluator != null)
                {
                    dest.Evaluator = context.Mapper.Map<User, UserModel>(evaluator.User);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                var executor = src.RequestExpandUsers?.FirstOrDefault(x => x.Action == RequestUserAction.Execute);
                if (executor != null)
                {
                    dest.Executor = context.Mapper.Map<User, UserModel>(executor.User);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                var requestExpandLocations = src.RequestExpandLocations;
                if (requestExpandLocations?.Any() == true)
                {
                    var startLocation = requestExpandLocations?.Select(x => x.Location).MinBy(x => x.Position);
                    if (startLocation != null)
                    {
                        dest.RequestedLocation = new RequestExpandAssignLocationModel
                        {
                            RackId = startLocation.RackId,
                            StartPosition = startLocation.Position,
                        };
                    }
                }
            });
        CreateMap<RequestExpandCreateModel, RequestExpand>();
        CreateMap<RequestExpandUpdateModel, RequestExpand>();

        CreateMap<RequestExpandLocation, RequestExpandLocationModel>();
        CreateMap<RequestExpandLocationCreateModel, RequestExpandLocation>();

        CreateMap<RequestExpandAppointment, RequestExpandAppointmentModel>();
        CreateMap<RequestExpandAppointmentCreateModel, RequestExpandAppointment>();
        #endregion

        //#region CompanyType
        //CreateMap<CompanyType, CompanyTypeModel>();
        //#endregion

        #region IP
        CreateMap<IpAddress, IpAddressModel>()
            .AfterMap((src, dest, context) =>
            {
                if (src.IpAssignments.FirstOrDefault()?.ServerAllocation != null)
                {
                    dest.Customer = context.Mapper.Map<Customer, CustomerResultModel>(src.IpAssignments.FirstOrDefault()?.ServerAllocation?.Customer);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                if (src.IpAssignments.FirstOrDefault()?.ServerAllocation != null)
                {
                    dest.ServerAllocation = context.Mapper.Map<ServerAllocation, ServerAllocationResultModel>(src.IpAssignments.FirstOrDefault()?.ServerAllocation);
                }
            });
        CreateMap<IpSubnet, IpSubnetModel>()
            .ForMember(dest => dest.SubnetIds, opt => opt.MapFrom(src => src.SubNets.Select(x => x.Id)));

        CreateMap<IpAssignment, IpAssignmentModel>();
        CreateMap<IpAssignmentCreateModel, IpAssignment>();
        CreateMap<IpAssignmentUpdateModel, IpAssignment>();
        #endregion

        #region RequestHost
        CreateMap<RequestHost, RequestHostModel>()
            .AfterMap((src, dest, context) =>
            {
                if (src.ServerAllocation?.Customer != null)
                {
                    dest.Customer = context.Mapper.Map<Customer, CustomerResultModel>(src.ServerAllocation.Customer);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                if (src.ServerAllocation != null)
                {
                    dest.ServerAllocation = context.Mapper.Map<ServerAllocation, ServerAllocationResultModel>(src.ServerAllocation);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                var evaluator = src.RequestHostUsers?.FirstOrDefault(x => x.Action == RequestUserAction.Evaluate);
                if (evaluator != null)
                {
                    dest.Evaluator = context.Mapper.Map<User, UserModel>(evaluator.User);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                var executor = src.RequestHostUsers?.FirstOrDefault(x => x.Action == RequestUserAction.Execute);
                if (executor != null)
                {
                    dest.Executor = context.Mapper.Map<User, UserModel>(executor.User);
                }
            });
        CreateMap<RequestHostCreateModel, RequestHost>();
        CreateMap<RequestHostUpdateModel, RequestHost>();
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
        CreateMap<IpAssignment, IpAssignmentResultModel>();
        CreateMap<IpAddress, IpAddressResultModel>();
        CreateMap<Customer, CustomerResultModel>();
        CreateMap<Component, ComponentResultModel>();
        CreateMap<Area, AreaResultModel>();
        CreateMap<AppointmentUser, AppointmentUserResultModel>();
        CreateMap<Appointment, AppointmentResultModel>();
        #endregion
    }
}
