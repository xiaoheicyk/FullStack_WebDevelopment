using ApplicationCore.Models;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services
{
    public interface IUserService
    {
        Task<User> GetUserByIdAsync(int userId); 
        Task<List<Purchase>> GetUserPurchasesAsync(int userId); 
        
    }
}