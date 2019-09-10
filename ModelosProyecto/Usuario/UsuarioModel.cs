using System.Text;
using System.Threading.Tasks;

namespace ModelosProyecto.Usuario
{
    public class UsuarioModel
    {
        public int ? Id_Usuario { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string User { get; set; }
        public string Contraseña { get; set; }
        public string Roll_Usuario { get; set; }
        public string Status { get; set; }

    }
}
