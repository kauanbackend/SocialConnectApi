using Microsoft.AspNetCore.Mvc;
using SocialConnectApi.DTOs;
using SocialConnectApi.Models;

namespace SocialConnectApi.Services;

public interface IComentarioService
{
    Task<IActionResult> Get();
    Task<IActionResult> GetById(int id);
    Task<IActionResult> Post(ComentarioCreateDto dto);
    Task<IActionResult> Put(int id, Comentario comentario);
    Task<IActionResult> Delete(int id);
}
