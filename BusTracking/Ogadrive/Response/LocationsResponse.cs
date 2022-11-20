using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.Response
{
    [DataContract]
    public class LocationsResponse:BaseResponse
    {
        [DataMember]
        public List<Ogadrive.DTO.Location> Locations { get; set; }
    }
}