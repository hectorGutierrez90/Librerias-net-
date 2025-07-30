
namespace MiWebApi8.DTO
{
    public class CrearUsuarioDTO
    {
        public required string Nombre { get; set; }
        public int Edad { get; set; }
        public string NumeroDeDocumento { get; set; } = string.Empty;
        public IList<DireccionDTO> Direcciones { get; set; } = new List<DireccionDTO>();
    }
}
