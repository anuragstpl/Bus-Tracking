using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.Request
{
    [DataContract]
    public class UserBookingRequest
    {
        [DataMember(Order = 2)]
        public int UserID { get; set; }

        [DataMember(Order = 3, IsRequired = true)]
        public int PickupPlaceID { get; set; }

        [DataMember(Order = 4, IsRequired = true)]
        public int DropPlaceID { get; set; }

        [DataMember(Order = 5, IsRequired = true)]
        public decimal Fare { get; set; }

        [DataMember(Order = 6, IsRequired = true)]
        public decimal DistanceKM { get; set; }

        //[DataMember(Order = 7)]
        //public int Status { get; set; }

        [DataMember(Order=8,IsRequired=true)]
        public string Token { get; set; }

        [DataMember(Order = 9, IsRequired = true)]
        public string BookingDateTime { get; set; }
    }
}