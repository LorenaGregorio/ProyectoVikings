using ModelosProyecto.Vehiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikingsProyectoProgra4.Mapper
{
    class VehiculoMapper : MapperBase<VehiculoModel>
    {
        protected override VehiculoModel Map(IDataRecord registro)
        {
            try
            {
                VehiculoModel vehiculo = new VehiculoModel
                {
                    Id_Cotizacion = registro["Id_Cotizacion"] == DBNull.Value ? 0 : (int)registro["Id_Cotizacion"],
                    Nombre_Dueño_Vehiculo = registro["Nombre_Dueño_Vehiculo"] == DBNull.Value ? string.Empty : (string)registro["Nombre_Dueño_Vehiculo"],
                    Nombre_Responsable_Vehiculo = registro["Nombre_Responsable_Vehiculo"] == DBNull.Value ? string.Empty : (string)registro["Nombre_Responsable_Percance"],
                    Modelo = registro["Modelo"] == DBNull.Value ? string.Empty : (string)registro["Modelo"],
                    Placa = registro["Placa"] == DBNull.Value ? string.Empty : (string)registro["Linea"],
                    Status = registro["Status"] == DBNull.Value ? string.Empty : (string)registro["Status"],
                    Tipo_Vehiculo = registro["Tipo_Vehiculo"] == DBNull.Value ? string.Empty : (string)registro["Tipo_Vehiculo"],
                    Marca = registro["Marca"] == DBNull.Value ? string.Empty : (string)registro["Marca"],
                    Linea = registro["Linea"] == DBNull.Value ? string.Empty : (string)registro["Linea"],
                    Color = registro["Color"] == DBNull.Value ? string.Empty : (string)registro["Color"],
                    Motor = registro["Motor"] == DBNull.Value ? string.Empty : (string)registro["Motor"],
                    Transmision = registro["Transmision"] == DBNull.Value ? string.Empty : (string)registro["Transmision"],
                    Numero_Llantas = registro["Numero_Llantas"] == DBNull.Value ? string.Empty : (string)registro["Numero_Llantas"],
                    Cilindraje = registro["Cilindraje"] == DBNull.Value ? string.Empty : (string)registro["Cilindraje"],
                    Costo = registro["Costo"] == DBNull.Value ? string.Empty : (string)registro["Costo"],
                    usuario = registro["usuario"] == DBNull.Value ? string.Empty : (string)registro["usuario"],

                };
                return vehiculo;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
