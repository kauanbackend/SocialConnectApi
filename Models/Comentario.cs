using System.ComponentModel.DataAnnotations;

namespace SocialConnectApi.Models;

public class Comentario
{
    public int Id { get; set; }

    [Required]
    [StringLength(300)]
    public string Conteudo { get; set; } = string.Empty;

    public DateTime DataComentario { get; set; }

    public int UsuarioId { get; set; }

    public Usuario Usuario { get; set; } = null!;

    public int PublicacaoId { get; set; }

    public Publicacao Publicacao { get; set; } = null!;
}

