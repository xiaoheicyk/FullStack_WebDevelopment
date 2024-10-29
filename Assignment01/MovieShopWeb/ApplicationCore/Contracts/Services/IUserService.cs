using ApplicationCore.Models;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services
{
    public interface IUserService
    {
        Task<User> RegisterAsync(LoginModel model); 
        Task<User> LoginAsync(LoginModel model);
    }
}