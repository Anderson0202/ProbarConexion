namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btMostrarDatos = new System.Windows.Forms.Button();
            this.tbVersion = new System.Windows.Forms.Label();
            this.tbEstadoConexion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btMostrarDatos
            // 
            this.btMostrarDatos.Location = new System.Drawing.Point(291, 299);
            this.btMostrarDatos.Name = "btMostrarDatos";
            this.btMostrarDatos.Size = new System.Drawing.Size(189, 25);
            this.btMostrarDatos.TabIndex = 0;
            this.btMostrarDatos.Text = "Mostrar Datos";
            this.btMostrarDatos.UseVisualStyleBackColor = true;
            this.btMostrarDatos.Click += new System.EventHandler(this.btMostrarDatos_Click);
            // 
            // tbVersion
            // 
            this.tbVersion.AutoSize = true;
            this.tbVersion.Location = new System.Drawing.Point(131, 100);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.Size = new System.Drawing.Size(35, 13);
            this.tbVersion.TabIndex = 1;
            this.tbVersion.Text = "label1";
            // 
            // tbEstadoConexion
            // 
            this.tbEstadoConexion.AutoSize = true;
            this.tbEstadoConexion.Location = new System.Drawing.Point(131, 160);
            this.tbEstadoConexion.Name = "tbEstadoConexion";
            this.tbEstadoConexion.Size = new System.Drawing.Size(35, 13);
            this.tbEstadoConexion.TabIndex = 2;
            this.tbEstadoConexion.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbEstadoConexion);
            this.Controls.Add(this.tbVersion);
            this.Controls.Add(this.btMostrarDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMostrarDatos;
        private System.Windows.Forms.Label tbVersion;
        private System.Windows.Forms.Label tbEstadoConexion;
    }
}

