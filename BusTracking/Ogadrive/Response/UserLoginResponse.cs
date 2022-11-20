using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.Response
{
    [DataContract]
    public class UserLoginResponse : BaseResponse
    {
        [DataMember(Order = 1)]
        public int ID { get; set; }
        [DataMember(Order = 2, IsRequired = true)]
        public string Name { get; set; }
        [DataMember(Order = 3, IsRequired = true)]
        public string Number { get; set; }
        [DataMember(Order = 4, IsRequired = true)]
        public string Driver { get; set; }
        [DataMember(Order = 5, IsRequired = true)]
        public string Type { get; set; }
        [DataMember(Order = 6, IsRequired = true)]
        public string Email { get; set; }
        [DataMember(Order = 7, IsRequired = true)]
        public string LicenseNo { get; set; }


    }
}