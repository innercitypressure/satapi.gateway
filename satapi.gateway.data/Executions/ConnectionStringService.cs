using System;
using System.Configuration;
using satapi.gateway.data.Contracts;

namespace satapi.gateway.data.Executions
{
    public class ConnectionStringService : IConnectionStringService
    {
        public ConnectionStringSettings GetConnectionString()
        {
            if (ConfigurationManager.ConnectionStrings["GatewayConnectionString"] != null)
            {
                var connectionString = ConfigurationManager.ConnectionStrings["GatewayConnectionString"];

                return new ConnectionStringSettings
                {
                    ConnectionString = connectionString.ConnectionString,
                    ProviderName = connectionString.ProviderName
                };
            }

            throw new InvalidOperationException("Connection String was not found.  Service terminating.");
        }
    }    
}
