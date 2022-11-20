using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.Request
{
    [DataContract]
    public class ForgetPasswordRequest
    {
        [DataMember(Order = 1, IsRequired = true)]
        public string EmailAddress { get; set; }
    }
}