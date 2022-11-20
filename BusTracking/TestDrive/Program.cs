using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Text;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Collections.Specialized;

namespace TestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            PushSender push = new PushSender();
            push.SendNotification("APA91bFnAPUDoWttRaqnT31EaCzJ3SlI2bDxMMfj4ZtumRjn6z7nxUy7DvewOMFbMQHR9hjdAYKcRbXY8x29bQfIzWPIM5nBXSoUEhgyffWM2zMhpkILFvJS4tHStfjrZDeLA5skfxN4", "Did you got my message ?");
        }

      
    }

    public class PushSender
    {
        public string SendNotification(string deviceId, string message)
        {
            string GoogleAppID = "AIzaSyCrjlKMtwMuGjkspicXIGkMe6J0FGta7P4";
            var SENDER_ID = "11601833604";
            var value = message;
            WebRequest tRequest;
            tRequest = WebRequest.Create("https://android.googleapis.com/gcm/send");
            tRequest.Method = "post";
            tRequest.ContentType = " application/x-www-form-urlencoded;charset=UTF-8";
            tRequest.Headers.Add(string.Format("Authorization: key={0}", GoogleAppID));

            tRequest.Headers.Add(string.Format("Sender: id={0}", SENDER_ID));

            string postData = "collapse_key=score_update&time_to_live=108&delay_while_idle=1&data.message=" + value + "&data.time=" +
            System.DateTime.Now.ToString() + "&registration_id=" + deviceId + "";
            Console.WriteLine(postData);
            Byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            tRequest.ContentLength = byteArray.Length;

            Stream dataStream = tRequest.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse tResponse = tRequest.GetResponse();

            dataStream = tResponse.GetResponseStream();

            StreamReader tReader = new StreamReader(dataStream);

            String sResponseFromServer = tReader.ReadToEnd();

            tReader.Close();
            dataStream.Close();
            tResponse.Close();
            return sResponseFromServer;
        }
    }
}
