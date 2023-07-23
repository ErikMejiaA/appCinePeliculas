using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        //creamos el mapeo de las entidades a las clases Dto
        CreateMap<Genero, GeneroDto>().ReverseMap();
    }
}
