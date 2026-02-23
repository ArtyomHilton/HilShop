using BCrypt.Net;
using HilShop.Application.Abstractions;

namespace HilShop.Infrastructure.Services;

class HashingService : IHashingService
{
    private const int DefaultWorkFactor = 11;

    public string Hash(string text) =>
        BCrypt.Net.BCrypt.EnhancedHashPassword(text, HashType.SHA512, DefaultWorkFactor);

    public bool Verify(string text, string hash) =>
        BCrypt.Net.BCrypt.EnhancedVerify(text, hash, HashType.SHA512);
}
