using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.Response
{
    [DataContract]
    public class DriverLoginResponse : BaseResponse
    {
        [DataMember(Order = 1)]
        public int UserID { get; set; }

        [DataMember(Order = 2)]
        public string FullName { get; set; }

        [DataMember(Order = 4)]
        public string PhoneNumber { get; set; }

        [DataMember(Order = 5)]
        public bool IsLoggedIn { get; set; }

        [DataMember(Order = 6)]
        public string Token { get; set; }
    }
}