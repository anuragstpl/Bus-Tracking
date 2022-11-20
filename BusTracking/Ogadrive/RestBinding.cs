using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace Ogadrive
{
    public class RestBinding : WebHttpBinding
    {
        public RestBinding()
        {
            this.Namespace = "Ogadrive";
            this.Name = "";
            this.CrossDomainScriptAccessEnabled = true;
        }
    }
}