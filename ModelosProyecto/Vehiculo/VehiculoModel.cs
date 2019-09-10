using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosProyecto.Vehiculo
{
    public class VehiculoModel
    {
        public int ? Id_Vehiculo { get; set; }
        public string Tipo_Vehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Linea { get; set; }
        public string Color { get; set; }
        public string Motor { get; set; }
        public string Transmision { get; set; }
        public string Numero_Llantas { get; set; }
        public string Cilindraje { get; set; }
        public string Placa { get; set; }
        public string Status { get; set; }


    }
}
