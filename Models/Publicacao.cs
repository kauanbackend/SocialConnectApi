using System.ComponentModel.DataAnnotations;
using SocialConnectApi.Models;

namespace SocialConnectApi.Models;

public class Publicacao
{
    public int Id { get; set; }

    [Required]
    [StringLength(500)]
    public string Conteudo { get; set; } = string.Empty;

    public DateTime DataPublicacao { get; set; }

    public int UsuarioId { get; set; }

    public Usuario Usuario { get; set; } = null!;

    public ICollection<Comentario> Comentarios {get; set; }
    = new List<Comentario>();

    public ICollection<Curtida> Curtidas {get; set; }
    = new List<Curtida>();
}