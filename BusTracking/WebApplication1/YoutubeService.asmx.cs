using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for YoutubeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class YoutubeService : System.Web.Services.WebService
    {

        [WebMethod]

        public string GetURL(string keyword, string height, string width)
        {
            string embedUrl = "";

            string htmlCode = "";
            keyword = keyword.Replace(" ", "+");
            using (WebClient client = new WebClient())
            {
                htmlCode = client.DownloadString(String.Format("https://www.youtube.com/results?search_query={0}", keyword));
            }
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            doc.LoadHtml(htmlCode);

            var node = doc.DocumentNode.SelectNodes("//div[@class='yt-lockup-content']/h3/a")[0];
            var val = node.Attributes["href"].Value; //10743
            var res = val.Split('=');
            embedUrl = String.Format("<iframe width='{0}' height='{1}' src='https://www.youtube.com/embed/{2}' frameborder='0' allowfullscreen></iframe>", width, height, res[1]);
            return embedUrl;
        }

        [WebMethod]
        public bool CheckURL(string url)
        {
            bool isurlworking = false;
            try
            {
                WebRequest request = WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response != null || response.StatusCode == HttpStatusCode.OK)
                {
                    isurlworking = true;
                }
            }
            catch
            {
                isurlworking = false;
            }
            return isurlworking;
        }

        [WebMethod]
        public string GetURLData(string url)
        {
            string htmlCode = "";
            using (WebClient client = new WebClient())
            {
                htmlCode = client.DownloadString(url);
            }
            return htmlCode;
        }

    }
}
