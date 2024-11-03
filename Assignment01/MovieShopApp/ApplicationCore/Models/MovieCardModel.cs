using ApplicationCore.Entities;

namespace ApplicationCore.Models;

public class MovieCardModel
{
    public int Id { get; set; }
    
    public string? Title { get; set; }
    
    public string? Overview { get; set; }
    
    public string? BackdropPath { get; set; }
    
    public string? ImbdUrl { get; set; }
    
    public string? PosterUrl { get; set; }
    
    public int Runtime { get; set; }
    
    
}