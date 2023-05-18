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

namespace Ejercicio1
{
    public partial class VentanaNuevoMovimiento : Form
    {
        VentanaPrincipal principal = Application.OpenForms.OfType<VentanaPrincipal>().FirstOrDefault();


        private int nCuenta = 0;
        private int nCliente = 0;
        private int concepto;
        private int monto = 0;

        public VentanaNuevoMovimiento()
        {
            InitializeComponent();
            CargarListaClientes();
            tbSaldo.Enabled = false;
            boxConcept.Text = "Tipo de Transaccion";
            boxCuenta.Enabled = false;
            boxConcept.Enabled = false;
            tbMonto.Enabled = false;
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
        private void cargarListaCuentas(int carga)
        {
            boxCuenta.Items.Clear();
            boxCuenta.Text = "Selecciones una Cuenta";
            IReadOnlyCollection<Cuenta> lista2 = principal.ListaCuentas(carga);
            foreach (Cuenta cuenta in lista2)
            {
                boxCuenta.Items.Add(cuenta);
            }
            boxCuenta.DisplayMember = "NumeroCuenta";
        }
        private void btVolver_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Close();
        }
        private void boxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            nCuenta = boxClientes.SelectedIndex;
            cargarListaCuentas(nCuenta);
            boxCuenta.Enabled = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nCuenta = boxCuenta.SelectedIndex;
            nCliente = boxClientes.SelectedIndex;
            if(nCliente >=0 && nCliente >= 0)
            {
                float saldo = principal.Saldo(nCliente, nCuenta);
                tbSaldo.Text = saldo.ToString();
            }
            tbMonto.Enabled = true;
        }
        private void btGuardar_Click(object sender, EventArgs e)
        {     
            nCuenta = boxCuenta.SelectedIndex;
            nCliente = boxClientes.SelectedIndex;
            if (nCuenta < 0 || nCliente < 0)
            {
                MessageBox.Show("ERROR, selecciones un cliente y una cuenta Valida");
            }
            else
            {
                float saldo = principal.Saldo(nCliente, nCuenta);
                if(tbMonto.Text == ""|| int.Parse(tbMonto.Text)<0)
                {
                    MessageBox.Show("ERROR, Monto no valido");
                }
                else
                {
                    monto = int.Parse(tbMonto.Text);
                    tbSaldo.Text = saldo.ToString();
                    if (saldo < monto && boxConcept.SelectedIndex == 1)
                    {
                        MessageBox.Show("ERROR Fondos Insuficientes");
                    }
                    else
                    {
                        concepto = boxConcept.SelectedIndex;
                        principal.AgregarMovimineto(nCliente, nCuenta, monto, concepto);
                        principal.Show();
                        this.Close();
                    }
                }

            }
        }
        private void tbMonto_TextChanged(object sender, EventArgs e)
        {

        }
        private void labelC3_Click(object sender, EventArgs e)
        {

        }
        private void boxCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxConcept.Enabled = true;
        }
    }
}
