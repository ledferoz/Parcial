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
    public partial class frmConsultarCliente : Form
    {
        public frmConsultarCliente()
        {
            InitializeComponent();
        }

        int indice;

        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {
            consultar();
        }

        public void consultar()
        {
            ParcialDataContext objConexion = new ParcialDataContext();
            var consulta = from c in objConexion.Clientes select c;
            dgvClientes.DataSource = consulta.ToList();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvClientes.CurrentRow.Index;
            txtId.Text = dgvClientes.Rows[indice].Cells[0].Value.ToString();
            txtNombre.Text = dgvClientes.Rows[indice].Cells[1].Value.ToString();
            txtApellido.Text = dgvClientes.Rows[indice].Cells[2].Value.ToString();
            txtDireccion.Text = dgvClientes.Rows[indice].Cells[3].Value.ToString();
            txtTelefono.Text = dgvClientes.Rows[indice].Cells[4].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtId.Text.Equals(""))
                {
                    ParcialDataContext objConexion = new ParcialDataContext();
                    objConexion.actualizarCliente(int.Parse(txtId.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text);
                    MessageBox.Show("Se ha actualizado exitosamente el cliente", "Actualización Cliente");
                    consultar();
                }
                else
                {
                    MessageBox.Show("Se debe seleccionar un cliente","Error");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha actualizado exitosamente el cliente "+ex.Message, "Actualización Cliente");
            }
        }
    }
}
