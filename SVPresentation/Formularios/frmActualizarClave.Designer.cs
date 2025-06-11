﻿namespace SVPresentation.Formularios
{
    partial class frmActualizarClave
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
            txbClave = new TextBox();
            txbRepetirClave = new TextBox();
            lblValidacion = new Label();
            btnVolver = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 6);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 65);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Repetir Contraseña:";
            // 
            // txbClave
            // 
            txbClave.Location = new Point(22, 24);
            txbClave.Name = "txbClave";
            txbClave.PasswordChar = '*';
            txbClave.Size = new Size(216, 23);
            txbClave.TabIndex = 2;
            // 
            // txbRepetirClave
            // 
            txbRepetirClave.Location = new Point(22, 83);
            txbRepetirClave.Name = "txbRepetirClave";
            txbRepetirClave.PasswordChar = '*';
            txbRepetirClave.Size = new Size(216, 23);
            txbRepetirClave.TabIndex = 3;
            // 
            // lblValidacion
            // 
            lblValidacion.AutoSize = true;
            lblValidacion.ForeColor = Color.Red;
            lblValidacion.Location = new Point(24, 118);
            lblValidacion.Name = "lblValidacion";
            lblValidacion.Size = new Size(162, 15);
            lblValidacion.TabIndex = 4;
            lblValidacion.Text = "Las contraseñas no coinciden";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.White;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(22, 144);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.Blue;
            btnGuardar.Location = new Point(163, 144);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmActualizarClave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 179);
            Controls.Add(btnGuardar);
            Controls.Add(btnVolver);
            Controls.Add(lblValidacion);
            Controls.Add(txbRepetirClave);
            Controls.Add(txbClave);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(284, 218);
            MinimizeBox = false;
            MinimumSize = new Size(284, 218);
            Name = "frmActualizarClave";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar";
            Load += frmActualizarClave_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbClave;
        private TextBox txbRepetirClave;
        private Label lblValidacion;
        private Button btnVolver;
        private Button btnGuardar;
    }
}