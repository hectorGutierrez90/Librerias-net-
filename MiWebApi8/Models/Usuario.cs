namespace MiWebApi8.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Edad { get; set; }
        public string Identificacion { get; set; } = string.Empty;
        public IList<Direccion> Direcciones { get; set; } = new List<Direccion>();
    }
}
