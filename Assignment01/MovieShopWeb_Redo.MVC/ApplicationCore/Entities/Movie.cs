using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities;

public class Movie
{
    public int Id { get; set; }
    public string? BackdropUrl { get; set; }
    public long? Budget { get; set; }
    public string? ImdbUrl { get; set; }
    public string? OriginalLanguage { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public long? Revenue { get; set; }
    public int? Runtime { get; set; }
    public string? Tagline { get; set; }
    public string? PosterUrl { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Title { get; set; }
    public string? TmdbUrl { get; set; }
    public string OverView { get; set; }
    
    
    
}