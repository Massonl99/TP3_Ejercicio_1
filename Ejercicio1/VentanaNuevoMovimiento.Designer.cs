namespace Ejercicio1
{
    partial class VentanaNuevoMovimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btVolver = new System.Windows.Forms.Button();
            this.labelT = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.labelC3 = new System.Windows.Forms.Label();
            this.labelC2 = new System.Windows.Forms.Label();
            this.labelC1 = new System.Windows.Forms.Label();
            this.boxClientes = new System.Windows.Forms.ComboBox();
            this.boxCuenta = new System.Windows.Forms.ComboBox();
            this.boxConcept = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(207, 211);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 23);
            this.btVolver.TabIndex = 36;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.Location = new System.Drawing.Point(12, 9);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(218, 25);
            this.labelT.TabIndex = 35;
            this.labelT.Text = "NUEVO MOVIMIENTO";
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(17, 211);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 34;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(120, 144);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(100, 20);
            this.tbMonto.TabIndex = 33;
            this.tbMonto.TextChanged += new System.EventHandler(this.tbMonto_TextChanged);
            // 
            // labelC3
            // 
            this.labelC3.Location = new System.Drawing.Point(14, 147);
            this.labelC3.Name = "labelC3";
            this.labelC3.Size = new System.Drawing.Size(100, 23);
            this.labelC3.TabIndex = 32;
            this.labelC3.Text = "Monto";
            this.labelC3.Click += new System.EventHandler(this.labelC3_Click);
            // 
            // labelC2
            // 
            this.labelC2.Location = new System.Drawing.Point(14, 67);
            this.labelC2.Name = "labelC2";
            this.labelC2.Size = new System.Drawing.Size(100, 23);
            this.labelC2.TabIndex = 30;
            this.labelC2.Text = "Cuenta";
            // 
            // labelC1
            // 
            this.labelC1.Location = new System.Drawing.Point(14, 40);
            this.labelC1.Name = "labelC1";
            this.labelC1.Size = new System.Drawing.Size(100, 23);
            this.labelC1.TabIndex = 28;
            this.labelC1.Text = "Titular";
            // 
            // boxClientes
            // 
            this.boxClientes.FormattingEnabled = true;
            this.boxClientes.Location = new System.Drawing.Point(120, 37);
            this.boxClientes.Name = "boxClientes";
            this.boxClientes.Size = new System.Drawing.Size(143, 21);
            this.boxClientes.TabIndex = 38;
            this.boxClientes.SelectedIndexChanged += new System.EventHandler(this.boxClientes_SelectedIndexChanged);
            // 
            // boxCuenta
            // 
            this.boxCuenta.FormattingEnabled = true;
            this.boxCuenta.Location = new System.Drawing.Point(120, 64);
            this.boxCuenta.Name = "boxCuenta";
            this.boxCuenta.Size = new System.Drawing.Size(143, 21);
            this.boxCuenta.TabIndex = 39;
            this.boxCuenta.SelectedIndexChanged += new System.EventHandler(this.boxCuenta_SelectedIndexChanged);
            // 
            // boxConcept
            // 
            this.boxConcept.FormattingEnabled = true;
            this.boxConcept.Items.AddRange(new object[] {
            "Ingreso de Dinero",
            "Retiro de Dinero"});
            this.boxConcept.Location = new System.Drawing.Point(120, 91);
            this.boxConcept.Name = "boxConcept";
            this.boxConcept.Size = new System.Drawing.Size(143, 21);
            this.boxConcept.TabIndex = 41;
            this.boxConcept.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tipo Transaccion";
            // 
            // tbSaldo
            // 
            this.tbSaldo.Location = new System.Drawing.Point(120, 118);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(100, 20);
            this.tbSaldo.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Saldo Disponible";
            // 
            // VentanaNuevoMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 246);
            this.Controls.Add(this.tbSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxConcept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxCuenta);
            this.Controls.Add(this.boxClientes);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.tbMonto);
            this.Controls.Add(this.labelC3);
            this.Controls.Add(this.labelC2);
            this.Controls.Add(this.labelC1);
            this.Name = "VentanaNuevoMovimiento";
            this.Text = "VentanaNuevoMovimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.Label labelC3;
        private System.Windows.Forms.Label labelC2;
        private System.Windows.Forms.Label labelC1;
        private System.Windows.Forms.ComboBox boxClientes;
        private System.Windows.Forms.ComboBox boxCuenta;
        private System.Windows.Forms.ComboBox boxConcept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.Label label2;
    }
}