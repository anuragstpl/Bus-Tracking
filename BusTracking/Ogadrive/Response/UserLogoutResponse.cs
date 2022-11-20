using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.Response
{
    [DataContract]
    public class UserLogoutResponse:BaseResponse
    {
        [DataMember(Order = 3)]
        public bool IsLoggedIn { get; set; }
    }
}