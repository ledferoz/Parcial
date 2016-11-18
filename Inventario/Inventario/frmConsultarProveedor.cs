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

        private void frmConsultarProveedor_Load(object sender, EventArgs e)
        {
            consultar();
        }

        public void consultar()
        {
          
            ParcialDataContext objOrm = new ParcialDataContext();
            var consulta = from d in objOrm.Proveedor select d;
            dgvProveedores .DataSource = consulta.ToList();
        }
    }
}
