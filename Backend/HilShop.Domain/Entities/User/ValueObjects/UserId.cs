namespace HilShop.Domain.Entities.User.ValueObjects;

public class UserId
{
    public Guid Value { get; init; }

    public UserId()
    {
        Value = Guid.CreateVersion7();
    }

    public UserId(Guid value)
    {
        Value = value;
    }
}
