namespace Data.Entities;

public class Customer : BaseEntity
{
    public string CompanyName { get; set; }
    public string TaxNumber { get; set; }
    public Guid UserId { get; set; }
    public virtual User User { get; set; }

    public int CompanyTypeId { get; set; }
    public virtual CompanyType CompanyType { get; set; }

    public virtual ICollection<Request> Requests { get; set; }
}