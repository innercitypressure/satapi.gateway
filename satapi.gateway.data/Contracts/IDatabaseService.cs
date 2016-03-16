using System;
using System.Data;

namespace satapi.gateway.data.Contracts
{
    public interface IDatabaseService
    {
        IDbConnection GetConnection();
    }
}
