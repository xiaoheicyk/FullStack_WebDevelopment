using ApplicationCore.Entities;

namespace ApplicationCore.Models;

public class GenreViewModel
{
    public Genre Genre { get; set; }
    public IEnumerable<Movie> Movies { get; set; }
}