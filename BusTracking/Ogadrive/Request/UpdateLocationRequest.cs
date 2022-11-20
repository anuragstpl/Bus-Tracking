using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.Request
{
    [DataContract]
    public class UpdateLocationRequest
    {

        [DataMember(Order = 1, IsRequired = true)]
        public string Latitude { get; set; }

        [DataMember(Order = 2, IsRequired = true)]
        public string Longitude { get; set; }

        [DataMember(Order = 3, IsRequired = true)]
        public int ID { get; set; }


    }
}