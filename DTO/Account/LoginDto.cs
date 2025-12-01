using System.ComponentModel.DataAnnotations;

namespace TonhoLocacao.DTO.Account;

public class LoginDto
{
    [Required]
    [EmailAddress]
    public required string Email { get; set; }
    
    [Required]
    public required string Password { get; set; }
}