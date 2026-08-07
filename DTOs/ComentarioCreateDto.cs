using System.ComponentModel.DataAnnotations;

namespace SocialConnectApi.DTOs;

public class ComentarioCreateDto
{
    [Required]
    [StringLength(300)]
    public string Conteudo { get; set; } = string.Empty;

    public int UsuarioId { get; set; }

    public int PublicacaoId { get; set; }
}
