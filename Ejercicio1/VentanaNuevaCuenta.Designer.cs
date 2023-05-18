namespace Ejercicio1
{
    partial class VentanaNuevaCuenta
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
            this.btCrear = new System.Windows.Forms.Button();
            this.tbC1 = new System.Windows.Forms.TextBox();
            this.labelC1 = new System.Windows.Forms.Label();
            this.boxClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btVolver
            // 
            this.btVolver.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(351, 284);
            this.btVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(100, 25);
            this.btVolver.TabIndex = 36;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Font = new System.Drawing.Font("Unispace", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.Location = new System.Drawing.Point(13, 9);
            this.labelT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(180, 28);
            this.labelT.TabIndex = 35;
            this.labelT.Text = "NUEVA CUENTA";
            // 
            // btCrear
            // 
            this.btCrear.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCrear.Location = new System.Drawing.Point(13, 284);
            this.btCrear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(100, 25);
            this.btCrear.TabIndex = 34;
            this.btCrear.Text = "Crear";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // tbC1
            // 
            this.tbC1.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbC1.Location = new System.Drawing.Point(183, 188);
            this.tbC1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbC1.Name = "tbC1";
            this.tbC1.Size = new System.Drawing.Size(190, 21);
            this.tbC1.TabIndex = 29;
            // 
            // labelC1
            // 
            this.labelC1.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC1.Location = new System.Drawing.Point(15, 64);
            this.labelC1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelC1.Name = "labelC1";
            this.labelC1.Size = new System.Drawing.Size(122, 44);
            this.labelC1.TabIndex = 28;
            this.labelC1.Text = "Seleccione Un Cliente";
            // 
            // boxClientes
            // 
            this.boxClientes.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxClientes.FormattingEnabled = true;
            this.boxClientes.Location = new System.Drawing.Point(183, 64);
            this.boxClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxClientes.Name = "boxClientes";
            this.boxClientes.Size = new System.Drawing.Size(190, 22);
            this.boxClientes.TabIndex = 37;
            this.boxClientes.SelectedIndexChanged += new System.EventHandler(this.boxClientes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Datos de la Cuenta";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "N° Cuenta";
            // 
            // VentanaNuevaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxClientes);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.tbC1);
            this.Controls.Add(this.labelC1);
            this.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "VentanaNuevaCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NUEVA CUENTA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.TextBox tbC1;
        private System.Windows.Forms.Label labelC1;
        private System.Windows.Forms.ComboBox boxClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}