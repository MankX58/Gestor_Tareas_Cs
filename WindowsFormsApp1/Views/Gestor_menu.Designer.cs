namespace WindowsFormsApp1.Views
{
    partial class Gestor_menu
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.btnEditarTarea = new System.Windows.Forms.Button();
            this.btnBorrarTarea = new System.Windows.Forms.Button();
            this.btnVerTareas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(243, 27);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(189, 20);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "GESTOR DE TAREAS";
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.Location = new System.Drawing.Point(54, 79);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(156, 55);
            this.btnAgregarTarea.TabIndex = 1;
            this.btnAgregarTarea.Text = "AGREGAR TAREA";
            this.btnAgregarTarea.UseVisualStyleBackColor = true;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // btnEditarTarea
            // 
            this.btnEditarTarea.Location = new System.Drawing.Point(259, 79);
            this.btnEditarTarea.Name = "btnEditarTarea";
            this.btnEditarTarea.Size = new System.Drawing.Size(156, 55);
            this.btnEditarTarea.TabIndex = 2;
            this.btnEditarTarea.Text = "EDITAR TAREA";
            this.btnEditarTarea.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTarea
            // 
            this.btnBorrarTarea.Location = new System.Drawing.Point(454, 79);
            this.btnBorrarTarea.Name = "btnBorrarTarea";
            this.btnBorrarTarea.Size = new System.Drawing.Size(156, 55);
            this.btnBorrarTarea.TabIndex = 3;
            this.btnBorrarTarea.Text = "BORRAR TAREA";
            this.btnBorrarTarea.UseVisualStyleBackColor = true;
            this.btnBorrarTarea.Click += new System.EventHandler(this.btnBorrarTarea_Click);
            // 
            // btnVerTareas
            // 
            this.btnVerTareas.Location = new System.Drawing.Point(259, 176);
            this.btnVerTareas.Name = "btnVerTareas";
            this.btnVerTareas.Size = new System.Drawing.Size(156, 55);
            this.btnVerTareas.TabIndex = 4;
            this.btnVerTareas.Text = "VER TAREAS";
            this.btnVerTareas.UseVisualStyleBackColor = true;
            this.btnVerTareas.Click += new System.EventHandler(this.btnVerTareas_Click);
            // 
            // Gestor_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 320);
            this.Controls.Add(this.btnVerTareas);
            this.Controls.Add(this.btnBorrarTarea);
            this.Controls.Add(this.btnEditarTarea);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.LblTitulo);
            this.Name = "Gestor_menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.Button btnEditarTarea;
        private System.Windows.Forms.Button btnBorrarTarea;
        private System.Windows.Forms.Button btnVerTareas;
    }
}