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
    public partial class FacturaDeCompra : Form
    {
        public FacturaDeCompra()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {
            DataSourceUpdateMode ds = new DataSourceUpdateMode();

        }

        private void FacturaDeCompra_Load(object sender, EventArgs e)
        {
            ParcialDataContext objConexion = new ParcialDataContext();
            //Consulta a la base de datos
            var consulta = from c in objConexion.Clientes select new { Nombres = c.Nombres + " " + c.Apellidos, c.IdClientePk };
            cmbCliente.DataSource = consulta.ToList();
            cmbCliente.DisplayMember = "Nombres";
            cmbCliente.ValueMember = "IdClientePk";

            //Consulta a la base de datos
            var consulta1 = from c in objConexion.Establecimiento select c;
            cmbNomEst.DataSource = consulta1.ToList();
            cmbNomEst.DisplayMember = "Nombre";
            cmbNomEst.ValueMember = "IdEstablecimientoPk";

            //Consulta a la base de datos
            var consulta2 = from c in objConexion.Producto select c;
            cmbProd.DataSource = consulta2.ToList();
            cmbProd.DisplayMember = "Nombre";
            cmbProd.ValueMember = "IdProductoPk";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)

        {

            ParcialDataContext pdc = new ParcialDataContext();
            //Trae fecha actual
            string fechaActual = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            DateTime dt = Convert.ToDateTime(fechaActual);

            double total = 0;
            double iva = 0.16;

            total = int.Parse(txtPreVen.Text) * int.Parse(txtCant.Text) ;
            total = (total * iva) + total;
            var consulta = from u in pdc.Usuarios where u.usuario == ClsSesion.usuario select u;
            
            int usuario = 0;

            foreach (var item in consulta)
            {
                usuario = int.Parse(item.IdUsuarioPk.ToString());
            }
            try
            {
                pdc.registrarFactura(dt, (int) total, usuario, int.Parse(cmbCliente.SelectedValue.ToString()), int.Parse(cmbNomEst.SelectedValue.ToString()));
                int consulta1 = pdc.Factura.Max(id => id.IdFacturaPk);
                pdc.registrarDetalleFactura(int.Parse(consulta1.ToString()), int.Parse(cmbProd.SelectedValue.ToString()), int.Parse(txtCant.Text), int.Parse(txtValPar.Text), int.Parse(txtPreVen.Text));
                MessageBox.Show("Registro exitoso", "Registro de venta");
                MessageBox.Show("No Factura :" + consulta1.ToString() + "\r" + "Rut Establecimiento : " + cmbNomEst.SelectedValue.ToString()
                    + "\r" + " Nombre del establecimiento :" + cmbNomEst.Text + "\r" + " Identificación comprador : " + cmbCliente.SelectedValue.ToString()
                    + "\r" + " Fecha y hora de la compra : " + fechaActual.ToString() + "\r" + "Código Producto " + cmbProd.SelectedValue.ToString() + "\r"
                    + "Nombre Producto " + cmbProd.Text + "\r" + "Precio de venta " + txtPreVen.Text + "\r" + "Iva : 16%" + "\r" + "Valor Total " + total.ToString() + "\r"
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registro no exitoso " + ex.Message,"Registro de venta");
                         }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            

        }
    }
}
