using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities;

public class Cast
{
    [Key]
    public int Id { get; set; }
    
    public string? Name { get; set; }
    public string? Gender { get; set; }
    public string? TmdbUrl { get; set; }
    public string? ProfilePath { get; set; }
}