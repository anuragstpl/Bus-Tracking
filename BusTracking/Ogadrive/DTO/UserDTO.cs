using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.DTO
{
    [DataContract]
    public class UserDTO
    {
        [DataMember(Order = 1)]
        public int UserID { get; set; }
        [DataMember(Order = 2)]
        public string FullName { get; set; }
        [DataMember(Order = 3)]
        public string PasswordHash { get; set; }
        [DataMember(Order = 4)]
        public string EmailAddress { get; set; }
        [DataMember(Order = 5)]
        public string PhoneNumber { get; set; }
    }
}