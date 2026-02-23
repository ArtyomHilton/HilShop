using HilShop.Domain.Constants;

using Microsoft.AspNetCore.Http;

namespace HilShop.Domain.Exceptions;

public class BadRequestException : HilShopBaseException
{
    public override int StatusCode => StatusCodes.Status400BadRequest;
    public override string ErrorCode => ErrorCodes.Common.BadRequestError;
    public BadRequestException(string message = "Ошибка валидации") : base(message) { }
}
