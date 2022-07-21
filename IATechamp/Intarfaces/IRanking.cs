using IATechamp.Models;

namespace IATechamp.Intarfaces
{
    public interface IRanking
    {
        bool Equals(object? obj);
        int GetHashCode();
        string? ToString();
    }
}
