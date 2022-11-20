using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.DTO
{
    [DataContract]
    public class Location
    {
        [DataMember(Order = 2, IsRequired = true)]
        public int LocationID { get; set; }

        [DataMember(Order = 3, IsRequired = true)]
        public string Name { get; set; }

        [DataMember(Order = 4, IsRequired = true)]
        public string Latitude { get; set; }

        [DataMember(Order = 5, IsRequired = true)]
        public string Longitde { get; set; }

        [DataMember(Order = 6, IsRequired = true)]
        public string State { get; set; }
    }
}