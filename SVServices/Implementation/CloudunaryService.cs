using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Configuration;
using SVServices.Interfaces;
using SVServices.Recursos.Cloudinary;

namespace SVServices.Implementation
{
    public class CloudunaryService : ICloudunaryService
    {
        private readonly IConfiguration _configuration;
        private readonly Cloudinary _cloudinary;

        public CloudunaryService(IConfiguration configuration)
        {
            _configuration = configuration;

            var CloudName = _configuration["Clouddinary:CloudName"];
            var ApiKey = _configuration["Clouddinary:ApiKey"];
            var ApiSecret = _configuration["Clouddinary:ApiSecret"];

            _cloudinary = new Cloudinary(new Account(CloudName, ApiKey, ApiSecret));
        }

        public async Task<bool> EliminarImagen(string publicid)
        {
            var deleteParams = new DeletionParams(publicid);
            var deleteResult = await _cloudinary.DestroyAsync(deleteParams);
            if (deleteResult.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<CloudinaryResponse> SubirImagen(string nombreImagen, Stream formatoImagen)
        {
            var clodinaryResponse = new CloudinaryResponse();
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(nombreImagen, formatoImagen),
                AssetFolder = "sistemaVentasWF"
            };
            var uploadResult = await _cloudinary.UploadAsync(uploadParams);
            if(uploadResult.StatusCode == System.Net.HttpStatusCode.OK)
            {
                clodinaryResponse.PublicId = uploadResult.PublicId;
                clodinaryResponse.SecureUrl = uploadResult.SecureUri.ToString();
            }
            else
            {
                clodinaryResponse.PublicId = "";
            }
            return clodinaryResponse;
        }
    }
}
