﻿namespace SVPresentation.Formularios
{
    partial class frmVenta
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
            btnRegistrar = new Button();
            btnBuscar = new Button();
            txbCambio = new TextBox();
            label7 = new Label();
            txbPagoCon = new TextBox();
            label6 = new Label();
            txbNombreCliente = new TextBox();
            label4 = new Label();
            txbCodigoProducto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label8 = new Label();
            lblTotal = new Label();
            dgvDetalleVenta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.White;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.ForeColor = Color.FromArgb(30, 90, 195);
            btnRegistrar.Location = new Point(662, 364);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 38;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(500, 85);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 36;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txbCambio
            // 
            txbCambio.Location = new Point(442, 365);
            txbCambio.Name = "txbCambio";
            txbCambio.ReadOnly = true;
            txbCambio.Size = new Size(147, 23);
            txbCambio.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(138, 365);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 30;
            label7.Text = "Pago Con:";
            // 
            // txbPagoCon
            // 
            txbPagoCon.Location = new Point(206, 362);
            txbPagoCon.Name = "txbPagoCon";
            txbPagoCon.Size = new Size(147, 23);
            txbPagoCon.TabIndex = 29;
            txbPagoCon.KeyDown += txbPagoCon_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(387, 368);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 28;
            label6.Text = "Cambio";
            // 
            // txbNombreCliente
            // 
            txbNombreCliente.Location = new Point(28, 146);
            txbNombreCliente.Name = "txbNombreCliente";
            txbNombreCliente.Size = new Size(547, 23);
            txbNombreCliente.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(27, 128);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 24;
            label4.Text = "Nombre Cliente:";
            // 
            // txbCodigoProducto
            // 
            txbCodigoProducto.Location = new Point(28, 85);
            txbCodigoProducto.Name = "txbCodigoProducto";
            txbCodigoProducto.Size = new Size(466, 23);
            txbCodigoProducto.TabIndex = 23;
            txbCodigoProducto.KeyDown += txbCodigoProducto_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(27, 67);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 22;
            label3.Text = "Codigo Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 21;
            label2.Text = "Nueva Venta";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(740, 340);
            label1.TabIndex = 20;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(58, 49, 69);
            label5.Location = new Point(592, 65);
            label5.Name = "label5";
            label5.Size = new Size(145, 97);
            label5.TabIndex = 39;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(58, 49, 69);
            label8.Font = new Font("Segoe UI", 18F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(629, 85);
            label8.Name = "label8";
            label8.Size = new Size(70, 32);
            label8.TabIndex = 40;
            label8.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.FromArgb(58, 49, 69);
            lblTotal.Font = new Font("Segoe UI", 18F);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(592, 117);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(145, 32);
            lblTotal.TabIndex = 41;
            lblTotal.Text = "0";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Location = new Point(28, 191);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.Size = new Size(709, 145);
            dgvDetalleVenta.TabIndex = 42;
            dgvDetalleVenta.CellContentClick += dgvDetalleVenta_CellContentClick;
            // 
            // frmVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(764, 407);
            Controls.Add(dgvDetalleVenta);
            Controls.Add(lblTotal);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(btnRegistrar);
            Controls.Add(btnBuscar);
            Controls.Add(txbCambio);
            Controls.Add(label7);
            Controls.Add(txbPagoCon);
            Controls.Add(label6);
            Controls.Add(txbNombreCliente);
            Controls.Add(label4);
            Controls.Add(txbCodigoProducto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVenta";
            Load += frmVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnBuscar;
        private TextBox txbCambio;
        private Label label7;
        private TextBox txbPagoCon;
        private Label label6;
        private TextBox txbNombreCliente;
        private Label label4;
        private TextBox txbCodigoProducto;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label8;
        private Label lblTotal;
        private DataGridView dgvDetalleVenta;
    }
}