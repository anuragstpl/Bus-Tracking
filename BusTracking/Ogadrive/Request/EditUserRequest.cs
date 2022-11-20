using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.Request
{
    [DataContract]
    public class EditUserRequest
    {
        [DataMember(Order = 2, IsRequired = true)]
        public string FullName { get; set; }

        [DataMember(Order = 3, IsRequired = true)]
        public string PhoneNumber { get; set; }

        [DataMember(Order = 4, IsRequired = true)]
        public string Token { get; set; }
    }
}