﻿

using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SVRepository.DB
{
    public class Conexion
    {
        private readonly IConfiguration _configuration;
        private readonly string _cadenaSQL;

        public Conexion(IConfiguration configuration)
        {
            _configuration = configuration;
            _cadenaSQL = _configuration.GetConnectionString("CadenaSQL")!;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_cadenaSQL);
        }

    }
}
