namespace Ejercicio1
{
    partial class VentanaConsultarSaldo
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
            this.boxClientes = new System.Windows.Forms.ComboBox();
            this.labelT = new System.Windows.Forms.Label();
            this.labelC2 = new System.Windows.Forms.Label();
            this.labelC1 = new System.Windows.Forms.Label();
            this.btVolver = new System.Windows.Forms.Button();
            this.labelC3 = new System.Windows.Forms.Label();
            this.BoxListCuentas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // boxClientes
            // 
            this.boxClientes.FormattingEnabled = true;
            this.boxClientes.Location = new System.Drawing.Point(120, 37);
            this.boxClientes.Name = "boxClientes";
            this.boxClientes.Size = new System.Drawing.Size(156, 21);
            this.boxClientes.TabIndex = 43;
            this.boxClientes.SelectedIndexChanged += new System.EventHandler(this.boxClientes_SelectedIndexChanged);
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.Location = new System.Drawing.Point(12, 9);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(210, 25);
            this.labelT.TabIndex = 42;
            this.labelT.Text = "CONSULTAR SALDO";
            // 
            // labelC2
            // 
            this.labelC2.Location = new System.Drawing.Point(14, 67);
            this.labelC2.Name = "labelC2";
            this.labelC2.Size = new System.Drawing.Size(100, 23);
            this.labelC2.TabIndex = 41;
            this.labelC2.Text = "N° Cuenta";
            // 
            // labelC1
            // 
            this.labelC1.Location = new System.Drawing.Point(14, 40);
            this.labelC1.Name = "labelC1";
            this.labelC1.Size = new System.Drawing.Size(100, 23);
            this.labelC1.TabIndex = 40;
            this.labelC1.Text = "Titular";
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(201, 284);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 23);
            this.btVolver.TabIndex = 48;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // labelC3
            // 
            this.labelC3.Location = new System.Drawing.Point(198, 68);
            this.labelC3.Name = "labelC3";
            this.labelC3.Size = new System.Drawing.Size(59, 23);
            this.labelC3.TabIndex = 45;
            this.labelC3.Text = "Saldo";
            // 
            // BoxListCuentas
            // 
            this.BoxListCuentas.FormattingEnabled = true;
            this.BoxListCuentas.Location = new System.Drawing.Point(17, 94);
            this.BoxListCuentas.Name = "BoxListCuentas";
            this.BoxListCuentas.Size = new System.Drawing.Size(259, 173);
            this.BoxListCuentas.TabIndex = 49;
            // 
            // VentanaConsultarSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 319);
            this.Controls.Add(this.BoxListCuentas);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.labelC3);
            this.Controls.Add(this.boxClientes);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.labelC2);
            this.Controls.Add(this.labelC1);
            this.Name = "VentanaConsultarSaldo";
            this.Text = "VentanaConsultarSaldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox boxClientes;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Label labelC2;
        private System.Windows.Forms.Label labelC1;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Label labelC3;
        private System.Windows.Forms.ListBox BoxListCuentas;
    }
}