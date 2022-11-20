using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.Request
{
    [DataContract]
    public class ChangePasswordRequest
    {
        [DataMember(Order = 1, IsRequired = true)]
        public string BusID { get; set; }

        [DataMember(Order = 2, IsRequired = true)]
        public string OldPassword { get; set; }

        [DataMember(Order = 3, IsRequired = true)]
        public string NewPassword { get; set; }
    }
}