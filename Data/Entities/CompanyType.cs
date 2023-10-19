namespace Data.Entities;
public class CompanyType : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }

    public virtual List<Customer> Customer { get; set; }
}
