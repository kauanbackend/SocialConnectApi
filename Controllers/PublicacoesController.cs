using Microsoft.AspNetCore.Mvc;
using SocialConnectApi.DTOs;
using SocialConnectApi.Models;
using SocialConnectApi.Services;

namespace SocialConnectApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PublicacoesController : ControllerBase
{
    private readonly IPublicacaoService _service;

    public PublicacoesController(IPublicacaoService service)
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
    public async Task<IActionResult> Post(PublicacaoCreateDto dto)
    {
        return await _service.Post(dto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Publicacao publicacao)
    {
        return await _service.Put(id, publicacao);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        return await _service.Delete(id);
    }
}