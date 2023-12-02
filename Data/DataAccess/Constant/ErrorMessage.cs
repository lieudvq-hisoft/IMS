namespace Data.DataAccess.Constant;

public static class ErrorMessage
{
    public const string EXISTED = "EXISTED";
    public const string NOT_EXISTED = "NOT EXISTED";
    public const string GET_ALL_NULL = "GET ALL NULL";
    public const string INVALID = "INVALID";
    public const string CREATE_FAILED = "FAILED TO CREATE";
    public const string UPDATE_FAILED = "FAILED TO UPDATE";
    public const string DELETE_FAILED = "FAILED TO DELETE";
    public const string FILE_NOT_EXISTED = "FILE NOT EXIST";
    public const string WRONG_PURPOSE = "Wrong purpose";
}

public static class CustomerErrorMessage
{
    public const string EXISTED = "Customer " + ErrorMessage.EXISTED;
    public const string NOT_EXISTED = "Customer " + ErrorMessage.NOT_EXISTED;
    public const string DELETE_FAILED = "Delete customer failed";
    public const string UPDATE_FAILED = "Update customer failed";
}

public static class ServerAllocationErrorMessage
{
    public const string EXISTED = "Server allocation " + ErrorMessage.EXISTED;
    public const string NOT_EXISTED = "Server allocation " + ErrorMessage.NOT_EXISTED;
    public const string HAVE_IP_MASTER_ALREADY = "Server allocation have master ip already";
    public const string FILE_NOT_EXISTED = "Server allocation file " + ErrorMessage.NOT_EXISTED;
    public const string ASSIGN_FILE_TO_NON_ACCEPTED = "Can only assign file to accepted server allocation";
    public const string DOWNLOAD_FILE_FROM_NON_ACCEPTED = "Only accepted server allocation have file";
}

public class AppointmentUserErrorMessage
{
    public const string NOT_EXISTED = "Appointment User " + ErrorMessage.NOT_EXISTED;
}

public class RequestUpgradeUserErrorMessage
{
    public const string NOT_EXISTED = "Request Upgrade User " + ErrorMessage.NOT_EXISTED;
}

public class RequestHostErrorMessage
{
    public const string NOT_EXISTED = "Request Host " + ErrorMessage.NOT_EXISTED;
    public const string NOT_ACCEPTED = "Request Host not accepted";
    public const string NOT_WAITING = "Request Host not waiting";
    public const string NO_MASTER_IP = "Server allocation must have master ip";
    public const string NO_IP_CHOICE = "Request host must have ip to be evaluate";
    public const string NOT_PROCESSABLE = "Request host with request must have document to be completable";
    public const string NOT_PROCESSED = "Request host not process";
}

public static class RequestExpandUserErrorMessage
{
    public const string NOT_EXISTED = "Request Expand User " + ErrorMessage.NOT_EXISTED;
}

public static class IpAssignmentErrorMessage
{
    public const string NOT_EXISTED = "Ip Assignment " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Ip Assignment " + ErrorMessage.EXISTED;

}

public static class AreaErrorMessage
{
    public const string NOT_EXISTED = "Area " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Area " + ErrorMessage.EXISTED;
}

public static class IpAddressErrorMessage
{
    public const string NOT_EXISTED = "Ip Address " + ErrorMessage.NOT_EXISTED;
    public const string NO_AVAILABLE = "No available ip address";
    public const string UNASSIGNABLE = "Ip address cannot be ipassigned";
    public const string UNAVAILABLE = "Ip address not available for assignment";
    public const string EXISTED = "Ip Address " + ErrorMessage.EXISTED;
}

public static class IpSubnetErrorMessage
{
    public const string NOT_EXISTED = "Ip Subnet " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Ip Subnet " + ErrorMessage.EXISTED;
    public const string IP_RANGE_FOURTH_OCTET = "Forth octet of a ip range must be 0";
    public const string INVALID_RANGE = "Child subnet have invalid range";
    public const string OVERLAPPED = "IP subnets cannot be overlapped";
}


public static class RequestExpandErrorMessage
{
    public const string NOT_EXISTED = "Request expand " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Request expand " + ErrorMessage.EXISTED;
    public const string NOT_ACCEPTED = "Request expand is not accepted";
    public const string NOT_WAITING = "Request expand is not waiting";
    public const string NOT_SUCCESS = "Request expand is not success";
    public const string NOT_COMPLETABLE = "Request expand is not completable";
    public const string REMOVAL_NOT_ACCEPTED = "Non success removal request";
}

public static class RequestExpandAppointmentErrorMessage
{
    public const string NOT_EXISTED = "Request Expand Appointment " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Request Expand Appointment " + ErrorMessage.EXISTED;
    public const string APPOINTMENT_NOT_ACCEPTED = "Appointment is not accepted";
    public const string INVALID_SERVER_ALLOCATION = "Appointment and Request expand have different server allocation";
}

