using ModelosProyecto.Vehiculo;
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
    public class VehiculoReader : ObjectReaderWithConnection<VehiculoModel>
    {

        private string DefaultCommad = "SELECT * FROM Cotizacion_TBL";

        public VehiculoReader(DataClass.QueryRepo.TipoQuery tipo, VehiculoModel vehiculoModel)
        {
            switch (tipo)
            {
                case TipoQuery.Todos:
                    this.DefaultCommad = QueryProcessor.QueryAll(QueryRepo.SelectAll, "Cotizacion_TBL");
                    break;
                case TipoQuery.PorId:
                    this.DefaultCommad = QueryProcessor.QueryByID(QueryRepo.SelectByID, "Cotizacion_TBL", "Id_Cotizacion", vehiculoModel.Id_Cotizacion.ToString());
                    break;
                case TipoQuery.TodosConFiltros:
                    this.DefaultCommad = QueryProcessor.QueryAll(QueryRepo.SelectAll, "Cotizacion_TBL", vehiculoModel);
                    break;
                case TipoQuery.PorIdConFiltro:
                    break;
                case TipoQuery.AddRow:
                    this.DefaultCommad = QueryProcessor.AddRow(QueryRepo.AddRow, "Cotizacion_TBL", vehiculoModel);
                    break;
                case TipoQuery.UpdateRow:
                    this.DefaultCommad = QueryProcessor.UpdateRow(QueryRepo.UpdateRow, "Cotizacion_TBL", vehiculoModel);
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
        protected override MapperBase<VehiculoModel> GetMapper()
        {
            MapperBase<VehiculoModel> mapper = new VehiculoMapper();
            return mapper;
        }
    }
}
