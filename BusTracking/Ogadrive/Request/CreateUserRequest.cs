using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FTMSBus.Request
{
    [DataContract]
    public class BusRequest
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
        [DataMember(Order = 8, IsRequired = true)]
        public string Latitude { get; set; }
        [DataMember(Order = 9, IsRequired = true)]
        public string Longitude { get; set; }
        [DataMember(Order = 10, IsRequired = true)]
        public Nullable<int> Password { get; set; }

    }
}