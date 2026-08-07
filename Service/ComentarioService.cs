using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialConnectApi.Data;
using SocialConnectApi.DTOs;
using SocialConnectApi.Models;

namespace SocialConnectApi.Services;

public class ComentarioService : IComentarioService
{
    private readonly AppDbContext _context;

    public ComentarioService(AppDbContext context)
    {
        _context = context;
    }

        public async Task<IActionResult> Get()
    {
        var comentarios = await _context.Comentarios.ToListAsync();

        return new OkObjectResult(comentarios);
    }

    public async Task<IActionResult> GetById(int id)
    {
        var comentario = await _context.Comentarios.FindAsync(id);

        if (comentario == null)
        {
            return new  NotFoundResult();
        }

        return new OkObjectResult(comentario);
    }

    public async Task<IActionResult> Post(ComentarioCreateDto dto)
    {
    Comentario comentario = new Comentario
    {
        Conteudo = dto.Conteudo,
        UsuarioId = dto.UsuarioId,
        PublicacaoId = dto.PublicacaoId,
        DataComentario = DateTime.Now
    };

    _context.Comentarios.Add(comentario);

    await _context.SaveChangesAsync();

    ComentarioResponseDto response = new ComentarioResponseDto
    {
        Id = comentario.Id,
        Conteudo = comentario.Conteudo,
        DataComentario = comentario.DataComentario,
        UsuarioId = comentario.UsuarioId,
        PublicacaoId = comentario.PublicacaoId
    };

    return new OkObjectResult(response);
    }

    public async Task<IActionResult> Put(int id, Comentario comentario)
    {
    if (id != comentario.Id)
    {
        return new BadRequestResult();
    }

    _context.Entry(comentario).State = EntityState.Modified;

    await _context.SaveChangesAsync();

    return new NoContentResult();
    }

    public async Task<IActionResult> Delete(int id)
    {
    var comentario = await _context.Comentarios.FindAsync(id);

    if (comentario == null)
    {
        return new NotFoundResult();
    }

    _context.Comentarios.Remove(comentario);

    await _context.SaveChangesAsync();

    return new NoContentResult();
    }

}
