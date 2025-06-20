﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVPresentation.Utilidades;
using SVServices.Interfaces;

namespace SVPresentation.Formularios
{
    public partial class frmActualizarClave : Form
    {
        private readonly IUsuarioService _usuarioService;
        public int _idUsuario { get; set; }

        public frmActualizarClave(IUsuarioService usuarioService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
        }

        private void frmActualizarClave_Load(object sender, EventArgs e)
        {
            lblValidacion.Visible = false;
            txbClave.Select();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txbClave.Text != txbRepetirClave.Text)
            {
                lblValidacion.Visible = true;
                return;
            }

            await _usuarioService.ActualizarClave(_idUsuario, Util.ConvertToSha256(txbClave.Text), 0);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
