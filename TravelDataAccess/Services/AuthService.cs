using Microsoft.EntityFrameworkCore;
using TravelDataAccess.Data;
using TravelDataAccess.Interfaces;
using TravelDataAccess.Models;

namespace TravelDataAccess.Services
{
    public class AuthService : IAuthService
    {
        private readonly DbTravelCenterContext _context;
        public AuthService(DbTravelCenterContext context)
        {
            _context = context;
        }
        public async Task<Customer?> Login(string code, string password)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(c => c.Code == code && c.Password == password);
            return customer;
        }
    }
}
