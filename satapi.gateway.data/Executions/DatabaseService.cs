using System;
using System.Configuration;
using satapi.gateway.data.Contracts;
using Dapper;
using Npgsql;
using System.Data;

namespace satapi.gateway.data.Executions
{
    public class DatabaseService : IDatabaseService, IDisposable
    {
        private IDbConnection _conn { get; set; }
        private IConnectionStringService ConnectionStringProvider { get; set; }     

        public DatabaseService(IConnectionStringService connectionStringProvider)
        {
            ConnectionStringProvider = connectionStringProvider;
        }

        public IDbConnection Connection
        {
            get
            {
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }

                return _conn;
            }
        }

        public IDbConnection GetConnection()
        {
            var connectionStringProperties = ConnectionStringProvider.GetConnectionString();
            _conn = new NpgsqlConnection(connectionStringProperties.ConnectionString);
            return _conn;
        }

        public void Dispose()
        {
            if (_conn != null)
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                    _conn.Dispose();
                }
                _conn = null;
            }
        }
    }
}
