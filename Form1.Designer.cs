namespace pryValdezSP1
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
            this.btnCrearArc = new System.Windows.Forms.Button();
            this.btnGrabarArc = new System.Windows.Forms.Button();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearArc
            // 
            this.btnCrearArc.Location = new System.Drawing.Point(12, 305);
            this.btnCrearArc.Name = "btnCrearArc";
            this.btnCrearArc.Size = new System.Drawing.Size(116, 37);
            this.btnCrearArc.TabIndex = 0;
            this.btnCrearArc.Text = "Crear Archivo";
            this.btnCrearArc.UseVisualStyleBackColor = true;
            this.btnCrearArc.Click += new System.EventHandler(this.btnCrearArc_Click);
            // 
            // btnGrabarArc
            // 
            this.btnGrabarArc.Location = new System.Drawing.Point(150, 305);
            this.btnGrabarArc.Name = "btnGrabarArc";
            this.btnGrabarArc.Size = new System.Drawing.Size(116, 37);
            this.btnGrabarArc.TabIndex = 1;
            this.btnGrabarArc.Text = "Grabar Archivo";
            this.btnGrabarArc.UseVisualStyleBackColor = true;
            this.btnGrabarArc.Click += new System.EventHandler(this.btnGrabarArc_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(34, 27);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(348, 120);
            this.txtDatos.TabIndex = 2;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(298, 305);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(116, 37);
            this.btnLeer.TabIndex = 3;
            this.btnLeer.Text = "Leer Archivo";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 354);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.btnGrabarArc);
            this.Controls.Add(this.btnCrearArc);
            this.Name = "Form1";
            this.Text = "Manejo de Archivos y Carpetas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearArc;
        private System.Windows.Forms.Button btnGrabarArc;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Button btnLeer;
    }
}

