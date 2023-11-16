namespace Data.DataAccess.Constant;

public class ErrorMessage
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

public class CustomerErrorMessage
{
    public const string NOT_EXISTED = "Customer " + ErrorMessage.NOT_EXISTED;
    public const string DELETE_FAILED = "Delete customer failed";
    public const string UPDATE_FAILED = "Update customer failed";
}

public class ServerAllocationErrorMessage
{
    public const string NOT_EXISTED = "Server allocation " + ErrorMessage.NOT_EXISTED;
    public const string FILE_NOT_EXISTED = "Server allocation file " + ErrorMessage.NOT_EXISTED;
    public const string ASSIGN_FILE_TO_NON_ACCEPTED = "Can only assign file to accepted server allocation";
    public const string DOWNLOAD_FILE_FROM_NON_ACCEPTED = "Only accepted server allocation have file";
}

public class AreaErrorMessage
{
    public const string NOT_EXISTED = "Area " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Area " + ErrorMessage.EXISTED;
}

public class RackErrorMessage
{
    public const string NOT_EXISTED = "Rack " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Rack " + ErrorMessage.EXISTED;
    public const string POSITION_INVALID = "Rack position is invalid";
}

public class RequestErrorMessage
{
    public const string NOT_EXISTED = "Request " + ErrorMessage.NOT_EXISTED;
}

public class CompanyTypeErrorMessage
{
    public const string NOT_EXISTED = "Company type " + ErrorMessage.NOT_EXISTED;
}

public class UserErrorMessage
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

public class IpErrorMessage
{
    public const string ASSIGN_IP_TO_NON_PENDING_REQUEST = "Can only assign Ip to pending request";
    public const string ASSIGN_IP_TO_REQUEST_WITHOUT_SERVER = "Request dont have a server";
    public const string NOT_EXISTED = "Ip " + ErrorMessage.EXISTED;
    public const string NOT_AVAILABLE = "Ip Not available";
}

public class LocationAssignmentErrorMessage
{
    public const string EXISTED = "locationService " + ErrorMessage.EXISTED;
    public const string NOT_EXISTED = "locationService " + ErrorMessage.NOT_EXISTED;
    public const string NO_AVAILABLE_FOUND = "No available location found";
    public const string HAVE_LOCATION_ALREADY = "Device already have a location";
    public const string CHOICE_NOT_AVAILABLE = "Location choice is not available";
    public const string INVALID_RACK = "Rack is not valid";
    public const string INVALID_SERVICE = "Service is not valid";
    public const string INVALID_SERVER = "Server is not valid";
    public const string INVALID_LOCATION = "Location is not valid";
}

public class ServerErrorMessgae
{
    public const string NOT_EXISTED = "Server " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Server " + ErrorMessage.EXISTED;
}

public class AppointmentErrorMessgae
{
    public const string NOT_EXISTED = "Appointment " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Appointment " + ErrorMessage.EXISTED;
}

public class RequestUpgradeAppointmentErrorMessgae
{
    public const string NOT_EXISTED = "Request Upgrade Appointment " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Request Upgrade Appointment " + ErrorMessage.EXISTED;
}

public class ServiceErrorMessage
{
    public const string NOT_EXISTED = "Service " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Service " + ErrorMessage.EXISTED;
}

public class ComponentErrorMessage
{
    public const string NOT_EXISTED = "Component " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Component " + ErrorMessage.EXISTED;
}

public class ServerHardwareConfigErrorMessage
{
    public const string NOT_EXISTED = "Server hardware config " + ErrorMessage.NOT_EXISTED;
    public const string CONFIG_FOR_COMPONENT_EXISTED = "Config for component " + ErrorMessage.EXISTED;
    public const string DELETE_CURRENT = "Cannot delete current server hardware config";
}

public class RequestUpgradeErrorMessage
{
    public const string NOT_EXISTED = "Request upgrade " + ErrorMessage.NOT_EXISTED;
    public const string NOT_ACCEPTED = "Request upgrade not accepted";
    public const string NOT_WAITING = "Request upgrade not waiting";
    public const string NOT_COMPLETABLE = "Request upgrade is not completable";
}





