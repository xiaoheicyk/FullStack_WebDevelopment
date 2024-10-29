using ApplicationCore.Models;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services
{
    public interface IUserService
    {
        Task<User> GetUserDetailsAsync(int userId); 
        Task<IEnumerable<Purchase>> GetUserPurchasesAsync(int userId); 
        Task AddUserFavoriteAsync(int userId, int movieId); 
        Task RemoveUserFavoriteAsync(int userId, int movieId); 
    }
}