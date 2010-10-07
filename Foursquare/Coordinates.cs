using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Foursquare
{
    public class Coordinates
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public override string ToString()
        {
            return Latitude + ";" + Longitude;
        }

        public static Coordinates Parse(XmlNode node)
        {
            if (node == null || node.SelectSingleNode("geolat") == null || node.SelectSingleNode("geolong") == null)
            {
                return null;
            }
            Coordinates coordinates = new Coordinates();
            coordinates.Latitude = Double.Parse(node.SelectSingleNode("geolat").InnerText);
            coordinates.Longitude = Double.Parse(node.SelectSingleNode("geolong").InnerText);
            return coordinates;
        }
    }
}
