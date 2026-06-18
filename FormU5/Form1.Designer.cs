namespace FormU5
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
            this.groupBoxArreglos = new System.Windows.Forms.GroupBox();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstCalificaciones = new System.Windows.Forms.ListBox();
            this.groupBoxArreglos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxArreglos
            // 
            this.groupBoxArreglos.Controls.Add(this.txtCalificacion);
            this.groupBoxArreglos.Controls.Add(this.btnAgregar);
            this.groupBoxArreglos.Controls.Add(this.lstCalificaciones);
            this.groupBoxArreglos.Controls.Add(this.lblCalificacion);
            this.groupBoxArreglos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxArreglos.Name = "groupBoxArreglos";
            this.groupBoxArreglos.Size = new System.Drawing.Size(776, 426);
            this.groupBoxArreglos.TabIndex = 0;
            this.groupBoxArreglos.TabStop = false;
            this.groupBoxArreglos.Text = "Control de calificaciones - Vectores";
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(329, 223);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(161, 20);
            this.lblCalificacion.TabIndex = 1;
            this.lblCalificacion.Text = "Introduce Calificacion";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(292, 260);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(244, 26);
            this.txtCalificacion.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(342, 327);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 53);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Guardar en arreglo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstCalificaciones
            // 
            this.lstCalificaciones.FormattingEnabled = true;
            this.lstCalificaciones.ItemHeight = 20;
            this.lstCalificaciones.Location = new System.Drawing.Point(217, 62);
            this.lstCalificaciones.Name = "lstCalificaciones";
            this.lstCalificaciones.Size = new System.Drawing.Size(384, 124);
            this.lstCalificaciones.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxArreglos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxArreglos.ResumeLayout(false);
            this.groupBoxArreglos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxArreglos;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstCalificaciones;
    }
}

