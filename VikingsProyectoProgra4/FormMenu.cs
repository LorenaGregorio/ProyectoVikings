﻿using System;
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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNuevoUsuario nuevo = new FormNuevoUsuario();
            nuevo.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}