using System.ComponentModel.DataAnnotations;

namespace SocialConnectApi.DTOs;

public class UsuarioCreateDto
{
    [Required]
    [StringLength(100)]
    public string Nome { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string Senha { get; set; } = string.Empty;

    [Required]
    [StringLength(300)]
    public string Bio { get; set; } = string.Empty;
}