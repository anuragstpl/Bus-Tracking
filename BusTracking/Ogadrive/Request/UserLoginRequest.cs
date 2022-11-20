using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.Request
{
    [DataContract]
    public class UserLoginRequest
    {
        [DataMember(Order = 1, IsRequired = true)]
        public string Number { get; set; }
        [DataMember(Order = 2, IsRequired = true)]
        public string Password { get; set; }
        


    }
}