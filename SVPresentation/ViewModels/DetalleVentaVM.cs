
using System.ComponentModel;

namespace SVPresentation.ViewModels
{
    public class DetalleVentaVM
    {
        public int IdProducto { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        [DisplayName("Cantidad")]
        public int CantidadValor { get; set; }
        public string CantidadTexto { get; set; }
        public decimal Total { get; set; }
    }
}
