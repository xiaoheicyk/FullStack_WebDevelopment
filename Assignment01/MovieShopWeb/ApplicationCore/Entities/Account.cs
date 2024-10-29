namespace ApplicationCore.Entities;

public class Account
{
    public int Id { get; set; } 
    public string Username { get; set; } 
    public string Email { get; set; } 
    public string PasswordHash { get; set; } 
    public DateTime CreatedAt { get; set; } 
    public DateTime UpdatedAt { get; set; } 
    
    public string? FullName { get; set; } 
    public bool? IsActive { get; set; } 
    public string? Role { get; set; } 
}