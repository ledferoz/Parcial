﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Linq;

namespace Inventario
{
    public partial class frmRegistrarProveedor : Form
    {
        public frmRegistrarProveedor()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                ParcialDataContext objConexion = new ParcialDataContext();
                objConexion.registrarProveedor(txtNombre.Text,txtDireccion.Text,txtTelefono.Text,txtEmail.Text);
                MessageBox.Show("Se ha registrado exitosamente el proveedor","Registro Proveedor");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha registrado exitosamente el proveedor"+ ex.Message, "Registro Proveedor");
            }
        }
    }
}
