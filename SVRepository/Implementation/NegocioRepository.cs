using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SVRepository.DB;
using SVRepository.Entities;
using SVRepository.Intefaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SVRepository.Implementation
{
    public class NegocioRepository : INegocioRepository
    {
        private readonly Conexion _conexion;
        public NegocioRepository(Conexion conexion)
        {
            _conexion = conexion;
        }
        public async Task Editar(Negocio negocio)
        {
            using (var con = _conexion.GetConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_editarNegocio", con);
                cmd.Parameters.AddWithValue("@RazonSocial", negocio.RazonSocial);
                cmd.Parameters.AddWithValue("@RUC", negocio.RUC);
                cmd.Parameters.AddWithValue("@Direccion", negocio.Direccion);
                cmd.Parameters.AddWithValue("@Celular", negocio.Celular);
                cmd.Parameters.AddWithValue("@Correo", negocio.Celular);
                cmd.Parameters.AddWithValue("@SimboloMoneda", negocio.SimboloMoneda);
                cmd.Parameters.AddWithValue("@NombreLogo", negocio.NombreLogo);
                cmd.Parameters.AddWithValue("@UrlLogo", negocio.UrlLogo);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                }
                catch
                {
                    throw;
                }
            }
        }

        public async Task<Negocio> Obtener()
        {
           Negocio objeto = new Negocio();

            using (var con = _conexion.GetConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_obtenerNegocio", con);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        objeto = new Negocio()
                        {
                            RazonSocial = dr["RazonSocial"].ToString(),
                            RUC = dr["RUC"].ToString(),
                            Direccion = dr["Direccion"].ToString(),
                            Celular = dr["Celular"].ToString(),
                            Correo = dr["Correo"].ToString(),
                            SimboloMoneda = dr["SimboloMoneda"].ToString(),
                            NombreLogo = dr["NombreLogo"].ToString(),
                            UrlLogo = dr["UrlLogo"].ToString()
                        };
                    }
                }
            }
            return objeto;
        }
    }
}
