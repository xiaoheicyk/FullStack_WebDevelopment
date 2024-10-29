using ApplicationCore.Entities;
using ApplicationCore.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastruture.Data;

namespace Infrastructure.Repositories
{
    public class MovieRepository : BaseRepository<Movie>,IMovieRepository
    {
        private readonly MovieShopDbContext _dbContext;

        public MovieRepository(MovieShopDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Movie>> GetTopRevenueMovies(int number = 20)
        {
            return await _dbContext.Movies
                .OrderByDescending(m => m.Revenue) 
                .Take(number)
                .ToListAsync();
        }

        public async Task<IEnumerable<Movie>> GetHighestGrossingMovies(int number = 10)
        {
            return await _dbContext.Movies
                .OrderByDescending(m => m.Revenue) 
                .Take(number)
                .ToListAsync();
        }

        public async Task<Movie> GetMovieById(int id)
        {
            return await _dbContext.Movies
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<int> AddAsync(Movie movie)
        {
            await _dbContext.Movies.AddAsync(movie);
            return await _dbContext.SaveChangesAsync(); 
        }

        public async Task<int> DeleteAsync(int id)
        {
            var movie = await _dbContext.Movies.FindAsync(id);
            if (movie != null)
            {
                _dbContext.Movies.Remove(movie);
                return await _dbContext.SaveChangesAsync();
            }
            return 0; 
        }
    }
}