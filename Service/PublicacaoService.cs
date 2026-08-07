using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialConnectApi.Data;
using SocialConnectApi.DTOs;
using SocialConnectApi.Models;

namespace SocialConnectApi.Services;

public class PublicacaoService : IPublicacaoService
{
    private readonly AppDbContext _context;

    public PublicacaoService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Get()
    {
        var publicacoes = await _context.Publicacoes.ToListAsync();

        return new OkObjectResult(publicacoes);
    }

    public async Task<IActionResult> GetById(int id)
    {
        var publicacao = await _context.Publicacoes.FindAsync(id);

        if (publicacao == null)
        {
            return new  NotFoundResult();
        }

        return new OkObjectResult(publicacao);
    }

    public async Task<IActionResult> Post(PublicacaoCreateDto dto)
    {
        Publicacao publicacao = new Publicacao
        {
            Conteudo = dto.Conteudo,
            UsuarioId = dto.UsuarioId,
            DataPublicacao = DateTime.Now
        };

        _context.Publicacoes.Add(publicacao);

        await _context.SaveChangesAsync();

        PublicacaoResponseDto response = new PublicacaoResponseDto
        {
            Id = publicacao.Id,
            Conteudo = publicacao.Conteudo,
            DataPublicacao = publicacao.DataPublicacao,
            UsuarioId = publicacao.UsuarioId
        };

        return new OkObjectResult(response);
    }
    public async Task<IActionResult> Put(int id, Publicacao publicacao)
    {
        if(id != publicacao.Id)
        {
            return new BadRequestResult();
        }

        _context.Entry(publicacao).State = EntityState.Modified;

        await _context.SaveChangesAsync();

        return new NoContentResult();
    }

    public async Task<IActionResult> Delete(int id)
    {
        var publicacao = await _context.Publicacoes.FindAsync(id);

        if(publicacao == null)
        {
            return new NotFoundResult();
        }

        _context.Publicacoes.Remove(publicacao);

        await _context.SaveChangesAsync();

        return new NoContentResult();
    }
}