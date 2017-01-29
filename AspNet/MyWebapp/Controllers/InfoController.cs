using System.Configuration;
using System.Web;
using System.Web.Http;

namespace MyWebapp.Api
{
    public class InfoController : ApiController
    {
        [Route("api/info/version")]
        public string GetVersion()
        {
            return ConfigurationManager.AppSettings["NetVersion"];
        }

        [Route("api/info/machine")]
        public string GetMachine()
        {
            return HttpContext.Current.Server.MachineName;
        }
    }
}