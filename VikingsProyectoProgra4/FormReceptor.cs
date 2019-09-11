using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VikingsProyectoProgra4
{
    public partial class FormReceptor : Form
    {
        public FormReceptor()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int modelo = Convert.ToInt32(comboBox1.Text);

            if (modelo < 2014)
            {
                label12.Visible = true;
                label14.Visible = false;
                label15.Visible = false;
            }
            if (modelo > 2014 && modelo <= 2017)
            {
                label12.Visible = false;
                label14.Visible = true;
                label15.Visible = false;
            }
            if (modelo > 2017)
            {
                label12.Visible = false;
                label14.Visible = false;
                label15.Visible = true;
            }
        }
    }
}
