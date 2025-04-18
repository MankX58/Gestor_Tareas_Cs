namespace WindowsFormsApp1.views.tareas
{
    partial class Agregar_tarea
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
            this.LblTitlteTarea = new System.Windows.Forms.Label();
            this.LblNombreTarea = new System.Windows.Forms.Label();
            this.TxtTarea = new System.Windows.Forms.TextBox();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitlteTarea
            // 
            this.LblTitlteTarea.AutoSize = true;
            this.LblTitlteTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitlteTarea.Location = new System.Drawing.Point(62, 46);
            this.LblTitlteTarea.Name = "LblTitlteTarea";
            this.LblTitlteTarea.Size = new System.Drawing.Size(194, 25);
            this.LblTitlteTarea.TabIndex = 0;
            this.LblTitlteTarea.Text = "AGREGAR TAREA";
            this.LblTitlteTarea.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblNombreTarea
            // 
            this.LblNombreTarea.AutoSize = true;
            this.LblNombreTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreTarea.Location = new System.Drawing.Point(53, 89);
            this.LblNombreTarea.Name = "LblNombreTarea";
            this.LblNombreTarea.Size = new System.Drawing.Size(52, 15);
            this.LblNombreTarea.TabIndex = 1;
            this.LblNombreTarea.Text = "Nombre";
            this.LblNombreTarea.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TxtTarea
            // 
            this.TxtTarea.Location = new System.Drawing.Point(140, 89);
            this.TxtTarea.Name = "TxtTarea";
            this.TxtTarea.Size = new System.Drawing.Size(125, 20);
            this.TxtTarea.TabIndex = 2;
            // 
            // TxtDesc
            // 
            this.TxtDesc.Location = new System.Drawing.Point(140, 123);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(125, 20);
            this.TxtDesc.TabIndex = 4;
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.Location = new System.Drawing.Point(53, 123);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(72, 15);
            this.LblCategoria.TabIndex = 3;
            this.LblCategoria.Text = "Descripción";
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Location = new System.Drawing.Point(140, 161);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(125, 20);
            this.TxtCategoria.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha Limite";
            // 
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.Location = new System.Drawing.Point(140, 199);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(125, 20);
            this.dtpFechaLimite.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(115, 247);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Agregar_tarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 349);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpFechaLimite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDesc);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.TxtTarea);
            this.Controls.Add(this.LblNombreTarea);
            this.Controls.Add(this.LblTitlteTarea);
            this.Name = "Agregar_tarea";
            this.Text = "Agregar Tarea";
            this.Load += new System.EventHandler(this.Agregar_tarea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitlteTarea;
        private System.Windows.Forms.Label LblNombreTarea;
        private System.Windows.Forms.TextBox TxtTarea;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaLimite;
        private System.Windows.Forms.Button btnGuardar;
    }
}