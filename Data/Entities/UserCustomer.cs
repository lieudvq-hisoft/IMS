namespace Data.Entities;
public class UserCustomer : BaseEntity
{
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }
}
