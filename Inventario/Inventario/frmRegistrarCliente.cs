using System;
using Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class frmRegistrarCliente : Form
    {
        public frmRegistrarCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNombre.Text.Equals("") && !txtApellido.Text.Equals("") && !txtDireccion.Text.Equals("") && !txtTelefono.Text.Equals(""))
                {
                    ParcialDataContext pdc = new ParcialDataContext();
                    pdc.InsertarCliente(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text);
                    MessageBox.Show("Se ha registrado exitosamente el cliente", "Registro Cliente");
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha registrado exitosamente el cliente" + ex.Message, "Registro Cliente");

            }
        }

        public void limpiar()
        {
            txtNombre.ResetText();
            txtApellido.ResetText();
            txtDireccion.ResetText();
            txtTelefono.ResetText();
        }
    }
}
