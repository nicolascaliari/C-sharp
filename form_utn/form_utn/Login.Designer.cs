namespace form_utn
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(320, 155);
            this.txt_password.Name = "txt_password";
            this.txt_password.PlaceholderText = "Ingrese password";
            this.txt_password.Size = new System.Drawing.Size(174, 23);
            this.txt_password.TabIndex = 0;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(320, 93);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PlaceholderText = "Ingrese nombre de usuario";
            this.txt_usuario.Size = new System.Drawing.Size(174, 23);
            this.txt_usuario.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.txt_password);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private TextBox txt_password;
        private TextBox txt_usuario;
    }
}