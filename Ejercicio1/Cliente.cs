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

	public class Cliente
	{
		private int dni;
		private string nombre;
		private string apellido;
		public int totalCuentas = 0;
		
		public List< Cuenta> Cuentas = new List<Cuenta>();
		public int nTotalCuentas = 0;
		

		public Cliente()
		{
		}

		public int DNI {get{return dni;}set{dni=value;}}
		public string Nombre {get{return nombre;}set{nombre=value;}}
		public string Apellido {get{return apellido;}set{apellido=value;}}
        public string NombreCompleto
        {
            get { return $"{Apellido}, {nombre}"; }
        }
    }
}
