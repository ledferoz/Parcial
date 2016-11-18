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
    public partial class frmConsultarProveedor : Form
    {
        public frmConsultarProveedor()
        {
            InitializeComponent();
        }

        int indice;

        private void frmConsultarProveedor_Load(object sender, EventArgs e)
        {
            consultar();
        }

        public void consultar()
        {

            ParcialDataContext objOrm = new ParcialDataContext();
            var consulta = from p in objOrm.Proveedor select p;
            dgvProveedores.DataSource = consulta.ToList();
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvProveedores.CurrentRow.Index;
            txtId.Text = dgvProveedores.Rows[indice].Cells[0].Value.ToString();
            txtNombre.Text = dgvProveedores.Rows[indice].Cells[1].Value.ToString();
            txtDireccion.Text = dgvProveedores.Rows[indice].Cells[2].Value.ToString();
            txtTelefono.Text = dgvProveedores.Rows[indice].Cells[3].Value.ToString();
            txtEmail.Text = dgvProveedores.Rows[indice].Cells[4].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtId.Text.Equals(""))
                {
                    
                    ParcialDataContext objConexion = new ParcialDataContext();
                    objConexion.actualizarProveedor(int.Parse(txtId.Text), txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);
                    MessageBox.Show("Se actualizo exitosamente el proveedor", "Actualización Proveedor");
                    consultar();
                }
                else {

                    MessageBox.Show("Se debe seleccionar un proveedor", "Error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizo exitosamente el proveedor" + ex.Message, "Actualización Proveedor");

            }
        }
    }
}
