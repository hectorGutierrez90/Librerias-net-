
namespace MiWebApi8.DTO
{
    public class ObtenerUsuarioDTO
    {    
        public string Nombre { get; set; } = string.Empty;
        public int Edad { get; set; }
        public IList<DireccionDTO> Direcciones { get; set; } = new List<DireccionDTO>();
    }
}
