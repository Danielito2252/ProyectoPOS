﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconAceptar_Click(object sender, EventArgs e)
        {
            //Instanciar el formulario principal
            frmInicio form = new frmInicio();   
            form.Show();

            //Ocultar ventana de login
            this.Hide();

            form.FormClosing += frm_closing;
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {

            this.Show();
          
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
