using System;
using System.Configuration;

namespace satapi.gateway.data.Contracts
{
    public interface IConnectionStringService
    {
        ConnectionStringSettings GetConnectionString();
    }
}
