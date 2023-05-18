﻿using System;
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
	public class Cuenta
	{
		private long numeroCuenta;
		public string titular;
		private float saldo = 0;
		public List<Movimientos> Move = new List<Movimientos>();
		public int numeroMovimientos = 0;

		public int num = -1;

		public Cuenta()
		{
		}

		public long NumeroCuenta {
			get { return numeroCuenta; }
			set { numeroCuenta = value; }
		}

		public string nCuentaySaldo
		{
			get { return $"{numeroCuenta}\t\t|\t{saldo}";}
		}
		public string NumerodeCuenta
		{
			get { return numeroCuenta.ToString(); }
		}
		public float Saldo {
			get { return saldo; }
			set { saldo = value; } }
	}
} 

