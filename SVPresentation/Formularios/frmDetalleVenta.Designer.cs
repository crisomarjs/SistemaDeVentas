namespace SVPresentation.Formularios
{
    partial class frmDetalleVenta
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
            dgvDetalle = new DataGridView();
            btnVerPDF = new Button();
            label1 = new Label();
            lblNumeroVenta = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(12, 53);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.Size = new Size(719, 251);
            dgvDetalle.TabIndex = 12;
            // 
            // btnVerPDF
            // 
            btnVerPDF.BackColor = Color.White;
            btnVerPDF.Cursor = Cursors.Hand;
            btnVerPDF.FlatStyle = FlatStyle.Flat;
            btnVerPDF.Location = new Point(646, 16);
            btnVerPDF.Name = "btnVerPDF";
            btnVerPDF.Size = new Size(85, 23);
            btnVerPDF.TabIndex = 11;
            btnVerPDF.Text = "Ver PDF";
            btnVerPDF.UseVisualStyleBackColor = false;
            btnVerPDF.Click += btnVerPDF_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 13;
            label1.Text = "Número de Venta:";
            // 
            // lblNumeroVenta
            // 
            lblNumeroVenta.AutoSize = true;
            lblNumeroVenta.Location = new Point(135, 16);
            lblNumeroVenta.Name = "lblNumeroVenta";
            lblNumeroVenta.Size = new Size(13, 15);
            lblNumeroVenta.TabIndex = 14;
            lblNumeroVenta.Text = "0";
            // 
            // frmDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(743, 321);
            Controls.Add(lblNumeroVenta);
            Controls.Add(label1);
            Controls.Add(dgvDetalle);
            Controls.Add(btnVerPDF);
            MaximizeBox = false;
            MaximumSize = new Size(759, 360);
            MinimizeBox = false;
            MinimumSize = new Size(759, 360);
            Name = "frmDetalleVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle de Venta";
            Load += frmDetalleVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDetalle;
        private Button btnVerPDF;
        private Label label1;
        private Label lblNumeroVenta;
    }
}