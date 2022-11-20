﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OgadriveData.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class FTMSBusEntities : DbContext
    {
        public FTMSBusEntities()
            : base("name=FTMSBusEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BusDetail> BusDetails { get; set; }
    
        public virtual ObjectResult<BusOperations_Result> BusOperations(Nullable<int> iD, string name, string number, string driver, string type, string email, string licenseNo, string latitude, string longitude, string mode, Nullable<int> password, ObjectParameter userID)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var numberParameter = number != null ?
                new ObjectParameter("Number", number) :
                new ObjectParameter("Number", typeof(string));
    
            var driverParameter = driver != null ?
                new ObjectParameter("Driver", driver) :
                new ObjectParameter("Driver", typeof(string));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var licenseNoParameter = licenseNo != null ?
                new ObjectParameter("LicenseNo", licenseNo) :
                new ObjectParameter("LicenseNo", typeof(string));
    
            var latitudeParameter = latitude != null ?
                new ObjectParameter("Latitude", latitude) :
                new ObjectParameter("Latitude", typeof(string));
    
            var longitudeParameter = longitude != null ?
                new ObjectParameter("Longitude", longitude) :
                new ObjectParameter("Longitude", typeof(string));
    
            var modeParameter = mode != null ?
                new ObjectParameter("Mode", mode) :
                new ObjectParameter("Mode", typeof(string));
    
            var passwordParameter = password.HasValue ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BusOperations_Result>("BusOperations", iDParameter, nameParameter, numberParameter, driverParameter, typeParameter, emailParameter, licenseNoParameter, latitudeParameter, longitudeParameter, modeParameter, passwordParameter, userID);
        }
    }
}