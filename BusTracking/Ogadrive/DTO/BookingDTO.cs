using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.DTO
{
    [DataContract]
    public class BookingDTO
    {
        [DataMember(Order = 2)]
        public int BookingID { get; set; }

        [DataMember(Order = 4)]
        public string PickupLocation { get; set; }

        [DataMember(Order = 5)]
        public string DropLocation { get; set; }

        [DataMember(Order = 6)]
        public decimal Fare { get; set; }

        [DataMember(Order = 7)]
        public decimal DistanceKM { get; set; }

        [DataMember(Order = 8)]
        public string Status { get; set; }

        [DataMember(Order = 9)]
        public string BookingDateTime { get; set; }
    }
}