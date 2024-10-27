namespace ApplicationCore.Entities;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }
    public string? Genre { get; set; }
    
}