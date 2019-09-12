using ModelosProyecto.Usuario;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VikingsProyectoProgra4.DataClass;
using VikingsProyectoProgra4.Reader;

namespace VikingsProyectoProgra4
{
    public partial class FormNuevoUsuario : Form
    {
        public FormNuevoUsuario()
        {
            InitializeComponent();
        }

        SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-IO7SKIU\\SQLEXPRESS;Initial Catalog=VikingsDB;Integrated Security=True");
        DataSet ds;

        bool editar;
        int Id;

        string cadena, car, numero;

        public void actulizar()
        {
            Conexion.Open();
            SqlCommand mostrar = new SqlCommand("SELECT * FROM UsuarioTBL", Conexion);

            SqlDataAdapter m_datos = new SqlDataAdapter(mostrar);
            ds = new DataSet();
            m_datos.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            Conexion.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {


            


            //if (editar)
            //{
            //    //Se realiza un update
            //    Conexion.Open();
            //    string consulta = "update UsuarioTBL set Nombre = '" + u1.nombre + "', Apellido ='" + u1.apellido + "', Usuario ='" + u1.usuario + "', Contraseña ='" + u1.contraseña + "', RollUsuario  =" + u1.roll + "    where IdUsuario = " + Id + " ;";
            //    SqlCommand mostrar = new SqlCommand("SELECT * FROM UsuarioTBL", Conexion); Conexion.EjecutarSql(consulta);
            //    this.actulizar();
            //    Conexion.Close();

            //    editar = false;

            //}
            //else
            //{
      
            UsuarioModel u1 = new UsuarioModel();
            //personaModel.IdPersona = 1;
            u1.Nombre1 = txtnombre1.Text;
            u1.Nombre2 = txtnombre2.Text;
            u1.Apellido1 = txtapellido1.Text;
            u1.Apellido2 = txtapellido2.Text;
            u1.User = txtusuario.Text;
            u1.Contraseña = txtcontraseña.Text;
            u1.Roll_Usuario = textBox8.Text;
            u1.Status = txtstatus.Text;



            UsuarioReader reader = new UsuarioReader(QueryRepo.TipoQuery.AddRow, u1);
            Collection<UsuarioModel> people = reader.Execute();



            ////Se crea una consulta para insertar los datos (Guardar)
            //string consulta = "insert into UsuarioTBL (Nombre, Apellido, Usuario, Contraseña, RollUsuario) values ('" + u1.nombre + "','" + u1.apellido + "','" + u1.usuario + "','" + u1.contraseña + "'," + u1.roll + " );";
            //    //con esta funcion ejecuto la consulta de arriba en codigo sql
            //    Conexion.EjecutarSql(consulta);
            //    this.actulizar();
            //    Conexion.Close();
            //}
        }

        private void FormNuevoUsuario_Load(object sender, EventArgs e)
        {
            this.actulizar();
        }
    }
}
