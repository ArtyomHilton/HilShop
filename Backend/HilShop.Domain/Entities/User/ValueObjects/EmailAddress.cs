using HilShop.Domain.Constants;
using HilShop.Domain.Exceptions;

namespace HilShop.Domain.Entities.User.ValueObjects;

public class EmailAddress
{
    public string Value { get; private set; }

    public EmailAddress(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new EmailNullException();

        if (value.Length > DomainRules.Email.MaxLenght)
            throw new EmailLenghtIsLongerException();

        Value = value;
    }
}
