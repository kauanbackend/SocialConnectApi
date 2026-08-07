using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialConnectApi.Data;
using SocialConnectApi.DTOs;
using SocialConnectApi.Models;

namespace SocialConnectApi.Services;

public class SeguidorService : ISeguidorService
{
    private readonly AppDbContext _context;

    public SeguidorService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Get()
    {
        var seguidores = await _context.Seguidores.ToListAsync();

        return new OkObjectResult(seguidores);
    }

    public async Task<IActionResult> GetById(int id)
    {
        var seguidor = await _context.Seguidores.FindAsync(id);

        if (seguidor == null)
        {
            return new NotFoundResult();
        }

        return new OkObjectResult(seguidor);
    }

    public async Task<IActionResult> Post(SeguidorCreateDto dto)
    {
        Seguidor seguidor = new Seguidor
        {
            SeguidorId = dto.SeguidorId,
            SeguindoId = dto.SeguindoId
        };

        _context.Seguidores.Add(seguidor);

        await _context.SaveChangesAsync();

        SeguidorResponseDto response = new SeguidorResponseDto
        {
            Id = seguidor.Id,
            SeguidorId = seguidor.SeguidorId,
            SeguindoId = seguidor.SeguindoId
        };

        return new OkObjectResult(response);
    }

    public async Task<IActionResult> Put(int id, Seguidor seguidor)
    {
        if (id != seguidor.Id)
        {
            return new BadRequestResult();
        }

        _context.Entry(seguidor).State = EntityState.Modified;

        await _context.SaveChangesAsync();

        return new NoContentResult();
    }

    public async Task<IActionResult> Delete(int id)
    {
        var seguidor = await _context.Seguidores.FindAsync(id);

        if (seguidor == null)
        {
            return new NotFoundResult();
        }

        _context.Seguidores.Remove(seguidor);

        await _context.SaveChangesAsync();

        return new NoContentResult();
    }
}
