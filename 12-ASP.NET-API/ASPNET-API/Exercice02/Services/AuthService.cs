using System.IdentityModel.Tokens.Jwt;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using Exercice02.Abstractions;
using Exercice02.Helpers;
using Exercice02.Models;
using Exercice02.Models.DTOs;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Exercice02.Services;

public class AuthService(
    IRepository<User> userRepository,
    IMapper mapper,
    Encryptor encryptor,
    IOptions<AppSettings> options
)
{
    public async Task<User?> GetUser(Guid id)
    {
        return await userRepository.Get(id);
    }

    public async Task<User?> GetUser(Expression<Func<User, bool>> predicate)
    {
        return await userRepository.Get(predicate);
    }

    public async Task<bool> Any(Expression<Func<User, bool>> predicate)
    {
        return await userRepository.Any(predicate);
    }

    public async Task<User> AddUser(RegisterRequestDTO registerDTO)
    {
        var user = mapper.Map<User>(registerDTO);

        user.Password = encryptor.EncryptPassword(registerDTO.Password);

        await userRepository.Add(user);

        return user;
    }

    public async Task<bool> CheckPassword(string userPassword, string loginPassword)
    {
        return encryptor.Check(userPassword, loginPassword);
    }

    public async Task<string> CreateJwtToken(User user)
    {
        var role = user.IsAdmin ? Constants.RoleAdmin : Constants.RoleUser;

        var claims = new List<Claim>()
        {
            new(ClaimTypes.Role, role),
            new(Constants.ClaimUserId, user.Id.ToString())
        };

        var securityKey = options.Value.SecretKey;

        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.ASCII.GetBytes(securityKey)),
            SecurityAlgorithms.HmacSha256
        );

        var jwt = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.UtcNow.AddDays(options.Value.TokenExpirationDays),
            signingCredentials: signingCredentials
        );

        return new JwtSecurityTokenHandler().WriteToken(jwt);
    }
}