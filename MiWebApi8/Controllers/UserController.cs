using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MiWebApi8.DTO;
using MiWebApi8.Models;

namespace MiWebApi8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost("PostUsuario")]
        public IActionResult Post([FromBody] CrearUsuarioDTO usuarioDTO)
        {
            if (usuarioDTO == null)
            {
                return BadRequest("El usuario no puede ser nulo.");
            }
            var usuario = _mapper.Map<Usuario>(usuarioDTO);
            // Alternativamente, puedes mapear manualmente si no quieres usar AutoMapper:
            // var usuario = mapearUsuarioManualmente(usuarioDTO);  
            var resultado = GuardarUsuario(usuario);
            return Ok(resultado);
        }

        [HttpGet("ObtenerUsuarios")]
        [ProducesResponseType(typeof(ObtenerUsuarioDTO), StatusCodes.Status200OK)]
        public IActionResult ObtenerUsuarios()
        {
            // Aquí iría la lógica para obtener los usuarios de una base de datos o repositorio
            var usuarios = new Usuario
            {
                Id = 1,
                Nombre = "Juan",
                Edad = 30,
                Identificacion = "123456789",
                Direcciones = new List<Direccion>()
                {
                    new Direccion { Id = 1, DireccionCompleta = "Calle Falsa 123" }
                }
            };

            var usuariosDTO = _mapper.Map<ObtenerUsuarioDTO>(usuarios);
            return Ok(usuariosDTO);
        }
            

        private string GuardarUsuario(Usuario usuario)
        {
            // Aquí iría la lógica para guardar el usuario en una base de datos o repositorio
            // Por simplicidad, retornamos un mensaje de éxito
            return $"Usuario {usuario.Nombre} guardado con éxito.";
        }
        


    }
}