

using SVServices.Recursos.Cloudinary;

namespace SVServices.Interfaces
{
    public interface ICloudunaryService
    {
        Task<CloudinaryResponse> SubirImagen(string nombreImagen, Stream formatoImagen);
        Task<bool> EliminarImagen(string publicid);
    }
}
