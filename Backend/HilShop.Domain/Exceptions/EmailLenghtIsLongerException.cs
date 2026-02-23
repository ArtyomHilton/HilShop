using HilShop.Domain.Constants;

namespace HilShop.Domain.Exceptions;

public class EmailLenghtIsLongerException : BadRequestException
{
    public override string ErrorCode => ErrorCodes.Email.EmailLengthIsLonger;

    public EmailLenghtIsLongerException() : base($"Длина электронной почты не должна превышать: {DomainRules.Email.MaxLenght} символов") { }
}
