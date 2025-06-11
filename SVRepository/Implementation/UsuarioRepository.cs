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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Conexion _conexion;
        public UsuarioRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task ActualizarClave(int idUsuario, string nuevaClave, int resetear)
        {

            using (var con = _conexion.GetConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_actualizarClave", con);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@NuevaClave", nuevaClave);
                cmd.Parameters.AddWithValue("@Resetear", resetear);
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

        public async Task<string> Crear(Usuario objeto)
        {
            string respuesta = "";

            using (var con = _conexion.GetConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_crearUsuario", con);
                cmd.Parameters.AddWithValue("@IdRol", objeto.RefRol.IdRol);
                cmd.Parameters.AddWithValue("@NombreCompleto", objeto.NombreCompleto);
                cmd.Parameters.AddWithValue("@Correo", objeto.Correo);
                cmd.Parameters.AddWithValue("@NombreUsuario", objeto.NombreUsuario);
                cmd.Parameters.AddWithValue("@Clave", objeto.Clave);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch
                {
                    respuesta = "Error(rp): No se pudo procesar";
                }
            }
            return respuesta;
        }

        public async Task<string> Editar(Usuario objeto)
        {
            string respuesta = "";

            using (var con = _conexion.GetConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_editarUsuario", con);
                cmd.Parameters.AddWithValue("@IdUsuario", objeto.IdUsuario);
                cmd.Parameters.AddWithValue("@IdRol", objeto.RefRol.IdRol);
                cmd.Parameters.AddWithValue("@NombreCompleto", objeto.NombreCompleto);
                cmd.Parameters.AddWithValue("@Correo", objeto.Correo);
                cmd.Parameters.AddWithValue("@NombreUsuario", objeto.NombreUsuario);
                cmd.Parameters.AddWithValue("@Activo", objeto.Activo);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch
                {
                    respuesta = "Error(rp): No se pudo procesar";
                }
            }
            return respuesta;
        }

        public async Task<List<Usuario>> Lista(string buscar = "")
        {
            List<Usuario> lista = new List<Usuario>();

            using (var con = _conexion.GetConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaUsuario", con);
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Usuario
                        {
                            IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                            RefRol = new Rol
                            {
                                IdRol = Convert.ToInt32(dr["IdRol"]),
                                Nombre = dr["NombreRol"].ToString()
                            },
                            NombreCompleto = dr["NombreCompleto"].ToString(),
                            Correo = dr["Correo"].ToString(),
                            NombreUsuario = dr["NombreUsuario"].ToString(),
                            Activo = Convert.ToInt32(dr["Activo"])
                        });
                    }
                }
            }
            return lista;
        }

        public async Task<Usuario> Login(string usuario, string clave)
        {
            Usuario objeto = new Usuario();

            using (var con = _conexion.GetConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_login", con);
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario);
                cmd.Parameters.AddWithValue("@Clave", clave);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        objeto = new Usuario()
                        {
                            IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                            NombreCompleto = dr["NombreCompleto"].ToString(),
                            RefRol = new Rol
                            {
                                IdRol = Convert.ToInt32(dr["IdRol"]),
                                Nombre = dr["NombreRol"].ToString()
                            },
                            Correo = dr["Correo"].ToString(),
                            NombreUsuario = dr["NombreUsuario"].ToString(),
                            ResetearClave = Convert.ToInt32(dr["ResetearClave"]),
                            Activo = Convert.ToInt32(dr["Activo"])
                        };
                    }
                }
            }
            return objeto;
        }

        public async Task<int> VerificarCorreo(string correo)
        {
            int idUsuario;

            using (var con = _conexion.GetConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_varificarCorreo", con);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    idUsuario = Convert.ToInt32(cmd.Parameters["@IdUsuario"].Value)!;
                }
                catch
                {
                    idUsuario = 0;
                }
            }
            return idUsuario;
        }
    }
}
