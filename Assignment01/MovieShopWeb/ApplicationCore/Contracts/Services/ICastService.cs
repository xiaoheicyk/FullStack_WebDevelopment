using ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface ICastService
    {
        Task<int> AddCastAsync(Cast cast);

        Task<int> UpdateCastAsync(Cast cast, int id);

        Task<int> DeleteCastAsync(int id);

        Task<IEnumerable<Cast>> GetAllCastsAsync();

        Task<Cast> GetCastByIdAsync(int id);
        Task<Cast> GetCastDetailsAsync(int id);
    }
}