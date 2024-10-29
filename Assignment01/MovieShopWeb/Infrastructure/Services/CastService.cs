using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastruture.Services
{
    public class CastService : ICastService
    {
        private readonly ICastRepository _repository;

        public CastService(ICastRepository repo)
        {
            _repository = repo;
        }

        public async Task<int> AddCastAsync(Cast cast)
        {
            return await _repository.InsertAsync(cast);
        }

        public async Task<int> UpdateCastAsync(Cast cast, int id)
        {
            if (cast.Id == id)
            {
                return await _repository.UpdateAsync(cast);
            }

            return 0;
        }

        public async Task<int> DeleteCastAsync(int id)
        {
            return await _repository.DeleteAsync(id);  
        }

        public async Task<IEnumerable<Cast>> GetAllCastsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Cast> GetCastByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}