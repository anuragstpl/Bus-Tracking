using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.Response
{
    [DataContract]
    public class CreateUserResponse:BaseResponse
    {
        [DataMember(Order = 1)]
        public int UserID { get; set; }

        [DataMember(Order = 2)]
        public bool IsLoggedIn { get; set; }

        [DataMember(Order = 3)]
        public string Token { get; set; }
        
    }
}