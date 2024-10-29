using ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int id);         
        
        
        Task<User> GetUserByEmailAsync(string email);
        
        

        
    }
}