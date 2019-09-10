
using ModelosProyecto.Usuario;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VikingsProyectoProgra4.DataClass;
using VikingsProyectoProgra4.Mapper;
using VikingsProyectoProgra4.Utils;
using static VikingsProyectoProgra4.DataClass.QueryRepo;

namespace VikingsProyectoProgra4.Reader
{
    public class UsuarioReader : ObjectReaderWithConnection<UsuarioModel>
    {

        private string DefaultCommad = "SELECT * FROM UsuarioTBL";

        public UsuarioReader(TipoQuery tipo, UsuarioModel usuarioModel)
        {
            switch (tipo)
            {
                case TipoQuery.Todos:
                    this.DefaultCommad = QueryProcessor.QueryAll(QueryRepo.SelectAll, "UsuarioTBL");
                    break;
                case TipoQuery.PorId:
                    this.DefaultCommad = QueryProcessor.QueryByID(QueryRepo.SelectByID, "UsuarioTBL", "IdPersona", usuarioModel.Id_Usuario.ToString());
                    break;
                case TipoQuery.TodosConFiltros:
                    this.DefaultCommad = QueryProcessor.QueryAll(QueryRepo.SelectAll, "UsuarioTBL", usuarioModel);
                    break;
                case TipoQuery.PorIdConFiltro:
                    break;
                case TipoQuery.AddRow:
                    this.DefaultCommad = QueryProcessor.AddRow(QueryRepo.AddRow, "UsuarioTBL", usuarioModel);
                    break;
                case TipoQuery.UpdateRow:
                    this.DefaultCommad = QueryProcessor.UpdateRow(QueryRepo.UpdateRow, "UsuarioTBL", usuarioModel);
                    break;
                default:
                    break;
            }
        }

     

        protected override string CommandText => DefaultCommad;

        protected override CommandType CommandType => CommandType.Text;

        protected override Collection<IDataParameter> GetParameters(IDbCommand commnad)
        {
            Collection<IDataParameter> collection = new Collection<IDataParameter>();
            return collection;
        }
        protected override MapperBase<UsuarioModel> GetMapper()
        {
            MapperBase<UsuarioModel> mapper = new UsuarioMapper();
            return mapper;
        }

        
    }
}
