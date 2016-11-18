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
    public partial class frmRegistrarProducto : Form
    {
        public frmRegistrarProducto()
        {
            InitializeComponent();
        }

        private void frmRegistrarProducto_Load(object sender, EventArgs e)
        {
            ParcialDataContext objConexion = new ParcialDataContext();
            var consulta = from p in objConexion.Proveedor select p;
            cmbProveedor.DataSource = consulta.ToList();
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "IdProveedorPk";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtProducto.Text.Equals("") && !txtPeso.Text.Equals("") && !txtValorCompra.Text.Equals("") && !txtUtilidadNeta.Text.Equals("") && !txtCantidad.Text.Equals(""))
                {
                    DateTime fechaFabricacion = Convert.ToDateTime(dtpFechaFabricacion.Value.ToString("yyyy/MM/dd"));
                    DateTime fechaCaducidad = Convert.ToDateTime(dtpFechaCaducidad.Value.ToString("yyyy/MM/dd"));
                    ParcialDataContext objConexion = new ParcialDataContext();
                    objConexion.insertarProducto(txtProducto.Text, int.Parse(cmbProveedor.SelectedValue.ToString()), fechaFabricacion, fechaCaducidad, int.Parse(txtPeso.Text), int.Parse(txtValorCompra.Text), int.Parse(txtUtilidadNeta.Text), int.Parse(txtCantidad.Text));
                    MessageBox.Show("Se registro exitosamente el producto", "Registro Producto");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Se deben llenar todos los campos","Error");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se registro exitosamente el producto " + ex.Message, "Registro Producto");

            }
        }

        public void limpiar()
        {
            txtProducto.ResetText();
            txtPeso.ResetText();
            txtValorCompra.ResetText();
            txtUtilidadNeta.ResetText();
            txtCantidad.ResetText();
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtValorCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtUtilidadNeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lblProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
