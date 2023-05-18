using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ejercicio1
{
	public partial class VentanaPrincipal : Form
	{
		public int numeroClientes = 0;
		private List< Cliente> Clientes = new List<Cliente>();
		public VentanaPrincipal()
		{
			InitializeComponent();
			
		}
        void NuevoClienteClick(object sender, EventArgs e)
		{
			this.Hide();
			VentanaNuevoCliente ventanaCliente = new VentanaNuevoCliente();
			ventanaCliente.Show();
		}
        private void btSalir_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }
		public void AgregarCliente(string nombre,string apellido,int dni) {
			numeroClientes++;
			Clientes.Add(new Ejercicio1.Cliente());
			Clientes[numeroClientes - 1].DNI = dni;
			Clientes[numeroClientes - 1].Nombre = nombre;
			Clientes[numeroClientes - 1].Apellido = apellido;
		}
        private void btNuevaCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
			VentanaNuevaCuenta ventanaCuenta = new VentanaNuevaCuenta();
            ventanaCuenta.Show();
        }
        public IReadOnlyList<Cliente> ListaClientes
        {
            get { return Clientes.AsReadOnly(); }
        }
        public List<Cuenta> ListaCuentas(int nTotalCuentas)
        {
			List<Cuenta> listacuentas = Clientes[nTotalCuentas].Cuentas;
            return listacuentas; 
        }
        public void AgregarCuenta(int nCliente, long nCuenta)
		{
            Clientes[nCliente].totalCuentas++;
            int totaldeCuentas = Clientes[nCliente].totalCuentas;
			Clientes[nCliente].Cuentas.Add(new Ejercicio1.Cuenta());
            Clientes[nCliente].Cuentas[totaldeCuentas - 1].titular = Clientes[nCliente].NombreCompleto;
			Clientes[nCliente].Cuentas[totaldeCuentas - 1].NumeroCuenta = nCuenta;
		}
        public void AgregarMovimineto(int nCliente, int nCuenta,int saldo, int concepto)
        {
            Clientes[nCliente].Cuentas[nCuenta].numeroMovimientos++;
            int totalMove = Clientes[nCliente].Cuentas[nCuenta].numeroMovimientos-1;
            Clientes[nCliente].Cuentas[nCuenta].Move.Add(new Ejercicio1.Movimientos());
            if (concepto == 0)
            {
                Clientes[nCliente].Cuentas[nCuenta].Saldo += saldo;
                Clientes[nCliente].Cuentas[nCuenta].Move[totalMove].Concepto = "Ingreso";
            }
            else
            {
                Clientes[nCliente].Cuentas[nCuenta].Saldo -= saldo;
                Clientes[nCliente].Cuentas[nCuenta].Move[totalMove].Concepto = "Extraccion";
            }
            Clientes[nCliente].Cuentas[nCuenta].Move[totalMove].Cantidad = saldo;

        }
        private void btAgregarMovimiento_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaNuevoMovimiento ventanaMovimineto = new VentanaNuevoMovimiento();
            ventanaMovimineto.Show();
        }
        private void btConsultarSaldo_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaConsultarSaldo ventanaConsultarSaldo = new VentanaConsultarSaldo();
            ventanaConsultarSaldo.Show();
        }
        public float Saldo(int nCliente, int nCuenta)
        {
            return Clientes[nCliente].Cuentas[nCuenta].Saldo;
        }
        public IReadOnlyList<Cuenta> AllCuentas() {
            
            List<Cuenta> Cuentas2 = new List<Cuenta>();
            Cuentas2.Clear();
            foreach (Cliente i in Clientes)
            {
                foreach (Cuenta j in i.Cuentas)
                {
                    Cuentas2.Add(j);
                }
            }
            return Cuentas2.AsReadOnly();
        }
        private void btAdminCuentas_Click(object sender, EventArgs e)
        {
            VentanaAdministrarCuentas ventanaAdministrarCuentas = new VentanaAdministrarCuentas();  
            ventanaAdministrarCuentas.Show();
            this.Hide();
        }
    }
}
