using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace KatanaWinSvcSample.Api
{
    public class HomeController : ApiController
    {
        public string Get()
        {
            return "KatanaWinSvcSample Api";
        }
    }
}
