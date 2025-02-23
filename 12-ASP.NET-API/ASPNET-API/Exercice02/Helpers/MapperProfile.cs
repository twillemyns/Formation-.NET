using AutoMapper;
using Exercice02.Models;
using Exercice02.Models.DTOs;

namespace Exercice02.Helpers;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<User, LoginRequestDTO>().ReverseMap();
        CreateMap<User, RegisterRequestDTO>().ReverseMap();
    }
}