using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace KatanaWinSvcSample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {

#if DEBUG
            var svc = new KatanaWinSvcSample();
            Console.WriteLine("Starting service...");
            svc.InternalStart();
            
            Console.WriteLine("Press any key to stop service");
            Console.ReadLine();
            Console.WriteLine("Stopping service...");
#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new KatanaWinSvcSample() 
            };
            ServiceBase.Run(ServicesToRun);
#endif
        }
    }
}
