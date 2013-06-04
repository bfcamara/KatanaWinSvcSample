using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace KatanaWinSvcSample
{
    public partial class KatanaWinSvcSample : ServiceBase
    {
        IDisposable _webApp;

        public KatanaWinSvcSample()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            InternalStart();
        }

        internal void InternalStart(string url = "http://localhost:12345")
        {
            _webApp = WebApplication.Start<WebStartup>(url);
        }

        protected override void OnStop()
        {
            InternalStop();
        }

        internal void InternalStop()
        {
            if (_webApp != null)
                _webApp.Dispose();
        }
    }
}
