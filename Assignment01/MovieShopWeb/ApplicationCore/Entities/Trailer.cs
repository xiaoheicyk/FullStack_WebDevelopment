using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities;

public class Trailer
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public int MovieId { get; set; }
    public string? Name { get; set; }
    public string? TrailerUrl{ get; set; }
    
}