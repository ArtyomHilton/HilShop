namespace HilShop.Application.Abstractions;

public interface IHashingService
{
    string Hash(string text);
    bool Verify(string text, string hash);
}
