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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
            this.Hide();
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarCliente formCliente = new frmRegistrarCliente();
            formCliente.MdiParent = this;
            formCliente.Show();
            
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarCliente formCliente = new frmConsultarCliente();
            formCliente.MdiParent = this;
            formCliente.Show();
        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {

        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturaDeCompra fac = new FacturaDeCompra();
            //Carga submenus
            fac.MdiParent = this;
            fac.Show();
        }
    }
}
