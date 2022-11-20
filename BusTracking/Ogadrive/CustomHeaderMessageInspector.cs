using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace Ogadrive
{
    public class CustomHeaderMessageInspector : IDispatchMessageInspector
    {
        public object AfterReceiveRequest(
          ref Message request,
          IClientChannel channel,
          InstanceContext instanceContext)
        {
            return null;
        }

        private static IDictionary<string, string> _headersToInject = new Dictionary<string, string>
      {
        { "Access-Control-Allow-Origin", "*, *" },
        { "Access-Control-Request-Method", "POST,GET,PUT,DELETE,OPTIONS" },
        { "Access-Control-Allow-Headers", "*" }
      };

        public void BeforeSendReply(ref Message reply, object correlationState)
        {
            var httpHeader = reply.Properties["httpResponse"] as HttpResponseMessageProperty;
            foreach (var item in _headersToInject)
                httpHeader.Headers.Add(item.Key, item.Value);
        }
    }

}