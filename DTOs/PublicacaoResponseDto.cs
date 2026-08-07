namespace SocialConnectApi.DTOs;

public class PublicacaoResponseDto
{
    public int Id { get; set; }

    public string Conteudo { get; set; } =  string.Empty;

    public DateTime DataPublicacao { get; set; }

    public int UsuarioId { get; set; }
}