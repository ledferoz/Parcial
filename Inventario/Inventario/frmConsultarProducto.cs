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
    public partial class frmConsultarProducto : Form
    {
        public frmConsultarProducto()
        {
            InitializeComponent();
        }

        int indice;
        private void frmConsultarProducto_Load(object sender, EventArgs e)
        {
            consultar();
            ParcialDataContext objConexion = new ParcialDataContext();
            var proveedores = from p in objConexion.Proveedor select p;
            cmbProveedor.DataSource = proveedores.ToList();
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "IdProveedorPk";
        }

        public void consultar() {
            ParcialDataContext objConexion = new ParcialDataContext();
            var consulta = from p in objConexion.Producto join pr in objConexion.Proveedor on p.IdProveedorFk equals pr.IdProveedorPk select new { IdProducto = p.IdProductoPk, Producto = p.Nombre, Proveedor = pr.Nombre, p.FechaFabricacion, p.FechaCaducidad, p.PesoKilos, p.ValorCompra, p.UtilidadNeta, p.Cantidad };
            dgvProductos.DataSource = consulta.ToList();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvProductos.CurrentRow.Index;
            txtId.Text= dgvProductos.Rows[indice].Cells[0].Value.ToString();
            txtProducto.Text = dgvProductos.Rows[indice].Cells[1].Value.ToString();
            cmbProveedor.Text = dgvProductos.Rows[indice].Cells[2].Value.ToString();
            dtpFechaFabricacion.Text = dgvProductos.Rows[indice].Cells[3].Value.ToString();
            dtpFechaCaducidad.Text = dgvProductos.Rows[indice].Cells[4].Value.ToString();
            txtPeso.Text = dgvProductos.Rows[indice].Cells[5].Value.ToString();
            txtValorCompra.Text = dgvProductos.Rows[indice].Cells[6].Value.ToString();
            txtUtilidadNeta.Text = dgvProductos.Rows[indice].Cells[7].Value.ToString();
            txtCantidad.Text = dgvProductos.Rows[indice].Cells[8].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtId.Text.Equals(""))
                {
                    ParcialDataContext objConexion = new ParcialDataContext();
                    DateTime fechaFabricacion = Convert.ToDateTime(dtpFechaFabricacion.Value.ToString("yyyy/MM/dd"));
                    DateTime fechaCaducidad = Convert.ToDateTime(dtpFechaCaducidad.Value.ToString("yyyy/MM/dd"));
                    objConexion.actualizarProducto(int.Parse(txtId.Text), txtProducto.Text, int.Parse(cmbProveedor.SelectedValue.ToString()), fechaFabricacion, fechaCaducidad, int.Parse(txtPeso.Text), int.Parse(txtValorCompra.Text), int.Parse(txtUtilidadNeta.Text), int.Parse(txtCantidad.Text));
                    MessageBox.Show("Se actualizo exitosamente el producto", "Actualización Producto");
                    consultar();
                }
                else
                {
                    MessageBox.Show("Se debe seleccionar un producto","Error");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No actualizo exitosamente el producto "+ex.Message , "Actualización Producto");

            }
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
    }
}
