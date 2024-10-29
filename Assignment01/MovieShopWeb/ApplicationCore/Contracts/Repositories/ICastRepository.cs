using ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repositories
{
    public interface IPurchaseRepository
    {
        Task<Purchase> GetByIdAsync(int id);
        Task<IEnumerable<Purchase>> GetAllAsync();
        Task<Purchase> AddAsync(Purchase purchase);
        Task<Purchase> UpdateAsync(Purchase purchase);
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<Purchase>> GetPurchasesByUserIdAsync(int userId); 
    }
}