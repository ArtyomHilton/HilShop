using HilShop.Domain.Constants;

namespace HilShop.Domain.Exceptions;

public class PasswordHashNullException : BadRequestException
{
    public override string ErrorCode => ErrorCodes.PasswordHash.PasswordHashNotNullOrEmpty;

    public PasswordHashNullException() : base("Хэш пароля не может быть пустым") { }
}
