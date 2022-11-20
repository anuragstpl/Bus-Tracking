using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.DTO
{
    [DataContract]
    public class VehicleCategory
    {
        [DataMember(Order=2)]
        public int VehichleID { get; set; }

        [DataMember(Order = 3)]
        public string Name { get; set; }

        [DataMember(Order = 4)]
        public decimal RatePerKM { get; set; } 

        [DataMember(Order = 5)]
        public decimal BaseFare { get; set; }

        [DataMember(Order = 6)]
        public decimal WaitPerMinute { get; set; }

        [DataMember(Order = 7)]
        public string Description { get; set; }

        [DataMember(Order = 8)]
        public string Currency { get; set; }
    }
}