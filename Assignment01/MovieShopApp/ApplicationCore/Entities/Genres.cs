using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities;

public class Genres
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
}