namespace ApplicationCore.Models.ResponseModels;

public class CastDetailsResponseModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Gender { get; set; }
    public string? TmdbUrl { get; set; }
    public string? ProfilePath { get; set; }
    
    public IEnumerable<MovieCardResponseModel>? Movies { get; set; }
    
}