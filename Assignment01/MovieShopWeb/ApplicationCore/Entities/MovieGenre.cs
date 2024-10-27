using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities;

public class MovieGenre
{
    
    public int GenreId { get; set; }
    
    public int MovieId { get; set; }
    
}