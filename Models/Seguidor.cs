namespace SocialConnectApi.Models;

public class Seguidor
{
    public int Id { get; set; }

    public int SeguidorId { get; set; }
    public Usuario SeguidorUsuario { get; set; } = null!;

    public int SeguindoId { get; set; }
    public Usuario SeguindoUsuario { get; set; } = null!;
}
