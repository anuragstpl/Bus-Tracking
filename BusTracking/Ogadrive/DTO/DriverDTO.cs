using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.DTO
{
    [DataContract]
    public class DriverDTO:UserDTO
    {
        [DataMember]
        public Nullable<System.DateTime> DateOfBirth { get; set; }

        [DataMember]
        public string ICNumber { get; set; }

        [DataMember]
        public string LicenseNo { get; set; }

        [DataMember]
        public string AccountNo { get; set; }

    }
}