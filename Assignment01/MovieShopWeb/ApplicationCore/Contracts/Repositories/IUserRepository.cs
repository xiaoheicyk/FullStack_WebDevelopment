using ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int id);         
        Task<IEnumerable<User>> GetAllAsync();   
        Task<User> AddAsync(User user);          
        Task<User> UpdateAsync(User user);        
        Task<bool> DeleteAsync(int id);          
        Task<User> GetUserByEmailAsync(string email);
        
    }
}