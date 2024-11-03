using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class MovieRepository:BaseRepository<Movie>,IMovieRepository
{
    private readonly MovieShopDbContext _context;
    public MovieRepository(MovieShopDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Movie>> GetMoviesByGenreAsync(int genreId)
    {
        return await _context.MovieGenres
            .Where(mg => mg.GenreId == genreId)
            .Select(mg => mg.movie)
            .ToListAsync();
    }
}