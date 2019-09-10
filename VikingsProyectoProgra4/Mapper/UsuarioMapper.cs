using ModelosProyecto.Usuario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikingsProyectoProgra4.Mapper
{
    class UsuarioMapper : MapperBase<UsuarioModel>
    {
        protected override UsuarioModel Map(IDataRecord registro)
        {
            try
            {
                UsuarioModel usuario = new UsuarioModel
                {
                    Id_Usuario = registro["Id_Usuario"] == DBNull.Value ? 0 : (int)registro["Id_Usuario"],
                    Nombre1 = registro["Nombre1"] == DBNull.Value ? string.Empty : (string)registro["Nombre1"],
                    Nombre2 = registro["Nombre2"] == DBNull.Value ? string.Empty : (string)registro["Nombre2"],
                    Apellido1 = registro["Apellido1"] == DBNull.Value ? string.Empty : (string)registro["Apellido1"],
                    Apellido2 = registro["Apellido2"] == DBNull.Value ? string.Empty : (string)registro["Apellido2"],
                    User = registro["Usuario"] == DBNull.Value ? string.Empty : (string)registro["Usuario"],
                    Contraseña = registro["Contraseña"] == DBNull.Value ? string.Empty : (string)registro["Contraseña"],
                    Roll_Usuario = registro["Roll_Usuario"] == DBNull.Value ? string.Empty : (string)registro["Roll_Usuario"],
                    Status = registro["Status"] == DBNull.Value ? string.Empty : (string)registro["Status"],
                    
                };
                return usuario;

            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
