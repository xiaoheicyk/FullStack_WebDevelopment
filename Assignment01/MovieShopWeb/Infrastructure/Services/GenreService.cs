using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastruture.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _repository;

        public GenreService(IGenreRepository repo)
        {
            _repository = repo;
        }

        public async Task<int> AddGenreAsync(Genre genre)
        {
            return await _repository.InsertAsync(genre);
        }

        public async Task<int> UpdateGenreAsync(Genre genre, int id)
        {
            if (id == genre.Id)
            {
                return await _repository.UpdateAsync(genre);
            }
            return 0;
        }

        public async Task<int> DeleteGenreAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Genre>> GetAllGenresAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Genre> GetGenreByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}