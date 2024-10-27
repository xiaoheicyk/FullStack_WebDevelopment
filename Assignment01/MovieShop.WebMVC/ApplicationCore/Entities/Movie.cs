using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities;

public class Movie
{
    public int Id { get; set; }
    public string? BackdropUrl { get; set; }
    public decimal Budget { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? ImdbUrl { get; set; }
    public string? OriginalLanguage { get; set; }
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }
    public decimal Revenue { get; set; }
    public int Runtime { get; set; }
    [Column()]
    public string? Tagline { get; set; }
    
    
}