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
    public partial class VentanaNuevoCliente : Form
    {
        //referencia a la ventana del formulario anterior
        VentanaPrincipal principal = Application.OpenForms.OfType<VentanaPrincipal>().FirstOrDefault();

        private string nombre;
        private string apellido;
        private int dni;

        public VentanaNuevoCliente()
        {
            InitializeComponent();

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Point posicionForm = this.Location;
            principal.Location = posicionForm;
            principal.Show();
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            nombre = tbC1.Text; 
            apellido = tbC2.Text;
            if(nombre == "" || apellido == "")
            {
                MessageBox.Show("ERROR, Ingrese Nombre o Apellido");
            }else{
                if (tbC3.Text.Length == 8 && int.TryParse(tbC3.Text, out int numero))
                {
                    // El valor ingresado es un número entero de 8 dígitos
                    dni = int.Parse(tbC3.Text);
                    Point posicionForm = this.Location;
                    principal.Location = posicionForm;
                    principal.Show();
                    principal.AgregarCliente(nombre, apellido, dni);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ERROR Reingrese DNI");
                }
            }

        }
    }
}
