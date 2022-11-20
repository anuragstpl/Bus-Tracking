using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.Response
{
    [DataContract]
    public abstract class BaseResponse
    {
        [DataMember(Order=1)]
        public bool IsSuccess { get; set; }

        [DataMember]
        public string Message { get; set; }

    }
}