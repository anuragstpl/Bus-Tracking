using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.Request
{
    [DataContract]
    public class DriverLoginRequest
    {
        [DataMember(Order = 1, IsRequired = true)]
        public string EmailAddress { get; set; }

        [DataMember(Name = "Password", Order = 2, IsRequired = true)]
        public string PasswordHash { get; set; }
    }
}