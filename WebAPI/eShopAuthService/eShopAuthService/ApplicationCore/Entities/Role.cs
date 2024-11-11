using System.ComponentModel.DataAnnotations;

namespace eShopAuthService.ApplicationCore.Entities;

public class Role
{
    [Required]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}