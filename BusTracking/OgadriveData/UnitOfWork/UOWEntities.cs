using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OgadriveData.Model;
using OgadriveData.OgadriveRepositery;



namespace OgadriveData.UnitOfWork
{
    public class UOWEntities : IDisposable
    {
        FTMSBusRepository<BusDetail> busRepository;

        FTMSBusEntities context = new FTMSBusEntities();


        public FTMSBusRepository<BusDetail> BusRepository
        {
            get
            {
                if (this.busRepository == null)
                    this.busRepository = new FTMSBusRepository<BusDetail>(context);
                return busRepository;
            }
        }
        
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
