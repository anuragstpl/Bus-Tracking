using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Ogadrive.Request;
using Ogadrive.Response;
using OgadriveData.Model;

namespace Ogadrive
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IBusTracking
    {

        [OperationContract]
        [WebInvoke(Method = "POST",
                  BodyStyle = WebMessageBodyStyle.Bare,
                  RequestFormat = WebMessageFormat.Json,
                  ResponseFormat = WebMessageFormat.Json,
                  UriTemplate = "/DriverLogin")]
        UserLoginResponse DriverLogin(UserLoginRequest driverRequest);

        [OperationContract]
        [WebInvoke(Method = "POST",
                  BodyStyle = WebMessageBodyStyle.Bare,
                  RequestFormat = WebMessageFormat.Json,
                  ResponseFormat = WebMessageFormat.Json,
                  UriTemplate = "/Logout")]
        UserLogoutResponse UserLogout(UserLogoutRequest userRequest);

        [OperationContract]
        [WebInvoke(Method = "GET",
                  BodyStyle = WebMessageBodyStyle.Bare,
                  RequestFormat = WebMessageFormat.Json,
                  ResponseFormat = WebMessageFormat.Json,
                  UriTemplate = "/GetBusList")]
        List<BusDetailResponse> GetBusList();


        [OperationContract]
        [WebInvoke(Method = "GET",
                  BodyStyle = WebMessageBodyStyle.Bare,
                  RequestFormat = WebMessageFormat.Json,
                  ResponseFormat = WebMessageFormat.Json,
                  UriTemplate = "/GetBusDetails/{ID}")]
        BusDetailResponse GetBusDetails(string ID);

        [OperationContract]
        [WebInvoke(Method = "POST",
                  BodyStyle = WebMessageBodyStyle.Bare,
                  RequestFormat = WebMessageFormat.Json,
                  ResponseFormat = WebMessageFormat.Json,
                  UriTemplate = "/UpdateLocation")]
        UpdateLocationResponse UpdateLocation(UpdateLocationRequest userRequest);

        [OperationContract]
        [WebInvoke(Method = "POST",
                  BodyStyle = WebMessageBodyStyle.Bare,
                  RequestFormat = WebMessageFormat.Json,
                  ResponseFormat = WebMessageFormat.Json,
                  UriTemplate = "/ForgetPassword")]
        ForgetPasswordResponse ForgetPassword(ForgetPasswordRequest userRequest);

        [OperationContract]
        [WebInvoke(Method = "POST",
                  BodyStyle = WebMessageBodyStyle.Bare,
                  RequestFormat = WebMessageFormat.Json,
                  ResponseFormat = WebMessageFormat.Json,
                  UriTemplate = "/ChangePassword")]
        ChangePasswordResponse ChangePassword(ChangePasswordRequest userRequest);


        [OperationContract]
        [WebInvoke(Method = "*",
                  BodyStyle = WebMessageBodyStyle.Bare,
                  RequestFormat = WebMessageFormat.Json,
                  ResponseFormat = WebMessageFormat.Json,
                  UriTemplate = "/GetEmbedURL/{keyword}/{height}/{width}")]
        string GetURL(string keyword, string height, string width);


    }

}
