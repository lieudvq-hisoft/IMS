﻿namespace Data.Entities;

public class Customer : BaseEntity
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string CompanyName { get; set; }
    public string Address { get; set; }
    public string TaxNumber { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string CustomerName { get; set; }

    public int CompanyTypeId { get; set; }
    public virtual CompanyType CompanyType { get; set; }

    public virtual ICollection<Request> Requests { get; set; }
}