namespace Ejercicio1
{
    partial class VentanaAdministrarCuentas
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
            this.btListarCuentas = new System.Windows.Forms.Button();
            this.btBuscarCuenta = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.Label();
            this.tbNCuenta = new System.Windows.Forms.TextBox();
            this.tbTitular = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.Label();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.text4 = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.Tabla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(353, 284);
            this.btVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(88, 25);
            this.btVolver.TabIndex = 50;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Font = new System.Drawing.Font("Unispace", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.Location = new System.Drawing.Point(14, 10);
            this.labelT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(278, 28);
            this.labelT.TabIndex = 49;
            this.labelT.Text = "ADMINISTRAR CUENTAS";
            // 
            // btListarCuentas
            // 
            this.btListarCuentas.Location = new System.Drawing.Point(161, 41);
            this.btListarCuentas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btListarCuentas.Name = "btListarCuentas";
            this.btListarCuentas.Size = new System.Drawing.Size(131, 40);
            this.btListarCuentas.TabIndex = 51;
            this.btListarCuentas.Text = "Listar Cuentas";
            this.btListarCuentas.UseVisualStyleBackColor = true;
            this.btListarCuentas.Click += new System.EventHandler(this.btListarCuentas_Click);
            // 
            // btBuscarCuenta
            // 
            this.btBuscarCuenta.Location = new System.Drawing.Point(13, 41);
            this.btBuscarCuenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btBuscarCuenta.Name = "btBuscarCuenta";
            this.btBuscarCuenta.Size = new System.Drawing.Size(131, 40);
            this.btBuscarCuenta.TabIndex = 52;
            this.btBuscarCuenta.Text = "Buscar Cuenta";
            this.btBuscarCuenta.UseVisualStyleBackColor = true;
            this.btBuscarCuenta.Click += new System.EventHandler(this.btBuscarCuenta_Click);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Location = new System.Drawing.Point(20, 125);
            this.text1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(147, 14);
            this.text1.TabIndex = 53;
            this.text1.Text = "Ingrese N° de Cuenta";
            // 
            // tbNCuenta
            // 
            this.tbNCuenta.Location = new System.Drawing.Point(175, 122);
            this.tbNCuenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNCuenta.Name = "tbNCuenta";
            this.tbNCuenta.Size = new System.Drawing.Size(241, 21);
            this.tbNCuenta.TabIndex = 54;
            // 
            // tbTitular
            // 
            this.tbTitular.Location = new System.Drawing.Point(175, 172);
            this.tbTitular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTitular.Name = "tbTitular";
            this.tbTitular.Size = new System.Drawing.Size(241, 21);
            this.tbTitular.TabIndex = 56;
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Location = new System.Drawing.Point(20, 176);
            this.text2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(56, 14);
            this.text2.TabIndex = 55;
            this.text2.Text = "Titular";
            // 
            // tbSaldo
            // 
            this.tbSaldo.Location = new System.Drawing.Point(175, 200);
            this.tbSaldo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(241, 21);
            this.tbSaldo.TabIndex = 60;
            // 
            // text4
            // 
            this.text4.AutoSize = true;
            this.text4.Location = new System.Drawing.Point(20, 204);
            this.text4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(42, 14);
            this.text4.TabIndex = 59;
            this.text4.Text = "Saldo";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(13, 284);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(88, 25);
            this.btBuscar.TabIndex = 61;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // Tabla
            // 
            this.Tabla.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Location = new System.Drawing.Point(13, 87);
            this.Tabla.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(428, 183);
            this.Tabla.TabIndex = 67;
            // 
            // VentanaAdministrarCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tbSaldo);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.tbTitular);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.tbNCuenta);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.btBuscarCuenta);
            this.Controls.Add(this.btListarCuentas);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.labelT);
            this.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "VentanaAdministrarCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ADMINISTRADOR DE CUENTAS";
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Button btListarCuentas;
        private System.Windows.Forms.Button btBuscarCuenta;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.TextBox tbNCuenta;
        private System.Windows.Forms.TextBox tbTitular;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.Label text4;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridView Tabla;
    }
}