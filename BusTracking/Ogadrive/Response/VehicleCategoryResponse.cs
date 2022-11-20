using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ogadrive.Response
{
    [DataContract]
    public class VehicleCategoryResponse:BaseResponse
    {
        [DataMember]
        public List<Ogadrive.DTO.VehicleCategory> VehichleCategories { get; set; }
    }
}