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
            this.labelC1 = new System.Windows.Forms.Label();
            this.btVolver = new System.Windows.Forms.Button();
            this.Tabla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // boxClientes
            // 
            this.boxClientes.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxClientes.FormattingEnabled = true;
            this.boxClientes.Location = new System.Drawing.Point(151, 50);
            this.boxClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxClientes.Name = "boxClientes";
            this.boxClientes.Size = new System.Drawing.Size(296, 22);
            this.boxClientes.TabIndex = 43;
            this.boxClientes.SelectedIndexChanged += new System.EventHandler(this.boxClientes_SelectedIndexChanged);
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Font = new System.Drawing.Font("Unispace", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.Location = new System.Drawing.Point(14, 9);
            this.labelT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(222, 28);
            this.labelT.TabIndex = 42;
            this.labelT.Text = "CONSULTAR SALDO";
            // 
            // labelC1
            // 
            this.labelC1.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC1.Location = new System.Drawing.Point(16, 53);
            this.labelC1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelC1.Name = "labelC1";
            this.labelC1.Size = new System.Drawing.Size(117, 23);
            this.labelC1.TabIndex = 40;
            this.labelC1.Text = "Titular";
            // 
            // btVolver
            // 
            this.btVolver.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(351, 284);
            this.btVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(100, 25);
            this.btVolver.TabIndex = 48;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // Tabla
            // 
            this.Tabla.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Location = new System.Drawing.Point(19, 79);
            this.Tabla.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(428, 183);
            this.Tabla.TabIndex = 68;
            // 
            // VentanaConsultarSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.boxClientes);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.labelC1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "VentanaConsultarSaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CONSULTAR SALDO";
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox boxClientes;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Label labelC1;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.DataGridView Tabla;
    }
}