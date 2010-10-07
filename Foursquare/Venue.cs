using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Net;
using System.IO;

namespace Foursquare
{
    public class Venue
    {
        public Venue()
        {
            Id = -1;
            Name = null;
            PrimaryCategory = null;
            Address = null;
            CrossStreet = null;
            City = null;
            State = null;
            ZipCode = null;
            Coordinates = null;
            Phone = null;
            Twitter = null;
            Distance = 0.0;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public Category PrimaryCategory { get; set; }
        public string Address { get; set; }
        public string CrossStreet { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public Coordinates Coordinates { get; set; }
        public string Phone { get; set; }
        public string Twitter { get; set; }
        public double Distance { get; set; }
        public string[] Tags { get; set; }
        public int CheckIns { get; set; }
        public int HereNow { get; set; }
        public Mayor Mayor { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + Environment.NewLine +
                (Name != null ? "Name: " + Name + Environment.NewLine : "") +
                (PrimaryCategory != null ? "PrimaryCategory: " + PrimaryCategory.ToString() + Environment.NewLine : "") +
                (Address != null ? "Address: " + Address + Environment.NewLine : "") +
                (CrossStreet != null ? "CrossStreet: " + CrossStreet + Environment.NewLine : "") +
                (City != null ? "City: " + City + Environment.NewLine : "") +
                (State != null ? "State: " + State + Environment.NewLine : "") +
                (ZipCode != null ? "ZipCode: " + ZipCode + Environment.NewLine : "") +
                (Coordinates != null ? "Coordinates: " + Coordinates.ToString() + Environment.NewLine : "") +
                (Phone != null ? "Phone: " + Phone + Environment.NewLine : "") +
                (Twitter != null ? "Twitter: " + Twitter + Environment.NewLine : "") +
                "Distance: " + Distance;
        }

        public static Venue GetVenue(long venueId)
        {
            string url = string.Format("http://api.foursquare.com/v1/venue?vid={0}", venueId);
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            XmlDocument xdoc = new XmlDocument();
            using (Stream stream = response.GetResponseStream())
            {
                xdoc.Load(stream);
            }
            return Venue.Parse(xdoc.DocumentElement);
        }

        public static Venue Parse(XmlNode node)
        {
            Venue venue = new Venue();
            if (node.SelectSingleNode("id") != null)
            {
                venue.Id = long.Parse(node.SelectSingleNode("id").InnerText);
            }
            if (node.SelectSingleNode("name") != null)
            {
                venue.Name = node.SelectSingleNode("name").InnerText;
            }
            if (node.SelectSingleNode("primarycategory") != null)
            {
                venue.PrimaryCategory = Category.Parse(node.SelectSingleNode("primarycategory"));
            }
            if (node.SelectSingleNode("address") != null)
            {
                venue.Address = node.SelectSingleNode("address").InnerText;
            }
            if (node.SelectSingleNode("crossstreet") != null)
            {
                venue.CrossStreet = node.SelectSingleNode("crossstreet").InnerText;
            }
            if (node.SelectSingleNode("city") != null)
            {
                venue.City = node.SelectSingleNode("city").InnerText;
            }
            if (node.SelectSingleNode("state") != null)
            {
                venue.State = node.SelectSingleNode("state").InnerText;
            }
            if (node.SelectSingleNode("zip") != null)
            {
                venue.ZipCode = node.SelectSingleNode("zip").InnerText;
            }
            venue.Coordinates = Coordinates.Parse(node);
            if (node.SelectSingleNode("phone") != null)
            {
                venue.Phone = node.SelectSingleNode("phone").InnerText;
            }
            if (node.SelectSingleNode("twitter") != null)
            {
                venue.Twitter = node.SelectSingleNode("twitter").InnerText;
            }
            XmlNode distanceNode = node.SelectSingleNode("distance");
            if (distanceNode != null)
            {
                try
                {
                    venue.Distance = Double.Parse(node.SelectSingleNode("distance").InnerText);
                }
                catch { }
            }
            if (node.SelectSingleNode("tags") != null)
            {
                List<string> tagsList = new List<string>();
                foreach (XmlNode n in node.SelectNodes("tags/tag"))
                {
                    tagsList.Add(n.InnerText);
                }
                venue.Tags = tagsList.ToArray();
            }

            if (node.SelectSingleNode("stats") != null)
            {
                if (node.SelectSingleNode("stats/checkins") != null)
                {
                    venue.CheckIns = int.Parse(node.SelectSingleNode("stats/checkins").InnerText);
                }
                if (node.SelectSingleNode("stats/herenow") != null)
                {
                    venue.HereNow = int.Parse(node.SelectSingleNode("stats/herenow").InnerText);
                }
                if (node.SelectSingleNode("stats/mayor") != null)
                {
                    venue.Mayor = Mayor.Parse(node.SelectSingleNode("stats/mayor"));
                }
            }
            return venue;
        }

        public static List<Venue> ParseList(XmlNode node)
        {
            List<Venue> venuesList = new List<Venue>();
            foreach (XmlNode n in node.SelectNodes("//venue"))
            {
                venuesList.Add(Venue.Parse(n));
            }
            return venuesList;
        }
    }
}
