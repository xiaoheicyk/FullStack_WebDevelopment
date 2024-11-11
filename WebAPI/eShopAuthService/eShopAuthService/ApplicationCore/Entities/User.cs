using System.ComponentModel.DataAnnotations;

namespace eShopAuthService.ApplicationCore.Entities;

public class User
{
    [Required]
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Username { get; set; }
    public string? EmailId { get; set; }
    [Required]
    public string? Password { get; set; }
    public string? Salt { get; set; }
}