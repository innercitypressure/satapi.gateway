using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using satapi.gateway.data.Contracts;
using satapi.gateway.data.Executions;

namespace satapi.gateway.main
{
    public class Bootstrapper : NinjectModule
    {
        /// <summary>
        /// Bootstrap default Ninja bindings
        /// </summary>
        public override void Load()
        {
            Bind<IConnectionStringService>().To<ConnectionStringService>();
            Bind<IDatabaseService>().To<DatabaseService>().InSingletonScope();            
        }
    }
}
