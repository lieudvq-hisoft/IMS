using AutoMapper;
using Data.Entities;
using Data.Enums;
using Data.Models;
using System.Text.Json;

namespace Services.Mapping;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        #region Customer
        CreateMap<Customer, CustomerModel>()
            .AfterMap((src, dest) =>
            {
                if (src.Contact != null)
                {
                    dest.Contacts = JsonSerializer.Deserialize<List<ContactModel>>(src.Contact);
                }
            });
        CreateMap<CustomerCreateModel, Customer>()
            .AfterMap((src, dest) =>
                dest.Contact = JsonSerializer.Serialize(src.Contacts));
        CreateMap<CustomerUpdateModel, Customer>()
            .AfterMap((src, dest) =>
                dest.Contact = JsonSerializer.Serialize(src.Contacts));
        CreateMap<User, UserModel>();
        #endregion

        #region ServerHardware
        CreateMap<Component, ComponentModel>();
        CreateMap<ComponentCreateModel, Component>();
        CreateMap<ComponentUpdateModel, Component>();

        CreateMap<ServerHardwareConfig, ServerHardwareConfigModel>()
            .AfterMap((src, dest, context) =>
                dest.Component = context.Mapper.Map<Component, ComponentModel>(src.Component))
            .AfterMap((src, dest) =>
                dest.Descriptions = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(src.Description));
        CreateMap<ServerHardwareConfigCreateModel, ServerHardwareConfig>()
            .AfterMap((src, dest) =>
                dest.Description = JsonSerializer.Serialize(src.Descriptions));
        CreateMap<ServerHardwareConfigUpdateModel, ServerHardwareConfig>()
            .AfterMap((src, dest) =>
                dest.Description = JsonSerializer.Serialize(src.Descriptions));

        CreateMap<RequestUpgrade, RequestUpgradeModel>()
            .AfterMap((src, dest) =>
            {
                if (src.RequestUpgradeAppointments?.Any() == true)
                {
                    dest.AppointmentId = src.RequestUpgradeAppointments.Select(x => x.Appointment).FirstOrDefault(x => x.Status == RequestStatus.Accepted || x.Status == RequestStatus.Waiting)?.Id;
                }
            })
            .AfterMap((src, dest) =>
                dest.Descriptions = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(src.Description))
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
        CreateMap<RequestUpgradeCreateModel, RequestUpgrade>()
            .AfterMap((src, dest) =>
                dest.Description = JsonSerializer.Serialize(src.Descriptions));
        CreateMap<RequestUpgradeUpdateModel, RequestUpgrade>()
            .AfterMap((src, dest) =>
                dest.Description = JsonSerializer.Serialize(src.Descriptions));
        #endregion

        #region ServerAllocation
        CreateMap<ServerAllocation, ServerAllocationModel>()
            .ForMember(dest => dest.IpCount, opt => opt.MapFrom(src => src.IpAssignments.Count))
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
            })
            .AfterMap((src, dest, context) =>
            {
                if (src.LocationAssignments?.Any() == true)
                {
                    dest.Location = src.GetServerLocation();
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
        #endregion

        #region User
        CreateMap<User, UserModel>()
            .ForMember(dest => dest.Positions, opt => opt.MapFrom(src => src.UserRoles.Select(x => x.Role.Name)));
        #endregion

        #region Appointment
        CreateMap<RequestAppointmentCreateModel, RequestUpgradeAppointment>();
        CreateMap<RequestUpgradeAppointment, RequestUpgradeAppointmentModel>();

        CreateMap<Appointment, AppointmentModel>()
             .AfterMap((src, dest) =>
             {
                 if (src.RequestExpandAppointments?.Any(x => !x.ForRemoval) == true)
                 {
                     dest.Purpose = "Expand";
                 }
                 if (src.RequestExpandAppointments?.Any(x => x.ForRemoval) == true)
                 {
                     dest.Purpose = "Removal";
                 }
                 if (src.RequestUpgradeAppointment?.Any() == true)
                 {
                     dest.Purpose = "Upgrade";
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
            .AfterMap((src, dest) =>
            {
                if (src.RequestExpandAppointments?.Any() == true)
                {
                    dest.AppointmentId = src.RequestExpandAppointments.Select(x => x.Appointment).FirstOrDefault(x => x.Status == RequestStatus.Accepted || x.Status == RequestStatus.Waiting)?.Id;
                }
            })
            .AfterMap((src, dest, context) =>
            {
                var completeAppointment = src.RequestExpandAppointments?.Where(x => x.ForRemoval == src.ForRemoval).Select(x => x.Appointment).FirstOrDefault(x => x.Status == RequestStatus.Success);
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
            .AfterMap((src, dest) =>
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
        CreateMap<RequestExpandAppointment, RequestExpandAppointmentModel>();
        #endregion

        #region Incident
        CreateMap<Incident, IncidentModel>()
            .AfterMap((src, dest, context) =>
            {
                dest.Evaluator = context.Mapper.Map<User, UserModel>(src.IncidentUsers.FirstOrDefault(x => x.Action == RequestUserAction.Evaluate).User);
            })
            .AfterMap((src, dest, context) =>
            {
                var executor = src.IncidentUsers.FirstOrDefault(x => x.Action == RequestUserAction.Evaluate);
                if (executor != null)
                {
                    dest.Executor = context.Mapper.Map<User, UserModel>(executor.User);
                }
            })
            .AfterMap((src, dest, context) =>
            {
                dest.ServerAllocation = context.Mapper.Map<ServerAllocation, ServerAllocationResultModel>(src.ServerAllocation);
            })
            .AfterMap((src, dest, context) =>
            {
                var appointment = src.IncidentAppointments.Select(x => x.Appointment).FirstOrDefault(x => x.Status == RequestStatus.Accepted || x.Status == RequestStatus.Success);
                if (appointment != null)
                {
                    dest.Appointment = context.Mapper.Map<Appointment, AppointmentResultModel>(appointment);
                }
            });
        CreateMap<IncidentCreateModel, Incident>();
        #endregion

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
            })
            .AfterMap((src, dest, context) =>
            {
                if (src.IpAssignments.FirstOrDefault() != null)
                {
                    dest.AssignmentType = src.IpAssignments.FirstOrDefault()?.Type.ToString();
                }
            })
            .AfterMap((src, dest, context) =>
            {
                var ipAssignment = src.IpAssignments.FirstOrDefault();
                if (ipAssignment != null)
                {
                    dest.Capacity = ipAssignment.Capacity;
                }
            });
        CreateMap<IpSubnet, IpSubnetModel>()
            .ForMember(dest => dest.SubnetIds, opt => opt.MapFrom(src => src.SubNets.Select(x => x.Id)));

        CreateMap<IpAssignment, IpAssignmentModel>();
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
                if (src.RequestHostIps != null)
                {
                    dest.IpAddresses = src.RequestHostIps.Select(x => new RequestHostIpModel
                    {
                        IpAddress = context.Mapper.Map<IpAddress, IpAddressResultModel>(x.IpAddress),
                        Capacity = x.Capacity
                    }).ToList();
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
        CreateMap<ServerHardwareConfig, ServerHardwareConfigResultModel>()
            .AfterMap((src, dest, context) =>
                dest.Descriptions = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(src.Description));
        CreateMap<ServerAllocation, ServerAllocationResultModel>();
        CreateMap<RequestUpgrade, RequestUpgradeResultModel>()
            .AfterMap((src, dest, context) =>
                dest.Descriptions = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(src.Description));
        CreateMap<RequestExpand, RequestExpandResultModel>();
        CreateMap<RequestHost, RequestHostResultModel>();
        CreateMap<Rack, RackResultModel>();
        CreateMap<Location, LocationResultModel>();
        CreateMap<IpSubnet, IpSubnetResultModel>();
        CreateMap<IpAssignment, IpAssignmentModel>();
        CreateMap<IpAddress, IpAddressResultModel>();
        CreateMap<Customer, CustomerResultModel>()
            .AfterMap((src, dest) =>
            {
                if (src.Contact != null)
                {
                    dest.Contacts = JsonSerializer.Deserialize<List<ContactModel>>(src.Contact);
                }
            });
        CreateMap<Incident, IncidentResultModel>();
        CreateMap<Component, ComponentResultModel>();
        CreateMap<Area, AreaResultModel>();
        CreateMap<Appointment, AppointmentResultModel>();
        #endregion

        #region Notification
        CreateMap<Notification, NotificationModel>().ReverseMap();
        CreateMap<NotificationCreateModel, Notification>().ReverseMap();
        #endregion
    }
}
