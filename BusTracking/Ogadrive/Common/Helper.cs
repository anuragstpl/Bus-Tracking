using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OgadriveData.UnitOfWork;

namespace Ogadrive.Common
{
    public class Helper
    {
        UOWEntities uow = null;

        public bool IsEmailExist(string EmailAddress)
        {
            bool isEmailIdAlreadyExists = false;

            using (uow = new UOWEntities())
            {

                isEmailIdAlreadyExists = uow.BusRepository.Get().
                                         Any(sp => EmailAddress.Equals(sp.Email, StringComparison.OrdinalIgnoreCase));
            }
            return isEmailIdAlreadyExists;
        }
        
    }
}