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
	public class Movimientos
	{
		private string concepto;
		private float cantidad;
		
		public Movimientos()
		{
		}
		public string Concepto{get{return concepto;}set{concepto = value;}}
		public float Cantidad{get{return cantidad;}set{cantidad=value;}}
	}
}
