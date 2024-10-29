using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities;

public class MovieCast
{
    [Key]
    public int CastId { get; set; }
    public string? CastName { get; set; }
    [Required]
    public int MovieId { get; set; }
}