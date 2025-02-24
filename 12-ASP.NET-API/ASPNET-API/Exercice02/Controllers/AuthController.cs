using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Exercice02.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Exercice02.Helpers;
using Exercice02.Models;
using Exercice02.Services;
using Microsoft.IdentityModel.Tokens;

namespace Exercice02.Controllers
{
    [Route("auth/")]
    [ApiController]
    public class AuthController(AuthService service) : ControllerBase
    {
        [HttpPost("register")]
        public async Task<ActionResult<RegisterResponseDTO>> Register([FromBody] RegisterRequestDTO registerDto)
        {
            if (registerDto.IsAdmin && User.FindFirstValue(ClaimTypes.Role) != Constants.RoleAdmin)
                return Unauthorized(new RegisterResponseDTO
                {
                    IsSuccessful = false,
                    ErrorMessage = "Vous ne pouvez pas créer d'utilisateurs sans être administrateur."
                });

            //if (await _dbContext.Users.AnyAsync(u => u.Email == registerDto.Email))
            if (await service.Any(u => u.Email == registerDto.Email))
                return BadRequest(new RegisterResponseDTO
                {
                    IsSuccessful = false,
                    ErrorMessage = "Email déjà utilisée !"
                });

            User user;

            try
            {
                user = await service.AddUser(registerDto);
            }
            catch (Exception e)
            {
                return BadRequest(new RegisterResponseDTO()
                {
                    IsSuccessful = false,
                    ErrorMessage = $"Erreur dans l'ajout de l'utilisateur : {e.Message}"
                });
            }

            return Ok(new RegisterResponseDTO()
            {
                IsSuccessful = true,
                User = user
            });
        }

        [HttpPost("login")]
        public async Task<ActionResult<LoginResponseDTO>> Login([FromBody] LoginRequestDTO login)
        {
            var user = await service.GetUser(u => u.Email == login.Email);

            if (user is null)
            {
                return BadRequest(new LoginResponseDTO()
                {
                    IsSuccessful = false,
                    ErrorMessage = "Utilisateur inexistant."
                });
            }

            var isVerified = await service.CheckPassword(user.Password, login.Password);

            if (!isVerified)
            {
                return BadRequest(new LoginResponseDTO()
                {
                    IsSuccessful = false,
                    ErrorMessage = "Mot de passe incorrect."
                });
            }

            var token = await service.CreateJwtToken(user);

            return Ok(new LoginResponseDTO()
            {
                IsSuccessful = true,
                Token = token,
                User = user
            });
        }
    }
}
