using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVPresentation.Utilidades;
using SVPresentation.ViewModels;
using SVServices.Interfaces;

namespace SVPresentation.Formularios
{
    public partial class frmDetalleVenta : Form
    {
        private readonly IVentaService _ventaService;
        private readonly INegocioService _negocioService;
        public string _numeroVenta { get; set; } = null!;
        public frmDetalleVenta(IVentaService ventaService, INegocioService negocioService)
        {
            InitializeComponent();
            _ventaService = ventaService;
            _negocioService = negocioService;
        }

        private async void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            dgvDetalle.ImplementarConfiguracion();
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var detalleVenta = await _ventaService.ObtenerDetalle(_numeroVenta);

            var listaVM = detalleVenta.Select(item => new DetalleVentaVM
            {
                Producto = item.RefProducto.Descripcion,
                Precio = item.PrecioVenta,
                CantidadTexto = string.Concat(item.Cantidad, "", item.RefProducto.RefCategoria.RefMedida.Equivalente),
                Total = item.PrecioTotal
            }).ToList();

            lblNumeroVenta.Text = _numeroVenta;
            dgvDetalle.DataSource = listaVM;
            dgvDetalle.Columns["IdProducto"].Visible = false;
            dgvDetalle.Columns["CantidadValor"].Visible = false;

        }

        private async void btnVerPDF_Click(object sender, EventArgs e)
        {
            var oNegocio = await _negocioService.Obtener();
            var oVenta = await _ventaService.Obtener(_numeroVenta);
            var oDetalleVenta = await _ventaService.ObtenerDetalle(_numeroVenta);
            oVenta.RefDetalleVenta = oDetalleVenta;

            MemoryStream imagenLogo;
            using (var httpClient = new HttpClient())
            {
                var imagenBytes = await httpClient.GetByteArrayAsync(oNegocio.UrlLogo);
                imagenLogo = new MemoryStream(imagenBytes);
            }

            var arrayPDF = Util.GeneratePDFVenta(oNegocio, oVenta, imagenLogo);

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = $"Guardar PDF";
                saveFileDialog.DefaultExt = "pdf";
                saveFileDialog.AddExtension = true;
                saveFileDialog.FileName = $"Venta_{_numeroVenta}";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    await File.WriteAllBytesAsync(saveFileDialog.FileName, arrayPDF);
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = saveFileDialog.FileName,
                        UseShellExecute = true
                    });
                }
            }
        }
    }
}
