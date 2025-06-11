﻿namespace SVPresentation.Formularios
{
    partial class frmLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txbUsuario = new TextBox();
            txbContrasena = new TextBox();
            linkOlvideContrasena = new LinkLabel();
            btnSalir = new Button();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(58, 49, 69);
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 21.75F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 307);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Ventas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(284, 18);
            label2.Name = "label2";
            label2.Size = new Size(172, 37);
            label2.TabIndex = 1;
            label2.Text = "Iniciar Sesión";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(293, 77);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(293, 153);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Contraseña:";
            // 
            // txbUsuario
            // 
            txbUsuario.Location = new Point(293, 95);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(238, 23);
            txbUsuario.TabIndex = 4;
            // 
            // txbContrasena
            // 
            txbContrasena.Location = new Point(293, 171);
            txbContrasena.Name = "txbContrasena";
            txbContrasena.PasswordChar = '*';
            txbContrasena.Size = new Size(238, 23);
            txbContrasena.TabIndex = 5;
            // 
            // linkOlvideContrasena
            // 
            linkOlvideContrasena.AutoSize = true;
            linkOlvideContrasena.Location = new Point(412, 222);
            linkOlvideContrasena.Name = "linkOlvideContrasena";
            linkOlvideContrasena.Size = new Size(119, 15);
            linkOlvideContrasena.TabIndex = 6;
            linkOlvideContrasena.TabStop = true;
            linkOlvideContrasena.Text = "Olvidé mi contraseña";
            linkOlvideContrasena.LinkClicked += linkOlvideContrasena_LinkClicked;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.Red;
            btnSalir.Location = new Point(293, 262);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.White;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Location = new Point(456, 262);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 8;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(543, 307);
            Controls.Add(btnEntrar);
            Controls.Add(btnSalir);
            Controls.Add(linkOlvideContrasena);
            Controls.Add(txbContrasena);
            Controls.Add(txbUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txbUsuario;
        private TextBox txbContrasena;
        private LinkLabel linkOlvideContrasena;
        private Button btnSalir;
        private Button btnEntrar;
    }
}