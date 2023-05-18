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

        private void btVolver_Click(object sender, EventArgs e)
        {
            Point posicionForm = this.Location;
            principal.Location = posicionForm;
            principal.Show();
            this.Close();
        }

        private void boxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            int nCliente = boxClientes.SelectedIndex;
            IReadOnlyList<Cuenta> lista2 = principal.ListaCuentas(nCliente);
            Tabla.DataSource = lista2;
            Tabla.Columns["nCuentaySaldo"].Visible = false;
            Tabla.Columns["NumerodeCuenta"].Visible = false;
            Tabla.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

    }
}
