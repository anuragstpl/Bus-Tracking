using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.Response
{
    [DataContract]
    public class BookingHistoryResponse:BaseResponse
    {
        [DataMember(Order = 2)]
        public int UserID { get; set; }

        [DataMember(Order = 2)]
        public string UserName { get; set; }

        [DataMember(Order=4)]
        public List<Ogadrive.DTO.BookingDTO> BookingHistory { get; set; }
    }
}