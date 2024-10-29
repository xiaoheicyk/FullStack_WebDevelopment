using ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repositories
{
    public interface IReportRepository
    {
        Task<Report> GetByIdAsync(int id);
        Task<IEnumerable<Report>> GetAllAsync();
        Task<Report> AddAsync(Report report);
        Task<Report> UpdateAsync(Report report);
        Task<bool> DeleteAsync(int id);
    }
}