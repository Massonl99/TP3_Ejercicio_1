namespace Ejercicio1
{
    partial class VentanaNuevoCliente
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
            this.labelT = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.tbC3 = new System.Windows.Forms.TextBox();
            this.labelC3 = new System.Windows.Forms.Label();
            this.tbC2 = new System.Windows.Forms.TextBox();
            this.labelC2 = new System.Windows.Forms.Label();
            this.tbC1 = new System.Windows.Forms.TextBox();
            this.labelC1 = new System.Windows.Forms.Label();
            this.btVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Font = new System.Drawing.Font("Unispace", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.Location = new System.Drawing.Point(12, 9);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(194, 28);
            this.labelT.TabIndex = 26;
            this.labelT.Text = "NUEVO CLIENTE\r\n";
            // 
            // btGuardar
            // 
            this.btGuardar.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(12, 286);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 25;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // tbC3
            // 
            this.tbC3.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbC3.Location = new System.Drawing.Point(158, 136);
            this.tbC3.Name = "tbC3";
            this.tbC3.Size = new System.Drawing.Size(210, 21);
            this.tbC3.TabIndex = 24;
            // 
            // labelC3
            // 
            this.labelC3.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC3.Location = new System.Drawing.Point(14, 136);
            this.labelC3.Name = "labelC3";
            this.labelC3.Size = new System.Drawing.Size(100, 23);
            this.labelC3.TabIndex = 23;
            this.labelC3.Text = "DNI";
            // 
            // tbC2
            // 
            this.tbC2.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbC2.Location = new System.Drawing.Point(158, 98);
            this.tbC2.Name = "tbC2";
            this.tbC2.Size = new System.Drawing.Size(210, 21);
            this.tbC2.TabIndex = 22;
            // 
            // labelC2
            // 
            this.labelC2.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC2.Location = new System.Drawing.Point(13, 98);
            this.labelC2.Name = "labelC2";
            this.labelC2.Size = new System.Drawing.Size(100, 23);
            this.labelC2.TabIndex = 21;
            this.labelC2.Text = "Apellido";
            // 
            // tbC1
            // 
            this.tbC1.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbC1.Location = new System.Drawing.Point(158, 61);
            this.tbC1.Name = "tbC1";
            this.tbC1.Size = new System.Drawing.Size(210, 21);
            this.tbC1.TabIndex = 20;
            // 
            // labelC1
            // 
            this.labelC1.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC1.Location = new System.Drawing.Point(14, 61);
            this.labelC1.Name = "labelC1";
            this.labelC1.Size = new System.Drawing.Size(100, 23);
            this.labelC1.TabIndex = 19;
            this.labelC1.Text = "Nombre";
            // 
            // btVolver
            // 
            this.btVolver.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(377, 286);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 23);
            this.btVolver.TabIndex = 27;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // VentanaNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.tbC3);
            this.Controls.Add(this.labelC3);
            this.Controls.Add(this.tbC2);
            this.Controls.Add(this.labelC2);
            this.Controls.Add(this.tbC1);
            this.Controls.Add(this.labelC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "VentanaNuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NUEVO CLIENTE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox tbC3;
        private System.Windows.Forms.Label labelC3;
        private System.Windows.Forms.TextBox tbC2;
        private System.Windows.Forms.Label labelC2;
        private System.Windows.Forms.TextBox tbC1;
        private System.Windows.Forms.Label labelC1;
        private System.Windows.Forms.Button btVolver;
    }
}