namespace ApplicationCore.Entities;

public class User
{
    public int Id { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Email { get; set; }
    public string? FirstName { get; set; }
    public string? HashedPassword { get; set; }
    public int IsLocked { get; set; }
    public string? LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? ProfileImageUrl { get; set; }
    public string? Salt { get; set; }
}