﻿using System.Data;
using Microsoft.Data.SqlClient;
using SVRepository.DB;
using SVRepository.Entities;
using SVRepository.Intefaces;

namespace SVRepository.Implementation
{
    public class MedidaRepository : IMedidaRepository
    {
        private readonly Conexion _conexion;
        public MedidaRepository(Conexion conexion)
        {
            _conexion = conexion;
        }
        public async Task<List<Medida>> Lista()
        {
            List<Medida> lista = new List<Medida>();

            using(var con = _conexion.GetConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaMedida", con);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync()) 
                {
                    while(await dr.ReadAsync())
                    {
                        lista.Add(new Medida
                        {
                            IdMedida = Convert.ToInt32(dr["IdMedida"]),
                            Nombre = dr["Nombre"].ToString(),
                            Abreviatura = dr["Abreviatura"].ToString(),
                            Equivalente = dr["Equivalente"].ToString(),
                            Valor = Convert.ToInt32(dr["Valor"]),

                        });
                    }
                }
            }
            return lista;
        }
    }
}
