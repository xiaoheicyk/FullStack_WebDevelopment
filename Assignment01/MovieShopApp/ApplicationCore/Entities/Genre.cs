using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities;

public class Genre
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public ICollection<MovieGenre> MovieGenres { get; set; }
}