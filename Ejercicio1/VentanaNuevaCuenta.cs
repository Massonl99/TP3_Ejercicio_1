using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio1
{
    public partial class VentanaNuevaCuenta : Form
    {
        VentanaPrincipal principal = Application.OpenForms.OfType<VentanaPrincipal>().FirstOrDefault();

        private long nCuenta;

        public VentanaNuevaCuenta()
        {
            InitializeComponent();
            GenerarNumerodeCuenta();
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
        private void GenerarNumerodeCuenta()
        {
            Random random = new Random();
            nCuenta= random.Next(1,9);
            for (int i = 0; i < 12; i++)
            {
                nCuenta = nCuenta * 10 + random.Next(0, 9);
            }

            tbC1.Enabled = false;
            tbC1.Text = nCuenta.ToString();
        }

        private void boxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //deberia cargar las cuentas
        }
        private void boxClientes_MouseEnter(object sender, EventArgs e)
        {
            // Acción a realizar cuando se hace clic en el ComboBox
            MessageBox.Show("Se hizo clic en el ComboBox.");
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Point posicionForm = this.Location;
            principal.Location = posicionForm;
            principal.Show();
            this.Close();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            if (boxClientes.SelectedIndex < 0)
            {
                // No hay ningún elemento seleccionado en el ComboBox
                MessageBox.Show("ERROR SELECCIONE UN CLIENTE");
            }
            else {
                principal.AgregarCuenta(boxClientes.SelectedIndex,nCuenta);
                principal.Show();
                this.Close();
            }

        }
    }
}
