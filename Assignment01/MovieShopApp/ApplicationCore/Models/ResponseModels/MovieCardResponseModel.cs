using ApplicationCore.Entities;

namespace ApplicationCore.Models.ResponseModels;

public class MovieCardResponseModel
{
    public int Id { get; set; }
    
    public string? Title { get; set; }
    
    public string? Overview { get; set; }
    
    public string? BackdropPath { get; set; }
    
    public string? ImbdUrl { get; set; }
    
    public string? PosterUrl { get; set; }
    
    public int Runtime { get; set; }
    
    public DateTime? ReleaseDate { get; set; }
    
}