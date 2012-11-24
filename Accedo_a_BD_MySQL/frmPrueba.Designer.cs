namespace Accedo_a_BD_MySQL
{
    partial class frmPrueba
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmdClientes = new System.Windows.Forms.Button();
            this.cmdProductos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevaVentana = new System.Windows.Forms.Button();
            this.lstDatos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(12, 386);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(592, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mensajes.............";
            // 
            // cmdClientes
            // 
            this.cmdClientes.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClientes.Location = new System.Drawing.Point(415, 50);
            this.cmdClientes.Name = "cmdClientes";
            this.cmdClientes.Size = new System.Drawing.Size(100, 25);
            this.cmdClientes.TabIndex = 1;
            this.cmdClientes.Text = "Clientes";
            this.cmdClientes.UseVisualStyleBackColor = true;
            this.cmdClientes.Click += new System.EventHandler(this.cmdClientes_Click);
            // 
            // cmdProductos
            // 
            this.cmdProductos.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProductos.Location = new System.Drawing.Point(415, 92);
            this.cmdProductos.Name = "cmdProductos";
            this.cmdProductos.Size = new System.Drawing.Size(100, 25);
            this.cmdProductos.TabIndex = 2;
            this.cmdProductos.Text = "Productos";
            this.cmdProductos.UseVisualStyleBackColor = true;
            this.cmdProductos.Click += new System.EventHandler(this.cmdProductos_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(445, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hecho por Gabriel Campo";
            // 
            // btnNuevaVentana
            // 
            this.btnNuevaVentana.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaVentana.Location = new System.Drawing.Point(415, 234);
            this.btnNuevaVentana.Name = "btnNuevaVentana";
            this.btnNuevaVentana.Size = new System.Drawing.Size(100, 50);
            this.btnNuevaVentana.TabIndex = 5;
            this.btnNuevaVentana.Text = "Ver Ejemplo con Clases";
            this.btnNuevaVentana.UseVisualStyleBackColor = true;
            this.btnNuevaVentana.Click += new System.EventHandler(this.btnNuevaVentana_Click);
            // 
            // lstDatos
            // 
            this.lstDatos.BackColor = System.Drawing.Color.Black;
            this.lstDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lstDatos.Location = new System.Drawing.Point(12, 12);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(397, 371);
            this.lstDatos.TabIndex = 3;
            this.lstDatos.UseCompatibleStateImageBehavior = false;
            this.lstDatos.View = System.Windows.Forms.View.List;
            // 
            // frmPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(616, 433);
            this.Controls.Add(this.btnNuevaVentana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.cmdProductos);
            this.Controls.Add(this.cmdClientes);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Name = "frmPrueba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreacionesNea - Acceso a Base de Datos MySQL - Prueba sin uso de Clase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrueba_FormClosing);
            this.Load += new System.EventHandler(this.frmPrueba_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button cmdClientes;
        private System.Windows.Forms.Button cmdProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevaVentana;
        private System.Windows.Forms.ListView lstDatos;
    }
}

