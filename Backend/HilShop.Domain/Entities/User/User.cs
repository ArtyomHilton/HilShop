using HilShop.Domain.Entities.User.ValueObjects;

namespace HilShop.Domain.Entities.User;

public class User
{
    public UserId Id { get; private set; }
    public EmailAddress Email { get; private set; }
    public PasswordHash PasswordHash { get; private set; }

    private User(string email, string passwordHash)
    {
        Id = new UserId();
        Email = new EmailAddress(email);
        PasswordHash = new PasswordHash(passwordHash);
    }

    public static User Create(string email, string passwordHash) => 
        new User(email, passwordHash);
}