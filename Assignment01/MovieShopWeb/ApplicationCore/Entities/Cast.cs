using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities;

public class Cast
{
    [Key]
    public int Id { get; set; }
    public string? Gender { get; set; }
    [Required]
    [MaxLength(50)]
    public string? Name { get; set; }
    public string? ProfilePath { get; set; }
    public string? TmdbUrl { get; set; }
    
}