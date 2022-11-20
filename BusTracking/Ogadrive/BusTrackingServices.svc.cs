using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using Ogadrive.Common;
using Ogadrive.Request;
using Ogadrive.Response;
using OgadriveData.Model;
using OgadriveData.UnitOfWork;
using FTMSBus.Request;
using System.Net;

namespace Ogadrive
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class OgadriveiceServices : IBusTracking
    {
        UOWEntities uow = null;

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }



        public UserLoginResponse DriverLogin(UserLoginRequest driverRequest)
        {
            UserLoginResponse userLoginResponse = new UserLoginResponse();
            userLoginResponse.Message = "Login unsuccessful";

            try
            {
                if (driverRequest != null)
                {

                    using (uow = new UOWEntities())
                    {
                        if (!string.IsNullOrEmpty(driverRequest.Password.ToString()) && !string.IsNullOrEmpty(driverRequest.Number))
                        {
                            BusDetail existUser = uow.BusRepository.Get().Where(u => u.Password == Convert.ToInt32(driverRequest.Password) && driverRequest.Number.Equals(driverRequest.Number)).FirstOrDefault();
                            if (existUser != null)
                            {

                                #region PrepareResponse

                                userLoginResponse.Driver = existUser.Driver;
                                userLoginResponse.Email = existUser.Email;
                                userLoginResponse.ID = existUser.ID;
                                userLoginResponse.LicenseNo = existUser.LicenseNo;
                                userLoginResponse.Name = existUser.Number;
                                userLoginResponse.IsSuccess = true;

                                userLoginResponse.Message = "Successfully Logged-in ";


                                #endregion
                            }
                            else
                            {

                                userLoginResponse.Message = "Enter wrong number or password";
                            }
                        }
                        else
                        {

                            userLoginResponse.Message = "Please pass value of all mandatory fields";
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                userLoginResponse.Message = "An error occurred while authentication";

            }

            return userLoginResponse;
        }

        public UserLogoutResponse UserLogout(UserLogoutRequest userRequest)
        {
            UserLogoutResponse userLogoutResponse = new UserLogoutResponse();
            userLogoutResponse.IsSuccess = userLogoutResponse.IsLoggedIn = false;
            userLogoutResponse.Message = "Logout unsuccessful";
            return userLogoutResponse;

        }

        public UpdateLocationResponse UpdateLocation(UpdateLocationRequest userRequest)
        {
            UpdateLocationResponse updateLocationResponse = new UpdateLocationResponse();
            updateLocationResponse.IsSuccess = false;
            updateLocationResponse.Message = "Update location unsuccessful";
            try
            {
                using (uow = new UOWEntities())
                {
                    BusDetail existingUser = null;
                    existingUser = uow.BusRepository.Get().Where(u => u.ID.Equals(userRequest.ID)).FirstOrDefault();
                    #region Get Existing User
                    if (existingUser != null)
                    {
                        existingUser.Latitude = userRequest.Latitude;
                        existingUser.Longitude = userRequest.Longitude;
                        uow.BusRepository.Update(existingUser);
                        uow.Save();
                        updateLocationResponse.IsSuccess = true;
                        updateLocationResponse.Message = "Update location successfully";
                    }
                    else
                    {
                        updateLocationResponse.Message = "Bus not found";
                    }


                    #endregion
                }

            }
            catch (Exception ex)
            {
                updateLocationResponse.Message = "An error occurred while update user location.";

            }
            return updateLocationResponse;
        }

        public BusDetailResponse GetBusDetails(string ID)
        {
            BusDetailResponse busDetailsResponse = new BusDetailResponse();
            busDetailsResponse.IsSuccess = false;
            busDetailsResponse.Message = "bus details unsuccessful";
            try
            {
                using (uow = new UOWEntities())
                {
                    BusDetail existingUser = null;
                    existingUser = uow.BusRepository.Get().Where(u => u.ID == Convert.ToInt32(ID)).FirstOrDefault();
                    #region Get Existing User
                    if (existingUser != null)
                    {
                        busDetailsResponse.busDetail = existingUser;
                        busDetailsResponse.Message = "bus details successful";
                    }
                    else
                    {
                        busDetailsResponse.Message = "Bus not found";
                    }


                    #endregion
                }

            }
            catch (Exception ex)
            {
                busDetailsResponse.Message = "An error occurred while update user location." + ex.Message;

            }
            return busDetailsResponse;

        }

        public List<BusDetailResponse> GetBusList()
        {
            List<BusDetail> busList = new List<BusDetail>();
            List<BusDetailResponse> busListResponse = new List<BusDetailResponse>();
            BusDetailResponse busDetailsResponse = new BusDetailResponse();
            busDetailsResponse.IsSuccess = false;
            busDetailsResponse.Message = "bus details unsuccessful";
            try
            {
                using (uow = new UOWEntities())
                {
                    BusDetail existingUser = null;
                    busList = uow.BusRepository.Get().ToList();
                    #region Get Existing User
                    foreach (BusDetail item in busList)
                    {
                        BusDetailResponse busd = new BusDetailResponse();
                        busd.busDetail = item;
                        busListResponse.Add(busd);
                    }
                    //if (existingUser != null)
                    //{
                    //    busListResponse.busDetail = existingUser;
                    //}
                    //else
                    //{
                    //    busDetailsResponse.Message = "Bus not found";
                    //}


                    #endregion
                }

            }
            catch (Exception ex)
            {
                busDetailsResponse.Message = "An error occurred while update user location." + ex.Message;

            }
            return busListResponse;

        }

        public ForgetPasswordResponse ForgetPassword(ForgetPasswordRequest userRequest)
        {

            ForgetPasswordResponse forgetPasswordResponse = new ForgetPasswordResponse();

            return forgetPasswordResponse;
        }

        public ChangePasswordResponse ChangePassword(ChangePasswordRequest userRequest)
        {
            ChangePasswordResponse changePasswordResponse = new ChangePasswordResponse();
            return changePasswordResponse;
        }

        public string GetURL(string keyword, string height, string width)
        {
            WebOperationContext.Current.OutgoingResponse.Headers.Add("Access-Control-Allow-Origin", "*");
            //identify preflight request and add extra headers  
            if (WebOperationContext.Current.IncomingRequest.Method == "OPTIONS")
            {
                WebOperationContext.Current.OutgoingResponse.Headers
                    .Add("Access-Control-Allow-Methods", "POST, OPTIONS, GET");
                WebOperationContext.Current.OutgoingResponse.Headers
                    .Add("Access-Control-Allow-Headers",
                         "Content-Type, Accept, Authorization, x-requested-with");
                return null;
            }
            string embedUrl = "";

            string htmlCode = "";
            using (WebClient client = new WebClient())
            {
                htmlCode = client.DownloadString(String.Format("https://www.youtube.com/results?search_query={0}", keyword));
            }
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            doc.LoadHtml(htmlCode);

            var node = doc.DocumentNode.SelectNodes("//div[@class='yt-lockup-content']/h3/a")[0];
            var val = node.Attributes["href"].Value; //10743
            var res = val.Split('=');
            embedUrl = String.Format("<iframe width='10' height='10' src='https://www.youtube.com/embed/{0}' frameborder='0' allowfullscreen></iframe>", res[1]);
            return embedUrl;
        }


    }
}
