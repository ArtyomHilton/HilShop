namespace HilShop.Domain.Constants;

public static class ErrorCodes
{
    public static class Email
    {
        public const string EmailNotNullOrEmpty = "EMAIL_MUST_BE_NOT_NULL_OR_EMPTY_ERROR";
        public const string EmailLengthIsLonger = "EMAIL_LENGTH_IS_LONGER_ERROR";
    }

    public static class PasswordHash
    {
        public const string PasswordHashNotNullOrEmpty = "PASSWORD_HASH_MUST_BE_NOT_NULL_OR_EMPTY_ERROR";
    }

    public static class Common
    {
        public const string InternalServerError = "INTERNAL_SERVER_ERROR";
        public const string BadRequestError = "BAD_REQUEST_ERROR";
    }
}
