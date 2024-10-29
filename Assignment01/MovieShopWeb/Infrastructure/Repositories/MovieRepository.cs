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




        public async Task<IEnumerable<Movie>> GetTopRevenueMoviesAsync(int number = 20)
        {
            return await _dbContext.Movies
                .OrderByDescending(m => m.Revenue) 
                .Take(number)
                .ToListAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await _dbContext.Movies.FindAsync(id);
        }
    }
}