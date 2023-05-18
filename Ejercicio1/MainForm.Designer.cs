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
            this.SuspendLayout();
            // 
            // btNuevoCliente
            // 
            this.btNuevoCliente.Location = new System.Drawing.Point(12, 12);
            this.btNuevoCliente.Name = "btNuevoCliente";
            this.btNuevoCliente.Size = new System.Drawing.Size(85, 23);
            this.btNuevoCliente.TabIndex = 0;
            this.btNuevoCliente.Text = "Nuevo Cliente";
            this.btNuevoCliente.UseVisualStyleBackColor = true;
            this.btNuevoCliente.Click += new System.EventHandler(this.NuevoClienteClick);
            // 
            // btNuevaCuenta
            // 
            this.btNuevaCuenta.Location = new System.Drawing.Point(128, 12);
            this.btNuevaCuenta.Name = "btNuevaCuenta";
            this.btNuevaCuenta.Size = new System.Drawing.Size(85, 23);
            this.btNuevaCuenta.TabIndex = 8;
            this.btNuevaCuenta.Text = "Nueva Cuenta";
            this.btNuevaCuenta.UseVisualStyleBackColor = true;
            this.btNuevaCuenta.Click += new System.EventHandler(this.btNuevaCuenta_Click);
            // 
            // btAgregarMovimiento
            // 
            this.btAgregarMovimiento.Location = new System.Drawing.Point(12, 41);
            this.btAgregarMovimiento.Name = "btAgregarMovimiento";
            this.btAgregarMovimiento.Size = new System.Drawing.Size(85, 35);
            this.btAgregarMovimiento.TabIndex = 9;
            this.btAgregarMovimiento.Text = "Agregar Movimiento";
            this.btAgregarMovimiento.UseVisualStyleBackColor = true;
            this.btAgregarMovimiento.Click += new System.EventHandler(this.btAgregarMovimiento_Click);
            // 
            // btConsultarSaldo
            // 
            this.btConsultarSaldo.Location = new System.Drawing.Point(128, 41);
            this.btConsultarSaldo.Name = "btConsultarSaldo";
            this.btConsultarSaldo.Size = new System.Drawing.Size(85, 35);
            this.btConsultarSaldo.TabIndex = 10;
            this.btConsultarSaldo.Text = "Consultar Saldo";
            this.btConsultarSaldo.UseVisualStyleBackColor = true;
            this.btConsultarSaldo.Click += new System.EventHandler(this.btConsultarSaldo_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(128, 121);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(85, 23);
            this.btSalir.TabIndex = 11;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 156);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btConsultarSaldo);
            this.Controls.Add(this.btAgregarMovimiento);
            this.Controls.Add(this.btNuevaCuenta);
            this.Controls.Add(this.btNuevoCliente);
            this.Name = "VentanaPrincipal";
            this.Text = "Ejercicio1";
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.Button btNuevaCuenta;
        private System.Windows.Forms.Button btAgregarMovimiento;
        private System.Windows.Forms.Button btConsultarSaldo;
        private System.Windows.Forms.Button btSalir;
    }
}
