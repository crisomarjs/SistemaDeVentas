﻿namespace SVPresentation.Formularios
{
    partial class frmUsuario
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
            btnGuardarEditar = new Button();
            btnVolverEditar = new Button();
            btnGuardarNuevo = new Button();
            btnVolverNuevo = new Button();
            cbbRolNuevo = new ComboBox();
            label3 = new Label();
            txbNombreCompletoNuevo = new TextBox();
            label2 = new Label();
            btnNuevo = new Button();
            tabNuevo = new TabPage();
            txbNombreUsuarioNuevo = new TextBox();
            label8 = new Label();
            txbCorreoNuevo = new TextBox();
            label7 = new Label();
            dgvUsuarios = new DataGridView();
            btnBuscar = new Button();
            txbBuscar = new TextBox();
            bttnNuevo = new Button();
            tabControlMain = new TabControl();
            tabLista = new TabPage();
            tabEditar = new TabPage();
            txbNombreUsuarioEditar = new TextBox();
            label4 = new Label();
            txbCorreoEditar = new TextBox();
            label5 = new Label();
            cbbRolEditar = new ComboBox();
            label9 = new Label();
            txbNombreCompletoEditar = new TextBox();
            label10 = new Label();
            cbbHabilitado = new ComboBox();
            label6 = new Label();
            tabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            tabControlMain.SuspendLayout();
            tabLista.SuspendLayout();
            tabEditar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.BackColor = Color.White;
            btnGuardarEditar.Cursor = Cursors.Hand;
            btnGuardarEditar.FlatStyle = FlatStyle.Flat;
            btnGuardarEditar.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardarEditar.Location = new Point(633, 276);
            btnGuardarEditar.Name = "btnGuardarEditar";
            btnGuardarEditar.Size = new Size(75, 23);
            btnGuardarEditar.TabIndex = 12;
            btnGuardarEditar.Text = "Guardar";
            btnGuardarEditar.UseVisualStyleBackColor = false;
            btnGuardarEditar.Click += btnGuardarEditar_Click;
            // 
            // btnVolverEditar
            // 
            btnVolverEditar.BackColor = Color.White;
            btnVolverEditar.Cursor = Cursors.Hand;
            btnVolverEditar.FlatStyle = FlatStyle.Flat;
            btnVolverEditar.Location = new Point(21, 276);
            btnVolverEditar.Name = "btnVolverEditar";
            btnVolverEditar.Size = new Size(75, 23);
            btnVolverEditar.TabIndex = 11;
            btnVolverEditar.Text = "Volver";
            btnVolverEditar.UseVisualStyleBackColor = false;
            btnVolverEditar.Click += btnVolverEditar_Click;
            // 
            // btnGuardarNuevo
            // 
            btnGuardarNuevo.BackColor = Color.White;
            btnGuardarNuevo.Cursor = Cursors.Hand;
            btnGuardarNuevo.FlatStyle = FlatStyle.Flat;
            btnGuardarNuevo.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardarNuevo.Location = new Point(635, 276);
            btnGuardarNuevo.Name = "btnGuardarNuevo";
            btnGuardarNuevo.Size = new Size(75, 23);
            btnGuardarNuevo.TabIndex = 6;
            btnGuardarNuevo.Text = "Guardar";
            btnGuardarNuevo.UseVisualStyleBackColor = false;
            btnGuardarNuevo.Click += btnGuardarNuevo_Click;
            // 
            // btnVolverNuevo
            // 
            btnVolverNuevo.BackColor = Color.White;
            btnVolverNuevo.Cursor = Cursors.Hand;
            btnVolverNuevo.FlatStyle = FlatStyle.Flat;
            btnVolverNuevo.Location = new Point(23, 276);
            btnVolverNuevo.Name = "btnVolverNuevo";
            btnVolverNuevo.Size = new Size(75, 23);
            btnVolverNuevo.TabIndex = 5;
            btnVolverNuevo.Text = "Volver";
            btnVolverNuevo.UseVisualStyleBackColor = false;
            btnVolverNuevo.Click += btnVolverNuevo_Click;
            // 
            // cbbRolNuevo
            // 
            cbbRolNuevo.Cursor = Cursors.Hand;
            cbbRolNuevo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbRolNuevo.FormattingEnabled = true;
            cbbRolNuevo.Location = new Point(23, 22);
            cbbRolNuevo.Name = "cbbRolNuevo";
            cbbRolNuevo.Size = new Size(687, 23);
            cbbRolNuevo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 7);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 2;
            label3.Text = "Rol";
            // 
            // txbNombreCompletoNuevo
            // 
            txbNombreCompletoNuevo.Location = new Point(23, 69);
            txbNombreCompletoNuevo.Name = "txbNombreCompletoNuevo";
            txbNombreCompletoNuevo.Size = new Size(691, 23);
            txbNombreCompletoNuevo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 54);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre Completo:";
            // 
            // btnNuevo
            // 
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Location = new Point(12, 11);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(0, 0);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(txbNombreUsuarioNuevo);
            tabNuevo.Controls.Add(label8);
            tabNuevo.Controls.Add(txbCorreoNuevo);
            tabNuevo.Controls.Add(label7);
            tabNuevo.Controls.Add(btnGuardarNuevo);
            tabNuevo.Controls.Add(btnVolverNuevo);
            tabNuevo.Controls.Add(cbbRolNuevo);
            tabNuevo.Controls.Add(label3);
            tabNuevo.Controls.Add(txbNombreCompletoNuevo);
            tabNuevo.Controls.Add(label2);
            tabNuevo.Location = new Point(4, 24);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(732, 316);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            tabNuevo.UseVisualStyleBackColor = true;
            // 
            // txbNombreUsuarioNuevo
            // 
            txbNombreUsuarioNuevo.Location = new Point(26, 173);
            txbNombreUsuarioNuevo.Name = "txbNombreUsuarioNuevo";
            txbNombreUsuarioNuevo.Size = new Size(691, 23);
            txbNombreUsuarioNuevo.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 158);
            label8.Name = "label8";
            label8.Size = new Size(97, 15);
            label8.TabIndex = 9;
            label8.Text = "Nombre Usuario:";
            // 
            // txbCorreoNuevo
            // 
            txbCorreoNuevo.Location = new Point(23, 120);
            txbCorreoNuevo.Name = "txbCorreoNuevo";
            txbCorreoNuevo.Size = new Size(691, 23);
            txbCorreoNuevo.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 105);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 7;
            label7.Text = "Correo:";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(16, 52);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(700, 251);
            dgvUsuarios.TabIndex = 7;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(641, 15);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txbBuscar
            // 
            txbBuscar.Location = new Point(453, 19);
            txbBuscar.Name = "txbBuscar";
            txbBuscar.Size = new Size(176, 23);
            txbBuscar.TabIndex = 5;
            // 
            // bttnNuevo
            // 
            bttnNuevo.BackColor = Color.White;
            bttnNuevo.Cursor = Cursors.Hand;
            bttnNuevo.FlatStyle = FlatStyle.Flat;
            bttnNuevo.Location = new Point(16, 14);
            bttnNuevo.Name = "bttnNuevo";
            bttnNuevo.Size = new Size(75, 23);
            bttnNuevo.TabIndex = 4;
            bttnNuevo.Text = "Nuevo";
            bttnNuevo.UseVisualStyleBackColor = false;
            bttnNuevo.Click += bttnNuevo_Click;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabLista);
            tabControlMain.Controls.Add(tabNuevo);
            tabControlMain.Controls.Add(tabEditar);
            tabControlMain.ItemSize = new Size(80, 20);
            tabControlMain.Location = new Point(12, 47);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(740, 344);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 2;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(dgvUsuarios);
            tabLista.Controls.Add(btnBuscar);
            tabLista.Controls.Add(txbBuscar);
            tabLista.Controls.Add(bttnNuevo);
            tabLista.Location = new Point(4, 24);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3);
            tabLista.Size = new Size(732, 316);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(txbNombreUsuarioEditar);
            tabEditar.Controls.Add(label4);
            tabEditar.Controls.Add(txbCorreoEditar);
            tabEditar.Controls.Add(label5);
            tabEditar.Controls.Add(cbbRolEditar);
            tabEditar.Controls.Add(label9);
            tabEditar.Controls.Add(txbNombreCompletoEditar);
            tabEditar.Controls.Add(label10);
            tabEditar.Controls.Add(cbbHabilitado);
            tabEditar.Controls.Add(label6);
            tabEditar.Controls.Add(btnGuardarEditar);
            tabEditar.Controls.Add(btnVolverEditar);
            tabEditar.Controls.Add(btnNuevo);
            tabEditar.Location = new Point(4, 24);
            tabEditar.Name = "tabEditar";
            tabEditar.Padding = new Padding(3);
            tabEditar.Size = new Size(732, 316);
            tabEditar.TabIndex = 2;
            tabEditar.Text = "Editar";
            tabEditar.UseVisualStyleBackColor = true;
            // 
            // txbNombreUsuarioEditar
            // 
            txbNombreUsuarioEditar.Location = new Point(15, 168);
            txbNombreUsuarioEditar.Name = "txbNombreUsuarioEditar";
            txbNombreUsuarioEditar.Size = new Size(691, 23);
            txbNombreUsuarioEditar.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 153);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 21;
            label4.Text = "Nombre Usuario:";
            // 
            // txbCorreoEditar
            // 
            txbCorreoEditar.Location = new Point(12, 115);
            txbCorreoEditar.Name = "txbCorreoEditar";
            txbCorreoEditar.Size = new Size(691, 23);
            txbCorreoEditar.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 100);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 19;
            label5.Text = "Correo:";
            // 
            // cbbRolEditar
            // 
            cbbRolEditar.Cursor = Cursors.Hand;
            cbbRolEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbRolEditar.FormattingEnabled = true;
            cbbRolEditar.Location = new Point(12, 17);
            cbbRolEditar.Name = "cbbRolEditar";
            cbbRolEditar.Size = new Size(687, 23);
            cbbRolEditar.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 2);
            label9.Name = "label9";
            label9.Size = new Size(24, 15);
            label9.TabIndex = 17;
            label9.Text = "Rol";
            // 
            // txbNombreCompletoEditar
            // 
            txbNombreCompletoEditar.Location = new Point(12, 64);
            txbNombreCompletoEditar.Name = "txbNombreCompletoEditar";
            txbNombreCompletoEditar.Size = new Size(691, 23);
            txbNombreCompletoEditar.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 49);
            label10.Name = "label10";
            label10.Size = new Size(110, 15);
            label10.TabIndex = 15;
            label10.Text = "Nombre Completo:";
            // 
            // cbbHabilitado
            // 
            cbbHabilitado.Cursor = Cursors.Hand;
            cbbHabilitado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbHabilitado.FormattingEnabled = true;
            cbbHabilitado.Location = new Point(17, 220);
            cbbHabilitado.Name = "cbbHabilitado";
            cbbHabilitado.Size = new Size(687, 23);
            cbbHabilitado.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 205);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 13;
            label6.Text = "Habilitado:";
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(764, 407);
            Controls.Add(label1);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUsuario";
            Load += frmUsuario_Load;
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            tabControlMain.ResumeLayout(false);
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGuardarEditar;
        private Button btnVolverEditar;
        private Button btnGuardarNuevo;
        private Button btnVolverNuevo;
        private ComboBox cbbRolNuevo;
        private Label label3;
        private TextBox txbNombreCompletoNuevo;
        private Label label2;
        private Button btnNuevo;
        private TabPage tabNuevo;
        private DataGridView dgvUsuarios;
        private Button btnBuscar;
        private TextBox txbBuscar;
        private Button bttnNuevo;
        private TabControl tabControlMain;
        private TabPage tabLista;
        private TabPage tabEditar;
        private TextBox txbNombreUsuarioNuevo;
        private Label label8;
        private TextBox txbCorreoNuevo;
        private Label label7;
        private TextBox txbNombreUsuarioEditar;
        private Label label4;
        private TextBox txbCorreoEditar;
        private Label label5;
        private ComboBox cbbRolEditar;
        private Label label9;
        private TextBox txbNombreCompletoEditar;
        private Label label10;
        private ComboBox cbbHabilitado;
        private Label label6;
    }
}