public static class RequestExpandLocationErrorMessage
{
    public const string NOT_EXISTED = "Request Expand Location " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Request Expand Location " + ErrorMessage.EXISTED;
    public const string INVALID_LOCATION = "Location is not valid";
}

public static class RackErrorMessage
{
    public const string NOT_EXISTED = "Rack " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Rack " + ErrorMessage.EXISTED;
    public const string POSITION_INVALID = "Rack position is invalid";
}

public static class RequestErrorMessage
{
    public const string NOT_EXISTED = "Request " + ErrorMessage.NOT_EXISTED;
}

public static class CompanyTypeErrorMessage
{
    public const string NOT_EXISTED = "Company type " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Company type " + ErrorMessage.NOT_EXISTED;
}

public static  class UserErrorMessage
{
    public const string NOT_EXISTED = "User " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "User " + ErrorMessage.EXISTED;
    public const string REGISTER_FAILED = "Register user failed";
    public const string UPDATE_FAILED = "Update user failed";
    public const string DELETE_FAILED = "Delete user failed";
    public const string ERROR_PASSWORD = "Error password";
    public const string LOGIN_ERROR = "Username or Password not correct!";
    public const string CREATE_CUSTOMER = "Cannot create a customer";
}

public static class IpErrorMessage
{
    public const string ASSIGN_IP_TO_NON_PENDING_REQUEST = "Can only assign Ip to pending request";
    public const string ASSIGN_IP_TO_REQUEST_WITHOUT_SERVER = "Request dont have a server";
    public const string NOT_EXISTED = "Ip " + ErrorMessage.EXISTED;
    public const string NOT_AVAILABLE = "Ip Not available";
}

public static class LocationAssignmentErrorMessage
{
    public const string EXISTED = "Location assignment " + ErrorMessage.EXISTED;
    public const string NOT_EXISTED = "Location assignment " + ErrorMessage.NOT_EXISTED;
    public const string NO_AVAILABLE_FOUND = "No available location found";
    public const string HAVE_LOCATION_ALREADY = "Device already have a location";
    public const string CHOICE_NOT_AVAILABLE = "Location choice is not available";
    public const string INVALID_RACK = "Rack is not valid";
    public const string INVALID_SERVICE = "Service is not valid";
    public const string INVALID_SERVER = "Server is not valid";
    public const string INVALID_LOCATION = "Location is not valid";
}

public static class ServerErrorMessgae
{
    public const string NOT_EXISTED = "Server " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Server " + ErrorMessage.EXISTED;
}

public static class AppointmentErrorMessage
{
    public const string NOT_EXISTED = "Appointment " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Appointment " + ErrorMessage.EXISTED;
    public const string NOT_ACCEPTED = "Appointment not accepted";
    public const string NOT_SUCCESS = "Appointment not success";
    public const string NOT_WAITING = "Appointment not waiting";
    public const string NOT_COMPLETABLE = "Appointment with request must have document to be completable";
}

public static class LocationErrorMessgae
{
    public const string NOT_EXISTED = "Location " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Location " + ErrorMessage.EXISTED;
    public const string NO_AVAILABLE_FOUND = "No location available found";
}

public static class ComponentErrorMessgae
{
    public const string NOT_EXISTED = "Appointment " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Appointment " + ErrorMessage.EXISTED;
}


public static class CompanyTypeErrorMessgae
{
    public const string NOT_EXISTED = "Company Type " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Company Type " + ErrorMessage.EXISTED;
}

public static class RequestUpgradeAppointmentErrorMessgae
{
    public const string NOT_EXISTED = "Request Upgrade Appointment " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Request Upgrade Appointment " + ErrorMessage.EXISTED;
}

public static class ServiceErrorMessage
{
    public const string NOT_EXISTED = "Service " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Service " + ErrorMessage.EXISTED;
}

public static class ComponentErrorMessage
{
    public const string NOT_EXISTED = "Component " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Component " + ErrorMessage.EXISTED;
}

public static class ServerHardwareConfigErrorMessage
{
    public const string EXISTED = "Server hardware config " + ErrorMessage.EXISTED;
    public const string NOT_EXISTED = "Server hardware config " + ErrorMessage.NOT_EXISTED;
    public const string CONFIG_FOR_COMPONENT_EXISTED = "Config for component " + ErrorMessage.EXISTED;
    public const string DELETE_CURRENT = "Cannot delete current server hardware config";
}

public static class RequestUpgradeErrorMessage
{
    public const string NOT_EXISTED = "Request upgrade " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Request upgrade " + ErrorMessage.EXISTED;
    public const string NOT_ACCEPTED = "Request upgrade not accepted";
    public const string NOT_WAITING = "Request upgrade not waiting";
    public const string NOT_COMPLETABLE = "Request upgrade is not completable";
    public const string APPOINTMENT_NOT_COMPLETE = "Request upgrade dont have complete appointment";
    public const string INITIATE_NON_POSITIVE_CAPACITY = "Initial request upgrade must have positive capacity";
    public const string CANNOT_DOWNGRADE = "Request upgrade cannot be downgrade";
}




