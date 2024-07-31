using Microsoft.AspNetCore.Mvc;
using WeaponShop.Models;
using WeaponShop.Models.Response;

namespace WeaponShop;

[Route("api/[controller]")]
public class WeaponController
{
    [HttpGet("")]
    public ApiResponse GetAll()
    {
        var weapons = new[]
        {
            new Weapon { Id = 1, Name = "Sword", Price = 10 },
            new Weapon { Id = 2, Name = "Axe", Price = 15 },
            new Weapon { Id = 3, Name = "Bow", Price = 5 }
        };
        return ApiResponse.SuccessWithData(weapons);
    }
}