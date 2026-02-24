using TravelDataAccess.Models;

namespace TravelDataAccess.Interfaces
{
    public interface IAuthService
    {
        Task<Customer?> Login(string code, string password);
    }
}
