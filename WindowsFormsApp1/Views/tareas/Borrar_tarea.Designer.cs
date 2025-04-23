namespace WindowsFormsApp1.Views.tareas
{
    partial class Borrar_tarea
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
            this.components = new System.ComponentModel.Container();
            this.LblTitlteBorrarTarea = new System.Windows.Forms.Label();
            this.lblIDtarea = new System.Windows.Forms.Label();
            this.txtIDtarea = new System.Windows.Forms.TextBox();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.tareaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitlteBorrarTarea
            // 
            this.LblTitlteBorrarTarea.AutoSize = true;
            this.LblTitlteBorrarTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitlteBorrarTarea.Location = new System.Drawing.Point(136, 25);
            this.LblTitlteBorrarTarea.Name = "LblTitlteBorrarTarea";
            this.LblTitlteBorrarTarea.Size = new System.Drawing.Size(290, 25);
            this.LblTitlteBorrarTarea.TabIndex = 1;
            this.LblTitlteBorrarTarea.Text = "¿Qué tarea deseas eliminar?";
            this.LblTitlteBorrarTarea.Click += new System.EventHandler(this.LblTitlteBorrarTarea_Click);
            // 
            // lblIDtarea
            // 
            this.lblIDtarea.AutoSize = true;
            this.lblIDtarea.Location = new System.Drawing.Point(201, 70);
            this.lblIDtarea.Name = "lblIDtarea";
            this.lblIDtarea.Size = new System.Drawing.Size(74, 13);
            this.lblIDtarea.TabIndex = 2;
            this.lblIDtarea.Text = "ID de la tarea:";
            this.lblIDtarea.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIDtarea
            // 
            this.txtIDtarea.Location = new System.Drawing.Point(281, 67);
            this.txtIDtarea.Name = "txtIDtarea";
            this.txtIDtarea.Size = new System.Drawing.Size(100, 20);
            this.txtIDtarea.TabIndex = 3;
            this.txtIDtarea.TextChanged += new System.EventHandler(this.txtIDtarea_TextChanged);
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.Location = new System.Drawing.Point(281, 102);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTarea.TabIndex = 4;
            this.btnEliminarTarea.Text = "eliminar";
            this.btnEliminarTarea.UseVisualStyleBackColor = true;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // tareaBindingSource
            // 
            this.tareaBindingSource.DataSource = typeof(WindowsFormsApp1.Models.Tarea);
            // 
            // Borrar_tarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 352);
            this.Controls.Add(this.btnEliminarTarea);
            this.Controls.Add(this.txtIDtarea);
            this.Controls.Add(this.lblIDtarea);
            this.Controls.Add(this.LblTitlteBorrarTarea);
            this.Name = "Borrar_tarea";
            this.Text = "Borrar tarea";
            this.Load += new System.EventHandler(this.Borrar_tarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTitlteBorrarTarea;
        private System.Windows.Forms.Label lblIDtarea;
        private System.Windows.Forms.TextBox txtIDtarea;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.BindingSource tareaBindingSource;
    }
}