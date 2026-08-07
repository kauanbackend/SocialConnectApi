using System.ComponentModel.DataAnnotations;
using System.Data;
using SocialConnectApi.Models;

namespace SocialConnectApi.Models;

public class Usuario
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Nome { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email {get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string Senha { get; set; } = string.Empty;

    [StringLength(300)]
    public string Bio { get; set; } = string.Empty;

    public DateTime DataCadastro { get; set; } = DateTime.Now;

    public ICollection<Publicacao> Publicacoes { get; set; }
    = new List<Publicacao>();

    public ICollection<Comentario> Comentarios {get; set; }
    = new List<Comentario>();

    public ICollection<Curtida> Curtidas {get; set; }
    = new List<Curtida>();

    public ICollection<Seguidor> Seguidores { get; set; }
    = new List<Seguidor>();

    public ICollection<Seguidor> Seguindo { get; set; }
    = new List<Seguidor>();

}