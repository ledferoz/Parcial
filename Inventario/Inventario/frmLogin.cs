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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            ParcialDataContext objConexion = new ParcialDataContext();
            var resultado = from u in objConexion.iniciarSesion(txtUsuario.Text, txtContrasenia.Text) select u;
            int rol = 0;
            foreach (var item in resultado)
            {
                rol = int.Parse(item.Rol.ToString());
            }


            switch (rol)

            {
                case 0:
                    MessageBox.Show("Usuario y/o clave incorrectas");
                    break;
                case 1:
                    frmAdministrador formAdministrador = new frmAdministrador();
                    formAdministrador.Show();
                    this.Hide();
                    break;
                case 2:
                    frmVendedor formVendedor = new frmVendedor();
                    formVendedor.Show();
                    this.Hide();
                    break;

            }
        }
    }
}
