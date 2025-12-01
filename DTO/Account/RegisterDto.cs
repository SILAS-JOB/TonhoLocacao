using System.ComponentModel.DataAnnotations;

namespace TonhoLocacao.DTO.Account;

public class RegisterDto
{
    [Required(ErrorMessage = "Nome é obrigatório")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "Email é obrigatório ")]
    [EmailAddress(ErrorMessage = "Email Inválido")]
    public required string Email { get; set; }

    [Required(ErrorMessage = "Senha é obrigatória")]
    [MinLength(8, ErrorMessage = "A senha deve ter no mínimo 8 caracteres")]
    public required string Password { get; set; }

    [Compare("Password", ErrorMessage = "As senhas devem ser iguais")]
    public required string ConfirmedPassword { get; set; }

}