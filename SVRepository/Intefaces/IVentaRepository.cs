
using SVRepository.Entities;

namespace SVRepository.Intefaces
{
    public interface IVentaRepository
    {
        Task<string> Registrar(string ventaXml);
        Task<Venta> Obtener(string numeroVenta);
        Task<List<DetalleVenta>> ObtenerDetalle(string numeroVenta);
    }
}
