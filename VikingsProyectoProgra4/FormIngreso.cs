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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IO7SKIU\\SQLEXPRESS;Initial Catalog=VikingsDB;Integrated Security=True");


        int z = 0;

        public void validarUsuario(string USUARIO, string CONTRASEÑA)
        {


            con.Open();

            // se crea consulta
            SqlCommand cmd = new SqlCommand("Select Nombre1 , Roll_Usuario FROM UsuarioTBL  WHERE Usuario = @user AND Contraseña = @pass ", con);

            //se ejecuta comando para la evaluacion de la consulta con los textbox
            cmd.Parameters.AddWithValue("user", USUARIO);
            cmd.Parameters.AddWithValue("pass", CONTRASEÑA);
            // la siguiente linea de codigo realiza una adatacion de los datos extraidos e ingresado
            //para generar como una tabla virtual para que se valla a buscar los datos segun la consulta 
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);



            // este if evalua si hay datos en la base de datos
            if (dt.Rows.Count == 1)
            {
                // este if realiza una compracion de tipo de usuairo
                if (dt.Rows[0][1].ToString() == "1")
                {
                    FormMenu menu = new FormMenu();
                    menu.Show();
                    menu.Text = "Cotizador";
                    //menu.Controls["For"]
                    menu.Controls["label1"].Text = "Cotizador";
                    menu.Controls["button2"].Visible = false;
                    MessageBox.Show("Bienvenido " + dt.Rows[0][0].ToString());
                    z = 1;
                }

                // este if realiza una compracion de tipo de usuairo
                if (dt.Rows[0][1].ToString() == "2")
                {
                    FormMenu menu = new FormMenu();
                    menu.Show();
                    menu.Text = "Receptor";
                    //menu.Controls["For"]
                    menu.Controls["label1"].Text = "Receptor";
                    menu.Controls["button2"].Visible = true;
                    menu.Controls["button1"].Visible = false;
                    menu.Controls["button3"].Visible = false;
                   

                    MessageBox.Show("Bienvenido " + dt.Rows[0][0].ToString());
                    z = 1;
                }

            }
            else
            {
                //MessageBox.Show("Usuario / Contraseña Incorrecto", "Error");
                //con.Close();
                z = 0;
            }
            this.txtusuario.Clear();
            this.txtcontraseña.Clear();
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            validarUsuario(this.txtusuario.Text, this.txtcontraseña.Text);

            if (z == 0)
            {
                MessageBox.Show("Usuario / Contraseña Incorrecto", "Error");
                con.Close();
            }
            if (z == 1)
            {
                this.Hide();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
