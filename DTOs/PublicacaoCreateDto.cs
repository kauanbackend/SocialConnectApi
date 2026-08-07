using System.ComponentModel.DataAnnotations;

namespace SocialConnectApi.DTOs;

public class PublicacaoCreateDto
{
    [Required]
    [StringLength(500)]
    public string Conteudo { get; set; } = string.Empty;

    [Required]
    public int UsuarioId { get; set; }
}