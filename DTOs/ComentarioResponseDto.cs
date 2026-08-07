namespace SocialConnectApi.DTOs;

public class ComentarioResponseDto
{
    public int Id { get; set; }

    public string Conteudo { get; set; } = string.Empty;

    public DateTime DataComentario { get; set; }

    public int UsuarioId { get; set; }

    public int PublicacaoId { get; set; }
}