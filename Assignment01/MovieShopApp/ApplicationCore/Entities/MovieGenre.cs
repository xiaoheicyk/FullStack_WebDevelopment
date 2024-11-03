namespace ApplicationCore.Entities;

public class MovieGenre
{
    public int MovieId { get; set; }
    public Movie movie { get; set; }
    public int GenreId { get; set; }
    public Genre genre { get; set; }
    
}