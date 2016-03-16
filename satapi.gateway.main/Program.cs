using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace satapi.gateway.main
{
    class Program
    {
        static void Main(string[] args)
        {
            // load ninja bindings
            IKernel kernel = new StandardKernel(new Bootstrapper());

        }
    }
}
