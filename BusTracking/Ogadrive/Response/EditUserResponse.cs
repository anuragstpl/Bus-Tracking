using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.Response
{
    [DataContract]
    public class EditUserResponse:BaseResponse
    {
        [DataMember(Order = 3)]
        public string FullName { get; set; }

        [DataMember(Order = 4)]
        public string PhoneNumber { get; set; }
    }
}