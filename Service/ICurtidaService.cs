using Microsoft.AspNetCore.Mvc;
using SocialConnectApi.DTOs;
using SocialConnectApi.Models;

namespace SocialConnectApi.Services;

public interface ICurtidaService
{
    Task<IActionResult> Get();
    Task<IActionResult> GetById(int id);
    Task<IActionResult> Post(CurtidaCreateDto dto);
    Task<IActionResult> Put(int id, Curtida curtida);
    Task<IActionResult> Delete(int id);
}
