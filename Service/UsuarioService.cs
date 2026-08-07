using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialConnectApi.Data;
using SocialConnectApi.DTOs;
using SocialConnectApi.Models;

namespace SocialConnectApi.Service;

public class UsuarioService : IUsuarioService
{
    private readonly AppDbContext _context;
    
    public UsuarioService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Get()
    {
        var usuarios = await _context.Usuarios.ToListAsync();

        return new OkObjectResult(usuarios);
    }

    public async Task<IActionResult> GetById(int id)
    {
       var usuario = await _context.Usuarios.FindAsync(id);

       if(usuario == null)
        {
          return new NotFoundResult();
  
        } 

        return new OkObjectResult(usuario);
    }

    public async Task<IActionResult> Post(UsuarioCreateDto dto)
    {
        Usuario usuario = new Usuario
        {
            Nome = dto.Nome,
            Email = dto.Email,
            Senha = dto.Senha,
            Bio = dto.Bio,
            DataCadastro = DateTime.Now
        };

        _context.Usuarios.Add(usuario);

        await _context.SaveChangesAsync();

        UsuarioResponseDto response = new UsuarioResponseDto
        {
            Id = usuario.Id,
            Nome = usuario.Nome,
            Email = usuario.Email,
            Bio = usuario.Bio,
            DataCadastro = usuario.DataCadastro
        };

        return new OkObjectResult(response);
    }

    public async Task<IActionResult> Put(int id, Usuario usuario)
    {
        if(id != usuario.Id)
        {
            return new BadRequestResult();
        }

        _context.Entry(usuario).State = EntityState.Modified;

        await _context.SaveChangesAsync();

        return new NoContentResult();
    }

    public async Task<IActionResult> Delete(int id)
    {
        var usuario = await _context.Usuarios.FindAsync(id);

        if (usuario == null)
        {
            return new NotFoundResult();
        }

        _context.Usuarios.Remove(usuario);

        await _context.SaveChangesAsync();

        return new NoContentResult();
    }
}