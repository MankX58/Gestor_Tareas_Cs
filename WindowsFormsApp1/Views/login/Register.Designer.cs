namespace WindowsFormsApp1.views.login
{
    partial class Register
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
            this.LblPwd = new System.Windows.Forms.Label();
            this.LblConfirmPwd = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.TxtConfirmPwd = new System.Windows.Forms.TextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.lblErrorRegistro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(91, 33);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(43, 13);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Usuario";
            this.LblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblPwd
            // 
            this.LblPwd.AutoSize = true;
            this.LblPwd.Location = new System.Drawing.Point(73, 73);
            this.LblPwd.Name = "LblPwd";
            this.LblPwd.Size = new System.Drawing.Size(61, 13);
            this.LblPwd.TabIndex = 1;
            this.LblPwd.Text = "Contraseña";
            this.LblPwd.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LblConfirmPwd
            // 
            this.LblConfirmPwd.AutoSize = true;
            this.LblConfirmPwd.Location = new System.Drawing.Point(26, 116);
            this.LblConfirmPwd.Name = "LblConfirmPwd";
            this.LblConfirmPwd.Size = new System.Drawing.Size(108, 13);
            this.LblConfirmPwd.TabIndex = 2;
            this.LblConfirmPwd.Text = "Confirmar Contraseña";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(159, 30);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(169, 20);
            this.TxtUsuario.TabIndex = 3;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // TxtPwd
            // 
            this.TxtPwd.Location = new System.Drawing.Point(159, 70);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.PasswordChar = '*';
            this.TxtPwd.Size = new System.Drawing.Size(169, 20);
            this.TxtPwd.TabIndex = 4;
            // 
            // TxtConfirmPwd
            // 
            this.TxtConfirmPwd.Location = new System.Drawing.Point(159, 113);
            this.TxtConfirmPwd.Name = "TxtConfirmPwd";
            this.TxtConfirmPwd.PasswordChar = '*';
            this.TxtConfirmPwd.Size = new System.Drawing.Size(169, 20);
            this.TxtConfirmPwd.TabIndex = 5;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(146, 160);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(91, 29);
            this.BtnRegister.TabIndex = 6;
            this.BtnRegister.Text = "Registrarse";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblErrorRegistro
            // 
            this.lblErrorRegistro.AutoSize = true;
            this.lblErrorRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRegistro.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRegistro.Location = new System.Drawing.Point(145, 194);
            this.lblErrorRegistro.Name = "lblErrorRegistro";
            this.lblErrorRegistro.Size = new System.Drawing.Size(0, 15);
            this.lblErrorRegistro.TabIndex = 7;
            this.lblErrorRegistro.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 265);
            this.Controls.Add(this.lblErrorRegistro);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.TxtConfirmPwd);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblConfirmPwd);
            this.Controls.Add(this.LblPwd);
            this.Controls.Add(this.LblUsuario);
            this.Name = "Register";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblPwd;
        private System.Windows.Forms.Label LblConfirmPwd;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtPwd;
        private System.Windows.Forms.TextBox TxtConfirmPwd;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label lblErrorRegistro;
    }
}