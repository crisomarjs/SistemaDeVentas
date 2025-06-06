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

namespace SVRepository.Implementation
{
    public class RolRepository : IRolRepository
    {
        private readonly Conexion _conexion;
        public RolRepository(Conexion conexion)
        {
            _conexion = conexion;
        }
        public async Task<List<Rol>> Lista()
        {
            List<Rol> lista = new List<Rol>();

            using (var con = _conexion.GetConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaRol", con);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Rol
                        {
                            IdRol = Convert.ToInt32(dr["IdRol"]),
                            Nombre = dr["Nombre"].ToString()
                        });
                    }
                }
            }
            return lista;
        }
    }
}
