using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class VentanaAdministrarCuentas : Form
    {
        private VentanaPrincipal principal = Application.OpenForms.OfType<VentanaPrincipal>().FirstOrDefault();

        public VentanaAdministrarCuentas()
        {
            InitializeComponent();
            DesactivarBuscarCuenta();
            DescativarListaCuentas();
            IniciodeVentana();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Point posicionForm = this.Location;
            principal.Location = posicionForm;
            this.Close();
            principal.Show();
        }

        private void btBuscarCuenta_Click(object sender, EventArgs e)
        {
            DescativarListaCuentas();
            ActivarBuscarCuenta();
        }
        private void btListarCuentas_Click(object sender, EventArgs e)
        {
            DesactivarBuscarCuenta();
            ActivarListarCuentas();
        }
        public void Listar()
        {
            IReadOnlyList<Cuenta> cuentas = principal.AllCuentas();
            Tabla.DataSource = cuentas;
            Tabla.Columns["NumerodeCuenta"].Visible = false;
            Tabla.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        //metodos 
        private void IniciodeVentana()
        {
            tbSaldo.Enabled = false;
            tbTitular.Enabled = false;
        }
        private void DesactivarBuscarCuenta()
        {
            text1.Visible = false;
            text2.Visible = false;
            text4.Visible = false;
            btBuscar.Visible = false;
            tbNCuenta.Visible = false;  
            tbSaldo.Visible = false;
            tbTitular.Visible = false;
        }
        private void ActivarBuscarCuenta()
        {
            text1.Visible = true;
            text2.Visible = true;
            text4.Visible = true;
            btBuscar.Visible = true;
            tbNCuenta.Visible = true;
            tbSaldo.Visible = true;
            tbTitular.Visible = true;
        }
        private void CargarDatosCuenta(Cuenta cuenta)
        {
            tbTitular.Text = cuenta.Titular.ToString();
            tbSaldo.Text = cuenta.Saldo.ToString();
        }
        private void DescativarListaCuentas()
        {
            Tabla.Visible = false;
        }
        private void ActivarListarCuentas()
        {
            Tabla.Visible = true;
            Listar();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            Cuenta encontarda = null;
            tbSaldo.Clear();
            tbTitular.Clear();

            if (tbNCuenta.Text.Length != 13 || int.TryParse(tbNCuenta.Text, out int numero))
            {
                MessageBox.Show("ERROR, Reingrese el numero de Cuenta");
            }
            else
            {
                long Buscar = long.Parse(tbNCuenta.Text);
                IReadOnlyList<Cuenta> cuentas = principal.AllCuentas();
                foreach(Cuenta i in cuentas)
                {
                    if (i.NumeroCuenta == Buscar)
                    {
                        encontarda = i;
                        bandera = true;
                        break;
                    }
                }
                if (bandera ==  false)
                {
                    MessageBox.Show("No se encontro el Numero de cuenta Ingresado");
                }
                else
                {
                    CargarDatosCuenta(encontarda);
                }
            }
        }
    }
}
