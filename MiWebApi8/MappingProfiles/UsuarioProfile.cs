using AutoMapper;
using MiWebApi8.DTO;
using MiWebApi8.Models;

namespace MiWebApi8.MappingProfiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Usuario, ObtenerUsuarioDTO>();

            CreateMap<Direccion, DireccionDTO>()
                    .ForMember(dest => dest.DireccionCompleta, opt => opt.MapFrom(src => src.DireccionCompleta))
                    .ReverseMap();

            // Mapeo de CrearUsuarioDTO a Usuario
            CreateMap<CrearUsuarioDTO, Usuario>()
                .ForMember(dest => dest.Id, opt => opt.Ignore()) // Ignora el Id al crear un nuevo usuario
                .ForMember(dest => dest.Identificacion, opt => opt.MapFrom(src => src.NumeroDeDocumento)); 
                
        }
    }
}
