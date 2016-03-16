using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satapi.gateway.data.Contracts
{
    public interface IGatewayService
    {
        List<string> GetGateways(string apiKey);
    }
}
