using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Ejercicio1
{
    public partial class VentanaConsultarSaldo : Form
    {
        VentanaPrincipal principal = Application.OpenForms.OfType<VentanaPrincipal>().FirstOrDefault();
        private int nCuenta ;
        private int nCliente ;

        public VentanaConsultarSaldo()
        {
            InitializeComponent();
            CargarListaClientes();

        }
        private void CargarListaClientes()
        {
            boxClientes.Items.Clear();
            boxClientes.Text = "Selecciones una Cliente";
            IReadOnlyList<Cliente> lista1 = principal.ListaClientes;

            foreach (Cliente cliente1 in lista1)
            {
                boxClientes.Items.Add(cliente1);
            }
            boxClientes.DisplayMember = "NombreCompleto";
        }
        /*private void cargarListaCuentas(int carga)
        {
            boxCuenta.Items.Clear();
            boxCuenta.Text = "Selecciones una Cuenta";
            
            foreach (Cuenta cuenta in lista2)
            {
                boxCuenta.Items.Add(cuenta);
            }
            boxCuenta.DisplayMember = "NumeroCuenta";
        }*/

        private void btVolver_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Close();
        }

        private void boxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nCliente = boxClientes.SelectedIndex;
            IReadOnlyList<Cuenta> lista2 = principal.ListaCuentas(nCliente);
            BoxListCuentas.Items.Clear();
            foreach (Cuenta i in lista2)
            {
                BoxListCuentas.Items.Add(i);
            }
            BoxListCuentas.DisplayMember = "nCuentaySaldo";
        }
    }
}
