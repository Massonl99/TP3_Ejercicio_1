/*
 * Created by SharpDevelop.
 * User: PC-10
 * Date: 8/5/2023
 * Time: 08:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ejercicio1
{
	partial class VentanaPrincipal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btNuevoCliente;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.btNuevoCliente = new System.Windows.Forms.Button();
            this.btNuevaCuenta = new System.Windows.Forms.Button();
            this.btAgregarMovimiento = new System.Windows.Forms.Button();
            this.btConsultarSaldo = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btAdminCuentas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btNuevoCliente
            // 
            this.btNuevoCliente.Location = new System.Drawing.Point(17, 69);
            this.btNuevoCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btNuevoCliente.Name = "btNuevoCliente";
            this.btNuevoCliente.Size = new System.Drawing.Size(100, 50);
            this.btNuevoCliente.TabIndex = 0;
            this.btNuevoCliente.Text = "Nuevo Cliente";
            this.btNuevoCliente.UseVisualStyleBackColor = true;
            this.btNuevoCliente.Click += new System.EventHandler(this.NuevoClienteClick);
            // 
            // btNuevaCuenta
            // 
            this.btNuevaCuenta.Location = new System.Drawing.Point(149, 69);
            this.btNuevaCuenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btNuevaCuenta.Name = "btNuevaCuenta";
            this.btNuevaCuenta.Size = new System.Drawing.Size(100, 50);
            this.btNuevaCuenta.TabIndex = 8;
            this.btNuevaCuenta.Text = "Nueva Cuenta";
            this.btNuevaCuenta.UseVisualStyleBackColor = true;
            this.btNuevaCuenta.Click += new System.EventHandler(this.btNuevaCuenta_Click);
            // 
            // btAgregarMovimiento
            // 
            this.btAgregarMovimiento.Location = new System.Drawing.Point(281, 69);
            this.btAgregarMovimiento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btAgregarMovimiento.Name = "btAgregarMovimiento";
            this.btAgregarMovimiento.Size = new System.Drawing.Size(100, 50);
            this.btAgregarMovimiento.TabIndex = 9;
            this.btAgregarMovimiento.Text = "Agregar Movimiento";
            this.btAgregarMovimiento.UseVisualStyleBackColor = true;
            this.btAgregarMovimiento.Click += new System.EventHandler(this.btAgregarMovimiento_Click);
            // 
            // btConsultarSaldo
            // 
            this.btConsultarSaldo.Location = new System.Drawing.Point(149, 135);
            this.btConsultarSaldo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btConsultarSaldo.Name = "btConsultarSaldo";
            this.btConsultarSaldo.Size = new System.Drawing.Size(100, 50);
            this.btConsultarSaldo.TabIndex = 10;
            this.btConsultarSaldo.Text = "Consultar Saldo";
            this.btConsultarSaldo.UseVisualStyleBackColor = true;
            this.btConsultarSaldo.Click += new System.EventHandler(this.btConsultarSaldo_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(351, 259);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(100, 50);
            this.btSalir.TabIndex = 11;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btAdminCuentas
            // 
            this.btAdminCuentas.Location = new System.Drawing.Point(17, 135);
            this.btAdminCuentas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btAdminCuentas.Name = "btAdminCuentas";
            this.btAdminCuentas.Size = new System.Drawing.Size(100, 50);
            this.btAdminCuentas.TabIndex = 12;
            this.btAdminCuentas.Text = "Administrar Cuentas";
            this.btAdminCuentas.UseVisualStyleBackColor = true;
            this.btAdminCuentas.Click += new System.EventHandler(this.btAdminCuentas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "INICIO";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAdminCuentas);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btConsultarSaldo);
            this.Controls.Add(this.btAgregarMovimiento);
            this.Controls.Add(this.btNuevaCuenta);
            this.Controls.Add(this.btNuevoCliente);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "VentanaPrincipal";
            this.Text = "INICIO";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Button btNuevaCuenta;
        private System.Windows.Forms.Button btAgregarMovimiento;
        private System.Windows.Forms.Button btConsultarSaldo;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btAdminCuentas;
        private System.Windows.Forms.Label label1;
    }
}
