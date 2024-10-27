namespace ApplicationCore.Entities;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Overview { get; set; }
    public string? PostUrl{get; set;}
    public DateTime ReleaseDate { get; set; }
}