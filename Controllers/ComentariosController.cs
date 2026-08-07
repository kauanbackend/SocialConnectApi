using Microsoft.AspNetCore.Mvc;
using SocialConnectApi.DTOs;
using SocialConnectApi.Models;
using SocialConnectApi.Services;

namespace SocialConnectApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ComentariosController : ControllerBase
{
    private readonly IComentarioService _service;

    public ComentariosController(IComentarioService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return await _service.Get();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        return await _service.GetById(id);
    }

    [HttpPost]
    public async Task<IActionResult> Post(ComentarioCreateDto dto)
    {
        return await _service.Post(dto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Comentario comentario)
    {
        return await _service.Put(id, comentario);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        return await _service.Delete(id);
    }
}
