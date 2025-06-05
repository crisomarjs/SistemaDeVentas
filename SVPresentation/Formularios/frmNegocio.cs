using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVRepository.Entities;
using SVServices.Interfaces;
using SVServices.Recursos.Cloudinary;

namespace SVPresentation.Formularios
{
    public partial class frmNegocio : Form
    {

        private readonly INegocioService _negocioService;
        private readonly ICloudunaryService _cloudunaryService;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        Negocio _negocio = new Negocio();

        public frmNegocio(INegocioService negocioService, ICloudunaryService cloudunaryService)
        {
            InitializeComponent();
            _negocioService = negocioService;
            _cloudunaryService = cloudunaryService;
        }

        private async void frmNegocio_Load(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Escoger Imagen (*.JPG;*.PNG) | *jpg;*.png";
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;

            _negocio = await _negocioService.Obtener();
            txbRazonSocial.Text = _negocio.RazonSocial;
            txbRuc.Text = _negocio.RUC;
            txbDireccion.Text = _negocio.Direccion;
            txbCelular.Text = _negocio.Celular;
            txbCorreo.Text = _negocio.Correo;
            txbDireccion.Text = _negocio.Direccion;
            txbSimboloMoneda.Text = _negocio.SimboloMoneda;
            if (_negocio.UrlLogo != "")
            {
                pbLogo.ImageLocation = _negocio.UrlLogo;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                openFileDialog.OpenFile();
                pbLogo.Image = Image.FromFile(openFileDialog.FileName);

                txbRutaImagen.Text = openFileDialog.FileName;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            CloudinaryResponse cloudinaryResponse = new CloudinaryResponse();
            Negocio objeto = new Negocio();

            if (openFileDialog.FileName != "")
            {
                cloudinaryResponse = await _cloudunaryService.SubirImagen(openFileDialog.SafeFileName, openFileDialog.OpenFile());
                if (cloudinaryResponse.PublicId != "")
                {
                    if (_negocio.NombreLogo != "")
                    {
                        await _cloudunaryService.EliminarImagen(_negocio.NombreLogo);
                    }
                    objeto.NombreLogo = cloudinaryResponse.PublicId;
                    objeto.UrlLogo = cloudinaryResponse.SecureUrl;
                    _negocio.NombreLogo = cloudinaryResponse.PublicId;
                    _negocio.UrlLogo = cloudinaryResponse.SecureUrl;
                }
            }
            else
            {
                objeto.NombreLogo = _negocio.NombreLogo;
                objeto.UrlLogo = _negocio.UrlLogo;
            }

            objeto.RazonSocial = txbRazonSocial.Text;
            objeto.RUC = txbRuc.Text;
            objeto.Direccion = txbDireccion.Text;
            objeto.Celular = txbCelular.Text;
            objeto.Correo = txbCorreo.Text;
            objeto.SimboloMoneda = txbSimboloMoneda.Text;

            await _negocioService.Editar(objeto);
            MessageBox.Show("La información fue actualizada");

            txbRutaImagen.Text = "";
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Escoger Imagen (*.JPG;*.PNG) | *jpg;*.png";
        }
    }
}
