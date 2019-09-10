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
                    Id_Vehiculo = registro["Id_Vehiculo"] == DBNull.Value ? 0 : (int)registro["Id_Vehiculo"],
                    Tipo_Vehiculo = registro["Tipo_Vehiculo"] == DBNull.Value ? string.Empty : (string)registro["Tipo_Vehiculo"],
                    Marca = registro["Marca"] == DBNull.Value ? string.Empty : (string)registro["Marca"],
                    Modelo = registro["Modelo"] == DBNull.Value ? string.Empty : (string)registro["Modelo"],
                    Linea = registro["Linea"] == DBNull.Value ? string.Empty : (string)registro["Linea"],
                    Color = registro["Color"] == DBNull.Value ? string.Empty : (string)registro["Color"],
                    Motor = registro["Motor"] == DBNull.Value ? string.Empty : (string)registro["Motor"],
                    Transmision = registro["Transmision"] == DBNull.Value ? string.Empty : (string)registro["Transmision"],
                    Numero_Llantas = registro["Numero_Llantas"] == DBNull.Value ? string.Empty : (string)registro["Numero_Llantas"],
                    Cilindraje = registro["Numero_Cilindraje"] == DBNull.Value ? string.Empty : (string)registro["Numero_Cilindraje"],
                    Placa = registro["Placa"] == DBNull.Value ? string.Empty : (string)registro["Placa"],
                    Status = registro["Status"] == DBNull.Value ? string.Empty : (string)registro["Status"],
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
