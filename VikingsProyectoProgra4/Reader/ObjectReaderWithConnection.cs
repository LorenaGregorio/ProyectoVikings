using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikingsProyectoProgra4.Reader
{
    public abstract class ObjectReaderWithConnection <T>: ObjectReaderBase <T>
    {
        public static string ConnectionString = "Data Source=DESKTOP-IO7SKIU\\SQLEXPRESS;Initial Catalog=VikingsDB;Integrated Security=True";
        protected override IDbConnection GetConecction()
        {
            IDbConnection connection = new SqlConnection(ConnectionString);
            return connection;
        }

    }
}
