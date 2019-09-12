using ModelosProyecto.Vehiculo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VikingsProyectoProgra4.DataClass;
using VikingsProyectoProgra4.Reader;

namespace VikingsProyectoProgra4
{
    public partial class CotizadorForm : Form
    {
        SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-IO7SKIU\\SQLEXPRESS;Initial Catalog=VikingsDB;Integrated Security=True");
        ////private Stack<VehiculoModel> PilaVehiculos = new Stack<VehiculoModel>();
        public double costo = 0;
        public double prima = 0;
        public double cmodelo = 0;
        public double cllantas = 0;
        public double cmotor = 0;
        public double ccilindros = 0;
        public double total = 0;


        public CotizadorForm()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbModelo.Text != "2009")
            {
                lblCosto.Visible = true;
                lblQ.Visible = true;
                txtCosto.Visible = true;
                txtCosto.Clear();
            }
            else
            {
                lblCosto.Visible = false;
                lblQ.Visible = false;
                txtCosto.Visible = false;
                txtCosto.Text = "100000";
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtCosto.Text == "")
            {
                MessageBox.Show("Debe ingresar el precio del vehículo");
            }
            else
            {
                costo = Convert.ToDouble(txtCosto.Text);
                total = costo * 0.03;

                //Porcentaje extra del modelo
                if (cbModelo.Text == "")
                {
                    MessageBox.Show("Debe indicar el modelo del vehículo");
                }
                else
                {
                    if (Convert.ToInt32(cbModelo.Text) > 2017)
                    {
                        prima = 0.11;
                        cmodelo = (costo * prima);
                    }
                    if (Convert.ToInt32(cbModelo.Text) > 2014 && Convert.ToInt32(cbModelo.Text) <= 2017)
                    {
                        prima = 0.07;
                        cmodelo = costo * prima;
                    }
                    if (Convert.ToInt32(cbModelo.Text) < 2014)
                    {
                        prima = 0.03;
                        cmodelo = -1 * (costo * prima);
                    }
                    total = total + cmodelo;

                    //Porcentaje llantas
                    if (cbLlantas.Text == "")
                    {
                        MessageBox.Show("Debe indicar el número de llantas");
                    }
                    else
                    {
                        if (cbLlantas.Text == "4")
                        {
                            cllantas = costo * 0.07;
                        }
                        if (cbLlantas.Text == "6")
                        {
                            cllantas = costo * 0.15;
                        }
                        if (cbLlantas.Text == "+6")
                        {
                            cllantas = costo * 0.17;
                        }
                        total = total + cllantas;

                        //Porcentaje motor
                        if (txtMotor.Text == "")
                        {
                            MessageBox.Show("Debe indicar el número de motor");
                        }
                        else
                        {
                            if (Convert.ToInt32(txtMotor.Text) > 3500)
                            {
                                MessageBox.Show("El número máximo de motor es 3500");
                            }
                            else
                            {
                                if (Convert.ToInt32(txtMotor.Text) < 1500)
                                {
                                    prima = -0.057;
                                    cmotor = costo * prima;
                                }
                                if (Convert.ToInt32(txtMotor.Text) < 2000)
                                {
                                    prima = 0.013;
                                    cmotor = costo * prima;
                                }
                                if (Convert.ToInt32(txtMotor.Text) >= 2000 && Convert.ToInt32(txtMotor.Text) <= 3500)
                                {
                                    prima = 0.045;
                                    cmotor = costo * prima;
                                }
                                total = total + cmotor;

                                //Porcentaje cilindros
                                if (cbCilindraje.Text == "")
                                {
                                    MessageBox.Show("Debe indicar el cilindraje del vehículo");
                                }
                                else
                                {
                                    if (cbCilindraje.Text == "2" || cbCilindraje.Text == "3")
                                    {
                                        ccilindros = costo * 0.04;
                                    }
                                    if (cbCilindraje.Text == "4" || cbCilindraje.Text == "5")
                                    {
                                        ccilindros = costo * 0.08;
                                    }
                                    if (cbCilindraje.Text == "6" || cbCilindraje.Text == "7")
                                    {
                                        ccilindros = costo * 0.12;
                                    }
                                    if (cbCilindraje.Text == "8")
                                    {
                                        ccilindros = costo * 0.16;
                                    }

                                    total = total + ccilindros;
                                    label13.Text = "Q." + total;
                                    label13.Visible = true;
                                    label12.Visible = true;
                                  
                                }
                            }
                        }
                    }
                }
            }
            //insercion de datos a la db
            VehiculoModel v1 = new VehiculoModel();

            v1.Nombre_Dueño_Vehiculo = txtdueño.Text;
            v1.Nombre_Responsable_Vehiculo = txtresponsable.Text;
            v1.Modelo = cbModelo.Text;
            v1.Placa = txtPlaca.Text;
            v1.Status = txtPlaca.Text;
            v1.Tipo_Vehiculo = cbTipo.Text;
            v1.Marca = cbMarca.Text;
            v1.Linea = txtLinea.Text;
            v1.Color = txtColor.Text;
            v1.Motor = txtMotor.Text;
            v1.Transmision = cbTrans.Text;
            v1.Numero_Llantas = cbLlantas.Text;
            v1.Cilindraje = cbCilindraje.Text;
            v1.Costo = txtCosto.Text;
            v1.usuario = label14.Text;


            VehiculoReader reader = new VehiculoReader(QueryRepo.TipoQuery.AddRow, v1);
            Collection<VehiculoModel> people = reader.Execute();

            txtCosto.Text = "";
            cbModelo.Text = "";
            txtPlaca.Text = "";
            cbStatus.Text = "";
            cbTipo.Text = "";
            cbMarca.Text = "";
            txtLinea.Text = "";
            txtColor.Text = "";
            txtMotor.Text = "";
            cbTrans.Text = "";
            cbLlantas.Text = "";
            cbCilindraje.Text = "";
            txtdueño.Text = "";
            txtresponsable.Text = "";
            MessageBox.Show("Total a Pagar:  Q.  " +total );
        }

        private void txtMotor_TextChanged(object sender, EventArgs e)
        { 
            //int motor;
            //motor = Convert.ToInt32(txtMotor.Text);

            //if (motor > 3500)
            //{
            //    MessageBox.Show("El numero maximo de motor es 3500");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HistorialForm his = new HistorialForm();
            his.Show();
        }
    }
}
