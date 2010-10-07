using System.Net;
using System.IO;
using System.Xml;

namespace OpenCellId
{
    public class OCI
    {
        private static string API_KEY = "c2c0a6c696123b42b57502292bf3d915";
        private static string commonUrl = "http://www.opencellid.org/cell/get?key={0}&mnc={1}&mcc={2}&lac={3}&cellid={4} ";

        public static string GetCoordinates(string cellIdInfo)
        {
            string[] cellIdInfoParts = cellIdInfo.Split('-');
            string url = string.Format(commonUrl, API_KEY, "1", cellIdInfoParts[2], cellIdInfoParts[1], cellIdInfoParts[0]);
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            XmlDocument xdoc = new XmlDocument();
            using (Stream stream = response.GetResponseStream())
            {
                xdoc.Load(stream);
            }
            string latitude = xdoc.SelectSingleNode("/rsp/cell").Attributes["lat"].InnerText;
            string longitude = xdoc.SelectSingleNode("/rsp/cell").Attributes["lon"].InnerText;

            return latitude + ";" + longitude;
        }
    }
}