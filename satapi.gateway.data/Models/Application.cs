using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satapi.gateway.data.Models
{
    public class Application
    {
        public int applicationId { get; set; }
        public string name { get; set; }
        public string apiKey { get; set; }
        public List<Resource> resources { get; set; }
    }
}
