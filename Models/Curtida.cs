using SocialConnectApi.Models;

namespace SocialConnectApi.Models;

public class Curtida
{
    public int Id { get; set; }

    public int UsuarioId { get; set; }

    public Usuario Usuario { get; set; } = null!;

    public int PublicacaoId { get; set; }

    public Publicacao Publicacao { get; set; } = null!;
}