using HilShop.Domain.Constants;

namespace HilShop.Domain.Exceptions;

public class EmailNullException : BadRequestException
{
    public override string ErrorCode => ErrorCodes.Email.EmailNotNullOrEmpty;
    public EmailNullException() : base("Email не может быть пустым") { }
}
