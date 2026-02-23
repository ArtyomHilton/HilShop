using System.Data;

using HilShop.Domain.Constants;

using Microsoft.AspNetCore.Http;

namespace HilShop.Domain.Exceptions;

public class HilShopBaseException : Exception
{
    public virtual string ErrorCode => ErrorCodes.Common.InternalServerError;
    public virtual int StatusCode => StatusCodes.Status500InternalServerError;
    public HilShopBaseException(string message) : base(message) { }
}
