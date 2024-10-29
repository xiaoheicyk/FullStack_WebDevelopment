using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Models;

public class RegisterModel
{
    [Required]
    public string Email { get; set; }
    [Required]
    [MinLength(6)]
    public string Password { get; set; }
    
    [Required]
    public string ConfirmPassword { get; set; }
    
}