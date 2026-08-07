using Microsoft.AspNetCore.Mvc;
using SocialConnectApi.DTOs;
using SocialConnectApi.Models;
using SocialConnectApi.Services;

namespace SocialConnectApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CurtidasController : ControllerBase
{
    private readonly ICurtidaService _service;

    public CurtidasController(ICurtidaService service)
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
    public async Task<IActionResult> Post(CurtidaCreateDto dto)
    {
        return await _service.Post(dto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Curtida curtida)
    {
        return await _service.Put(id, curtida);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        return await _service.Delete(id);
    }
}
