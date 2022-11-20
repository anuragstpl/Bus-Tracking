using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.Request
{
    [DataContract]
    public class UpdateDeviceTokenRequest
    {
        [DataMember(Order = 1, IsRequired = true)]
        public string Token { get; set; }

        [DataMember(Order = 2, IsRequired = true)]
        public string DevicePushToken { get; set; }

        [DataMember(Order = 3, IsRequired = true)]
        public string DeviceType { get; set; }
       
    }
}