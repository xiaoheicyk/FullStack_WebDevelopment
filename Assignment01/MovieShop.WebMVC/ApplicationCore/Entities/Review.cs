namespace ApplicationCore.Entities;

public class Review
{
    public int MovieId { get; set; }
    public int UserId { get; set; }
    public DateTime CreatedDate { get; set; }
    public int Rating { get; set; }
    public string? ReviewText { get; set; }
    
}