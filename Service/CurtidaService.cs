using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialConnectApi.Data;
using SocialConnectApi.DTOs;
using SocialConnectApi.Models;

namespace SocialConnectApi.Services;

public class CurtidaService : ICurtidaService
{
    private readonly AppDbContext _context;

    public CurtidaService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Get()
    {
        var curtidas = await _context.Curtidas.ToListAsync();

        return new OkObjectResult(curtidas);
    }

    public async Task<IActionResult> GetById(int id)
    {
        var curtida = await _context.Curtidas.FindAsync(id);

        if (curtida == null)
        {
            return new NotFoundResult();
        }

        return new OkObjectResult(curtida);
    }

    public async Task<IActionResult> Post(CurtidaCreateDto dto)
    {
        Curtida curtida = new Curtida
        {
            UsuarioId = dto.UsuarioId,
            PublicacaoId = dto.PublicacaoId
        };

        _context.Curtidas.Add(curtida);

        await _context.SaveChangesAsync();

        CurtidaResponseDto response = new CurtidaResponseDto
        {
            Id = curtida.Id,
            UsuarioId = curtida.UsuarioId,
            PublicacaoId = curtida.PublicacaoId
        };

        return new OkObjectResult(response);
    }

    public async Task<IActionResult> Put(int id, Curtida curtida)
    {
        if (id != curtida.Id)
        {
            return new BadRequestResult();
        }

        _context.Entry(curtida).State = EntityState.Modified;

        await _context.SaveChangesAsync();

        return new NoContentResult();
    }

    public async Task<IActionResult> Delete(int id)
    {
        var curtida = await _context.Curtidas.FindAsync(id);

        if (curtida == null)
        {
            return new NotFoundResult();
        }

        _context.Curtidas.Remove(curtida);

        await _context.SaveChangesAsync();

        return new NoContentResult();
    }
}
