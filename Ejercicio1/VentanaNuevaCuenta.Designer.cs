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
            this.btVolver.Location = new System.Drawing.Point(221, 150);
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
            this.labelT.Location = new System.Drawing.Point(26, 0);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(171, 25);
            this.labelT.TabIndex = 35;
            this.labelT.Text = "NUEVO CUENTA";
            // 
            // btCrear
            // 
            this.btCrear.Location = new System.Drawing.Point(31, 150);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(75, 23);
            this.btCrear.TabIndex = 34;
            this.btCrear.Text = "Crear";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // tbC1
            // 
            this.tbC1.Location = new System.Drawing.Point(134, 91);
            this.tbC1.Name = "tbC1";
            this.tbC1.Size = new System.Drawing.Size(121, 20);
            this.tbC1.TabIndex = 29;
            // 
            // labelC1
            // 
            this.labelC1.Location = new System.Drawing.Point(28, 36);
            this.labelC1.Name = "labelC1";
            this.labelC1.Size = new System.Drawing.Size(100, 23);
            this.labelC1.TabIndex = 28;
            this.labelC1.Text = "Seleccione Cliente";
            // 
            // boxClientes
            // 
            this.boxClientes.FormattingEnabled = true;
            this.boxClientes.Location = new System.Drawing.Point(134, 36);
            this.boxClientes.Name = "boxClientes";
            this.boxClientes.Size = new System.Drawing.Size(121, 21);
            this.boxClientes.TabIndex = 37;
            this.boxClientes.SelectedIndexChanged += new System.EventHandler(this.boxClientes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Datos ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "N° Cuenta";
            // 
            // VentanaNuevaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 194);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxClientes);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.tbC1);
            this.Controls.Add(this.labelC1);
            this.Name = "VentanaNuevaCuenta";
            this.Text = "VentanaNuevaCuenta";
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