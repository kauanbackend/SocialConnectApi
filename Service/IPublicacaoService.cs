using Microsoft.AspNetCore.Mvc;
using SocialConnectApi.DTOs;
using SocialConnectApi.Models;

namespace SocialConnectApi.Services;

public interface IPublicacaoService
{
    Task<IActionResult> Get();
    Task<IActionResult> GetById(int id);
    Task<IActionResult> Post(PublicacaoCreateDto dto);
    Task<IActionResult> Put(int id, Publicacao publicacao);
    Task<IActionResult> Delete(int id);
}