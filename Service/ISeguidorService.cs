using Microsoft.AspNetCore.Mvc;
using SocialConnectApi.DTOs;
using SocialConnectApi.Models;

namespace SocialConnectApi.Services;

public interface ISeguidorService
{
    Task<IActionResult> Get();
    Task<IActionResult> GetById(int id);
    Task<IActionResult> Post(SeguidorCreateDto dto);
    Task<IActionResult> Put(int id, Seguidor seguidor);
    Task<IActionResult> Delete(int id);
}
