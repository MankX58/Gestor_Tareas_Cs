namespace WindowsFormsApp1
{
    partial class Sesion
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
            this.LblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.lblErrorIngreso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(55, 42);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(43, 13);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Usuario";
            this.LblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(55, 93);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(61, 13);
            this.lblContrasena.TabIndex = 1;
            this.lblContrasena.Text = "Contraseña";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 3;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(140, 133);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(87, 31);
            this.BtnIngresar.TabIndex = 4;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // lblErrorIngreso
            // 
            this.lblErrorIngreso.AutoSize = true;
            this.lblErrorIngreso.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorIngreso.Location = new System.Drawing.Point(140, 177);
            this.lblErrorIngreso.Name = "lblErrorIngreso";
            this.lblErrorIngreso.Size = new System.Drawing.Size(0, 13);
            this.lblErrorIngreso.TabIndex = 5;
            // 
            // Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 210);
            this.Controls.Add(this.lblErrorIngreso);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.LblUsuario);
            this.Name = "Sesion";
            this.Text = "Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label lblErrorIngreso;
    }
}

