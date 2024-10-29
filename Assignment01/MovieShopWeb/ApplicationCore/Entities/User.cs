using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities;

public class User
{
    [Key]
    public int Id { get; set; }
    public string DateOfBirth { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    public string FirstName { get; set; }
    [Required]
    [MinLength(6)]
    public string HashedPassword { get; set; }
    public int IsLocked { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string ProfilePictureUrl { get; set; }
    public string Salt { get; set; }
}