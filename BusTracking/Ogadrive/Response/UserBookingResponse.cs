using OgadriveData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.Response
{
    public class BusDetailResponse:BaseResponse
    {
        [DataMember(Order=2)]
        public BusDetail busDetail { get; set; }
    }
}