using Microsoft.AspNetCore.Mvc;
using SocialConnectApi.DTOs;
using SocialConnectApi.Models;

namespace SocialConnectApi.Service;

public interface IUsuarioService
{
    Task<IActionResult> Get();
    Task<IActionResult> GetById(int id);
    Task<IActionResult> Post(UsuarioCreateDto dto);
    Task<IActionResult> Put(int id, Usuario usuario);
    Task<IActionResult> Delete(int id);
}