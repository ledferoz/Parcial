using System;
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
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
            this.Hide();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarProveedor formProveedor = new frmRegistrarProveedor();
            formProveedor.MdiParent = this;
            formProveedor.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarProveedor formProveedor = new frmConsultarProveedor();
            formProveedor.MdiParent = this;
            formProveedor.Show();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistrarProducto formProducto = new frmRegistrarProducto();
            formProducto.MdiParent = this;
            formProducto.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarProducto formProducto = new frmConsultarProducto();
            formProducto.MdiParent = this;
            formProducto.Show();
        }
    }
}
