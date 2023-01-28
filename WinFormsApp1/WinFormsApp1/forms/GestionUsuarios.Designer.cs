namespace WinFormsApp1
{
    partial class GestionUsuarios
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
            this.listUsuarios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_tarjeta = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btbAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listUsuarios
            // 
            this.listUsuarios.FormattingEnabled = true;
            this.listUsuarios.ItemHeight = 15;
            this.listUsuarios.Location = new System.Drawing.Point(12, 12);
            this.listUsuarios.Name = "listUsuarios";
            this.listUsuarios.Size = new System.Drawing.Size(264, 334);
            this.listUsuarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(471, 308);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 2;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(447, 27);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(171, 23);
            this.txt_nombre.TabIndex = 3;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(201, 352);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefono";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tarjeta de credito";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(447, 81);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(171, 23);
            this.txt_apellido.TabIndex = 8;
            // 
            // txt_tarjeta
            // 
            this.txt_tarjeta.Location = new System.Drawing.Point(390, 243);
            this.txt_tarjeta.Name = "txt_tarjeta";
            this.txt_tarjeta.Size = new System.Drawing.Size(228, 23);
            this.txt_tarjeta.TabIndex = 9;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(447, 147);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(171, 23);
            this.txt_telefono.TabIndex = 10;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(120, 352);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 13;
            // 
            // btbAgregar
            // 
            this.btbAgregar.Location = new System.Drawing.Point(39, 352);
            this.btbAgregar.Name = "btbAgregar";
            this.btbAgregar.Size = new System.Drawing.Size(75, 23);
            this.btbAgregar.TabIndex = 14;
            this.btbAgregar.Text = "Agregar";
            this.btbAgregar.UseVisualStyleBackColor = true;
            this.btbAgregar.Click += new System.EventHandler(this.btbAgregar_Click);
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btbAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_tarjeta);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listUsuarios);
            this.Name = "GestionUsuarios";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.GestionUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listUsuarios;
        private Label label1;
        private Button btn_guardar;
        private TextBox txt_nombre;
        private Button btn_eliminar;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_apellido;
        private TextBox txt_tarjeta;
        private TextBox txt_telefono;
        private Button btnEditar;
        private Label label5;
        private Label label6;
        private Button btbAgregar;
    }
}