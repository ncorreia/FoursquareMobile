using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Xml;
using System.IO;
using Configuration;

namespace Foursquare
{
    public class FoursquareAPI
    {
        public static CheckIn[] GetLastFriendsCheckIns()
        {
            string url = string.Format("http://api.foursquare.com/v1/checkins");
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Headers.Add("Authorization", "Basic " + AuthHash);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            XmlDocument xdoc = new XmlDocument();
            using (Stream stream = response.GetResponseStream())
            {
                xdoc.Load(stream);
            }
            List<CheckIn> checkIns = new List<CheckIn>();
            foreach (XmlNode n in xdoc.SelectNodes("checkins/checkin"))
            {
                checkIns.Add(Foursquare.CheckIn.Parse(n));
            }
            return checkIns.ToArray();
        }

        public static Venue[] GetVenues(double latitude, double longitude, string keyword)
        {
            string url = string.Format("http://api.foursquare.com/v1/venues?geolat={0}&geolong={1}&l=25&q={2}",
                latitude, longitude, keyword ?? "");
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            XmlDocument xdoc = new XmlDocument();
            using (Stream stream = response.GetResponseStream())
            {
                xdoc.Load(stream);
            }

            List<Venue> venuesList = Venue.ParseList(xdoc);
            Venue[] venues = venuesList.ToArray();
            Array.Sort(venues,
                delegate(Venue v1, Venue v2)
                {
                    return v1.Distance == v2.Distance ? 0 : (v1.Distance > v2.Distance ? 1 : -1);
                });
            return venues;
        }

        public static CheckInInfo CheckIn(long venueId, string venueName, string shout, bool pvt, bool twitter, bool facebook, 
            double latitude, double longitude)
        {
            string url = string.Format("http://api.foursquare.com/v1/checkin?vid={0}&venue={1}&shout={2}&private={3}&twitter={4}&facebook={5}&geolat={6}&geolong={7}",
                venueId, venueName, shout, pvt ? "1" : "0", twitter ? "1" : "0", facebook ? "1" : "0", latitude, longitude);
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "POST";
            //byte[] bytesToEncode = Encoding.UTF8.GetBytes("calhau@mailinator.com:calhauzinho");
            //request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(bytesToEncode));
            request.Headers.Add("Authorization", "Basic " + AuthHash);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            XmlDocument xdoc = new XmlDocument();
            using (Stream stream = response.GetResponseStream())
            {
                xdoc.Load(stream);
            }
            return CheckInInfo.Parse(xdoc.DocumentElement);
        }

        internal static string AuthHash = ConfigurationSettings.AppSettings["auth_hash"];
    }
}

