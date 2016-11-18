using System;
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

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void lblTtelefono_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistrarProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
