using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.Request
{
    [DataContract]
    public class UserLogoutRequest
    {
        [DataMember(IsRequired=true)]
        public int UserID { get; set; }
    }
}