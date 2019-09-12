using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VikingsProyectoProgra4
{
    public partial class HistorialForm : Form
    {
        public HistorialForm()
        {
            InitializeComponent();
        }

        SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-IO7SKIU\\SQLEXPRESS;Initial Catalog=VikingsDB;Integrated Security=True");
        DataSet ds,ds2;

        public void actulizar()
        {
            Conexion.Open();
            SqlCommand mostrar = new SqlCommand("SELECT * FROM Cotizacion_TBL", Conexion);
            SqlCommand mostrar2 = new SqlCommand("SELECT * FROM RegistroTBL", Conexion);

            SqlDataAdapter m_datos = new SqlDataAdapter(mostrar);
            SqlDataAdapter m_datos2 = new SqlDataAdapter(mostrar2);

            ds = new DataSet();
            ds2 = new DataSet();

            m_datos.Fill(ds);
            m_datos2.Fill(ds2);

            dataGridView1.DataSource = ds.Tables[0];

            dataGridView2.DataSource = ds2.Tables[0];
            Conexion.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.actulizar();
        }

        private void HistorialForm_Load(object sender, EventArgs e)
        {
            this.actulizar();
        }
    }
}
