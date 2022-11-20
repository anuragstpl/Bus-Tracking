using PushSharp;
using PushSharp.Android;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ogadrive.Utility
{
    public class Util
    {


        public Boolean SendMail(string sendMailTo, string sendMailFrom, string subject, string Body)
        {
            try
            {
                MailMessage MMsg = null;
                if (sendMailFrom != "")
                {
                    MMsg = new MailMessage(sendMailFrom, sendMailTo);
                    MMsg.From = new MailAddress(sendMailFrom);
                    MMsg.ReplyToList.Add(sendMailFrom);
                }
                else
                {
                    MMsg = new MailMessage();
                    MMsg.ReplyToList.Add(sendMailTo);
                    MMsg.To.Add(sendMailTo);
                }
                MMsg.Subject = subject;
                MMsg.Body = Body;

                MMsg.To.Add(sendMailTo);


                MMsg.IsBodyHtml = true;
                SmtpClient client = new SmtpClient();
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                //client.Credentials=new System.Net.NetworkCredential("rahul."
                client.Send(MMsg);
                return true;

                // sending true for now cause only change on 2/19/2014 is if there is no FROM email.
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void SendPushNotification(string message)
        {
            //Create our push services broker
            var push = new PushBroker();

            //Wire up the events for all the services that the broker registers
            //push.OnNotificationSent += NotificationSent;
            //push.OnChannelException += ChannelException;
            //push.OnServiceException += ServiceException;
            //push.OnNotificationFailed += NotificationFailed;
            //push.OnDeviceSubscriptionExpired += DeviceSubscriptionExpired;
            //push.OnDeviceSubscriptionChanged += DeviceSubscriptionChanged;
            //push.OnChannelCreated += ChannelCreated;
            //push.OnChannelDestroyed += ChannelDestroyed;


            push.RegisterGcmService(new GcmPushChannelSettings(ConfigurationManager.AppSettings["MaxNearestDriver"].ToString()));

            push.QueueNotification(new GcmNotification().ForDeviceRegistrationId("DEVICE REGISTRATION ID HERE")
                                  .WithJson(String.Format(@"{""alert"":""{0}"",""badge"":{1},""sound"":""{2}""}", message, 7, "sound.caf")));


            //Stop and wait for the queues to drains
            push.StopAllServices();
        }

        bool CheckValidDateTime(int year, int month, int day)
        {
            bool check = false;
            if (year <= DateTime.MaxValue.Year && year >= DateTime.MinValue.Year)
            {
                if (month >= 1 && month <= 12)
                {
                    if (DateTime.DaysInMonth(year, month) >= day && day >= 1)
                        check = true;
                }
            }

            return check;

        }
        public DateTime ConvertTimeStampMilisecondsToUTCDateTime(double unixTimeStamp)
        {

            DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            double MaxUnixSeconds = (DateTime.MaxValue - UnixEpoch).TotalSeconds;
            return unixTimeStamp > MaxUnixSeconds ? UnixEpoch.AddMilliseconds(unixTimeStamp) : UnixEpoch.AddSeconds(unixTimeStamp);
        }



        public double ConvertToTimestamp(DateTime value)
        {
            DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan elapsedTime = value - Epoch;
            return elapsedTime.TotalMilliseconds;

        }

        private byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = MD5.Create();  //or use SHA1.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }



    }
}
