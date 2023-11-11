﻿namespace Data.DataAccess.Constant;

public class ErrorMessage
{
    public const string EXISTED = "EXISTED";
    public const string NOT_EXISTED = "NOT EXISTED";
    public const string GET_ALL_NULL = "GET ALL NULL";
    public const string INVALID = "INVALID";
    public const string CREATE_FAILED = "FAILED TO CREATE";
    public const string UPDATE_FAILED = "FAILED TO UPDATE";
    public const string DELETE_FAILED = "FAILED TO DELETE";
}

public class CustomerErrorMessage
{
    public const string NOT_EXISTED = "Customer " + ErrorMessage.NOT_EXISTED;
    public const string DELETE_FAILED = "Delete customer failed";
    public const string UPDATE_FAILED = "Update customer failed";
}

public class RequestErrorMessage
{
    public const string NOT_EXISTED = "Request " + ErrorMessage.NOT_EXISTED;
    public const string FILE_NOT_EXISTED = "Request file " + ErrorMessage.NOT_EXISTED;
    public const string UPDATE_NON_PENDING = "Can only update pending request";
    public const string ASSIGN_FILE_TO_NON_ACCEPTED = "Can only assign file to accepted request";
    public const string DOWNLOAD_FILE_FROM_NON_ACCEPTED = "Only accepted request have file";
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
    public const string NOT_EXISTED = "locationService " + ErrorMessage.NOT_EXISTED;
    public const string NO_AVAILABLE_FOUND = "No available location found";
    public const string HAVE_LOCATION_ALREADY = "Device already have a location";
    public const string CHOICE_NOT_AVAILABLE = "Location choice is not available";
    public const string INVALID_RACK = "Rack is not valid";
    public const string INVALID_SERVICE = "Service is not valid";
}

public class RackErrorMessage
{
    public const string NOT_EXISTED = "Rack " + ErrorMessage.NOT_EXISTED;
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

public class ServiceErrorMessgae
{
    public const string NOT_EXISTED = "Service " + ErrorMessage.NOT_EXISTED;
    public const string EXISTED = "Service " + ErrorMessage.EXISTED;
}

public class IpAssignmentErrorMessage
{
    public const string NOT_EXISTED = "IpAssignment " + ErrorMessage.NOT_EXISTED;
    public const string DELETE_FAILED = "Delete customer failed";
    public const string UPDATE_FAILED = "Update customer failed";
}




