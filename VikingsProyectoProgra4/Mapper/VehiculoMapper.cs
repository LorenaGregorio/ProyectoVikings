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
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
