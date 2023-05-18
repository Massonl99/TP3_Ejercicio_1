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
            this.btVolver.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(363, 284);
            this.btVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(88, 25);
            this.btVolver.TabIndex = 36;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Font = new System.Drawing.Font("Unispace", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.Location = new System.Drawing.Point(14, 9);
            this.labelT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(236, 28);
            this.labelT.TabIndex = 35;
            this.labelT.Text = "NUEVO MOVIMIENTO";
            // 
            // btGuardar
            // 
            this.btGuardar.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(13, 284);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(88, 25);
            this.btGuardar.TabIndex = 34;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // tbMonto
            // 
            this.tbMonto.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMonto.Location = new System.Drawing.Point(166, 142);
            this.tbMonto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(116, 21);
            this.tbMonto.TabIndex = 33;
            this.tbMonto.TextChanged += new System.EventHandler(this.tbMonto_TextChanged);
            // 
            // labelC3
            // 
            this.labelC3.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC3.Location = new System.Drawing.Point(16, 142);
            this.labelC3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelC3.Name = "labelC3";
            this.labelC3.Size = new System.Drawing.Size(117, 25);
            this.labelC3.TabIndex = 32;
            this.labelC3.Text = "Monto ";
            this.labelC3.Click += new System.EventHandler(this.labelC3_Click);
            // 
            // labelC2
            // 
            this.labelC2.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC2.Location = new System.Drawing.Point(16, 86);
            this.labelC2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelC2.Name = "labelC2";
            this.labelC2.Size = new System.Drawing.Size(117, 25);
            this.labelC2.TabIndex = 30;
            this.labelC2.Text = "Cuenta";
            this.labelC2.Click += new System.EventHandler(this.labelC2_Click);
            // 
            // labelC1
            // 
            this.labelC1.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC1.Location = new System.Drawing.Point(16, 55);
            this.labelC1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelC1.Name = "labelC1";
            this.labelC1.Size = new System.Drawing.Size(117, 25);
            this.labelC1.TabIndex = 28;
            this.labelC1.Text = "Titular";
            // 
            // boxClientes
            // 
            this.boxClientes.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxClientes.FormattingEnabled = true;
            this.boxClientes.Location = new System.Drawing.Point(166, 58);
            this.boxClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxClientes.Name = "boxClientes";
            this.boxClientes.Size = new System.Drawing.Size(250, 22);
            this.boxClientes.TabIndex = 38;
            this.boxClientes.SelectedIndexChanged += new System.EventHandler(this.boxClientes_SelectedIndexChanged);
            // 
            // boxCuenta
            // 
            this.boxCuenta.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCuenta.FormattingEnabled = true;
            this.boxCuenta.Location = new System.Drawing.Point(166, 86);
            this.boxCuenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxCuenta.Name = "boxCuenta";
            this.boxCuenta.Size = new System.Drawing.Size(250, 22);
            this.boxCuenta.TabIndex = 39;
            this.boxCuenta.SelectedIndexChanged += new System.EventHandler(this.boxCuenta_SelectedIndexChanged);
            // 
            // boxConcept
            // 
            this.boxConcept.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxConcept.FormattingEnabled = true;
            this.boxConcept.Items.AddRange(new object[] {
            "Ingreso de Dinero",
            "Retiro de Dinero"});
            this.boxConcept.Location = new System.Drawing.Point(166, 114);
            this.boxConcept.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxConcept.Name = "boxConcept";
            this.boxConcept.Size = new System.Drawing.Size(250, 22);
            this.boxConcept.TabIndex = 41;
            this.boxConcept.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tipo Transaccion";
            // 
            // tbSaldo
            // 
            this.tbSaldo.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSaldo.Location = new System.Drawing.Point(166, 170);
            this.tbSaldo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(116, 21);
            this.tbSaldo.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Saldo Disponible";
            // 
            // VentanaNuevoMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(464, 321);
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
            this.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "VentanaNuevoMovimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NUEVO MOVIMIENTO";
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